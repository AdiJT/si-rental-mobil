using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIRentalMobil.Domain.Entities;
using SIRentalMobil.Domain.Enums;
using SIRentalMobil.Infrastructure.Database;
using SIRentalMobil.Web.Authentication;
using SIRentalMobil.Web.Models.MobilModels;
using SIRentalMobil.Web.Services.FileUpload;

namespace SIRentalMobil.Web.Controllers;

public class MobilController : Controller
{
    private readonly AppDbContext _appDbContext;
    private readonly ISignInManager _signInManager;
    private readonly IFileUploadService _fileUploadService;
    private readonly ILogger<MobilController> _logger;

    public MobilController(
        AppDbContext appDbContext,
        ISignInManager signInManager,
        IFileUploadService fileUploadService,
        ILogger<MobilController> logger)
    {
        _appDbContext = appDbContext;
        _signInManager = signInManager;
        _fileUploadService = fileUploadService;
        _logger = logger;
    }

    public async Task<IActionResult> Pencarian(
        bool luarKota = false,
        bool sopir = false,
        DateOnly? tanggalMulai = null,
        DateOnly? tanggalAkhir = null)
    {
        var daftarMobil = await _appDbContext.TblMobil
            .Include(m => m.Pemilik)
            .Include(m => m.DaftarPesanan)
            .Where(m => m.Status == StatusMobil.Tersedia)
            .ToListAsync();

        if (luarKota)
            daftarMobil = daftarMobil.Where(m => m.LuarKota).ToList();

        if (sopir)
            daftarMobil = daftarMobil.Where(m => m.Sopir).ToList();

        tanggalMulai ??= DateOnly.FromDateTime(DateTime.Now);
        tanggalAkhir ??= DateOnly.FromDateTime(DateTime.Now);

        var jumlahHari = (int)Math.Ceiling(TimeSpan.FromDays(tanggalAkhir.Value.DayNumber - tanggalMulai.Value.DayNumber).TotalDays) + 1;
        daftarMobil = daftarMobil.Where(m => m.MaksHariSewa >= jumlahHari).ToList();

        return View(new PencarianVM
        {
            DaftarMobil = daftarMobil,
            Sopir = sopir,
            LuarKota = luarKota,
            TanggalMulai = tanggalMulai.Value,
            TanggalAkhir = tanggalAkhir.Value,
            JumlahHariSewa = jumlahHari
        });
    }

    public async Task<IActionResult> Detail(
        int id,
        bool luarKota = false,
        bool sopir = false,
        DateOnly? tanggalMulai = null,
        DateOnly? tanggalAkhir = null)
    {
        var mobil = await _appDbContext.TblMobil
            .Include(m => m.Pemilik)
            .FirstOrDefaultAsync(m => m.Id == id);

        if (mobil is null) return NotFound();

        tanggalMulai ??= DateOnly.FromDateTime(DateTime.Now);
        tanggalAkhir ??= DateOnly.FromDateTime(DateTime.Now);

        var jumlahHari = (int)Math.Ceiling(TimeSpan.FromDays(tanggalAkhir.Value.DayNumber - tanggalMulai.Value.DayNumber).TotalDays) + 1;

        return View(new DetailVM
        {
            Mobil = mobil,
            Sopir = sopir,
            LuarKota = luarKota,
            TanggalMulai = tanggalMulai.Value,
            TanggalAkhir = tanggalAkhir.Value,
            JumlahHariSewa = jumlahHari
        });
    }

    [Authorize(Roles = UserRoles.Pemilik)]
    public IActionResult Tambah()
    {
        return View(new TambahVM());
    }

    [Authorize(Roles = UserRoles.Pemilik)]
    [HttpPost]
    public async Task<IActionResult> Tambah(TambahVM vm)
    {
        var user = await _signInManager.GetUser();
        if (user is null || user.Role != UserRoles.Pemilik) return Unauthorized();

        if (!ModelState.IsValid) return View(vm);

        var urlGambar = await _fileUploadService.UploadFile<TambahVM>(vm.FotoMobil, "/mobil", [".png", ".jpg", ".jpeg"], 0, long.MaxValue);
        if (urlGambar.IsFailure)
        {
            ModelState.AddModelError(nameof(TambahVM.FotoMobil), urlGambar.Error.Message);
            return View(vm);
        }

        var mobil = new Mobil
        {
            Nama = vm.Nama,
            Jenis = vm.Jenis,
            CC = vm.CC,
            Dekripsi = vm.Dekripsi,
            JenisBensin = vm.JenisBensin,
            JenisTransmisi = vm.JenisTransmisi,
            LuarKota = vm.LuarKota,
            MaksHariSewa = vm.MaksHariSewa,
            MaksPenumpang = vm.MaksPenumpang,
            NomorPlat = vm.NomorPlat,
            Sopir = vm.Sopir,
            Tahun = vm.Tahun,
            Tarif = vm.Tarif,
            UrlGambar = urlGambar.Value,
            Pemilik = user
        };
        _appDbContext.TblMobil.Add(mobil);

        try
        {
            await _appDbContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Tambah Mobil. At {@time}", DateTime.Now);
            ModelState.AddModelError(string.Empty, "Simpan Gagal");
            return View(vm);
        }

        return RedirectToAction(nameof(Detail), new { id = mobil.Id });
    }
}
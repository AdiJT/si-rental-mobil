using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIRentalMobil.Domain.Entities;
using SIRentalMobil.Domain.Enums;
using SIRentalMobil.Infrastructure.Database;
using SIRentalMobil.Web.Authentication;
using SIRentalMobil.Web.Models.PenyewaModels;

namespace SIRentalMobil.Web.Controllers;

[Authorize(Roles = UserRoles.Penyewa)]
public class PenyewaController : Controller
{
    private readonly AppDbContext _appDbContext;
    private readonly ILogger<PenyewaController> _logger;
    private readonly ISignInManager _signInManager;

    public PenyewaController(AppDbContext appDbContext, ISignInManager signInManager, ILogger<PenyewaController> logger)
    {
        _appDbContext = appDbContext;
        _signInManager = signInManager;
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> Pemesanan(int id, bool sopir, bool luarKota, DateOnly tanggalMulai, DateOnly tanggalAkhir)
    {
        var mobil = await _appDbContext.TblMobil.FirstOrDefaultAsync(m => m.Id == id);
        if (mobil is null) return NotFound();

        var jumlahHari = (int)Math.Ceiling(TimeSpan.FromDays(tanggalAkhir.DayNumber - tanggalMulai  .DayNumber).TotalDays) + 1;

        return View(new PemesananVM
        {
            MobilId = id,
            Mobil = mobil,
            TanggalAkhir = tanggalAkhir,
            TanggalMulai = tanggalMulai,
            JumlahHariSewa = jumlahHari,
            LuarKota = luarKota,
            Sopir = sopir
        });
    }

    [HttpPost]
    public async Task<IActionResult> Pemesanan(PemesananVM vm)
    {
        var mobil = await _appDbContext.TblMobil.FirstOrDefaultAsync(m => m.Id == vm.MobilId);
        if(mobil is null) return NotFound();

        var user = await _signInManager.GetUser();
        if (user is null || user.Role != UserRoles.Penyewa) return Unauthorized();

        var pesanan = new Pesanan
        {
            LuarKota = vm.LuarKota,
            Sopir = vm.Sopir,
            TanggalPesan = DateTime.Now,
            TanggalAwalSewa = vm.TanggalMulai.ToDateTime(TimeOnly.FromDateTime(DateTime.Now)),
            TanggalAkhirSewa = vm.TanggalAkhir.ToDateTime(TimeOnly.FromDateTime(DateTime.Now)),
            Mobil = mobil,
            Penyewa = user,
            Status = StatusPesanan.BelumDiterima
        };

        _appDbContext.TblPesanan.Add(pesanan);

        try
        {
            await _appDbContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error tambah pesanan");

            return View(vm);
        }

        return RedirectToAction("DetailPesanan", new { id=pesanan.Id });
    }

    public IActionResult Pembayaran()
    {
        return View();
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
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

    public async Task<IActionResult> Index()
    {
        var user = await _signInManager.GetUser();
        if (user is null || user.Role != UserRoles.Penyewa) return Unauthorized();

        user = await _appDbContext.TblUser
            .Include(p => p.DaftarPesanan).ThenInclude(p => p.Mobil)
            .Include(p => p.DaftarPesanan).ThenInclude(p => p.Pembayaran)
            .FirstAsync(u => u == user);

        return View(user);
    }

    public async Task<IActionResult> TambahPesanan(int id, bool sopir, bool luarKota, DateOnly tanggalMulai, DateOnly tanggalAkhir)
    {
        var user = await _signInManager.GetUser();
        if (user is null || user.Role != UserRoles.Penyewa) return Unauthorized();

        var bisaPesan = !await _appDbContext.TblPesanan
            .AnyAsync(p =>
                p.Penyewa == user &&
                (p.Status == StatusPesanan.BelumDiterima || p.Status == StatusPesanan.BelumBayar ||
                    (p.Status == StatusPesanan.SudahBayar && p.TanggalAkhirSewa >= DateTime.Now)));

        if (!bisaPesan) return View("TidakBisaPesan");

        var mobil = await _appDbContext.TblMobil.FirstOrDefaultAsync(m => m.Id == id);
        if (mobil is null) return NotFound();

        return View(new TambahPesananVM
        {
            MobilId = id,
            TanggalAkhir = tanggalAkhir,
            TanggalMulai = tanggalMulai,
            LuarKota = luarKota,
            Sopir = sopir
        });
    }

    [HttpPost]
    public async Task<IActionResult> TambahPesanan(TambahPesananVM vm)
    {
        if (!ModelState.IsValid) return View(vm);

        var mobil = await _appDbContext.TblMobil.FirstOrDefaultAsync(m => m.Id == vm.MobilId);
        if (mobil is null) return NotFound();

        var user = await _signInManager.GetUser();
        if (user is null || user.Role != UserRoles.Penyewa) return Unauthorized();

        var time = TimeOnly.FromDateTime(DateTime.Now);

        var pesanan = new Pesanan
        {
            LuarKota = vm.LuarKota,
            Sopir = vm.Sopir,
            TanggalPesan = DateTime.Now,
            TanggalAwalSewa = vm.TanggalMulai.ToDateTime(time),
            TanggalAkhirSewa = vm.TanggalAkhir.ToDateTime(time),
            Mobil = mobil,
            Penyewa = user,
            Status = StatusPesanan.BelumDiterima
        };

        mobil.Status = StatusMobil.TidakTersedia;

        _appDbContext.TblPesanan.Add(pesanan);
        _appDbContext.TblMobil.Update(mobil);

        try
        {
            await _appDbContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error tambah pesanan");

            return View(vm);
        }

        return RedirectToAction("DetailPesanan", new { id = pesanan.Id });
    }

    public async Task<IActionResult> DetailPesanan(int id)
    {
        var user = await _signInManager.GetUser();
        if (user is null || user.Role != UserRoles.Penyewa) return Unauthorized();

        var pesanan = await _appDbContext.TblPesanan
            .Include(p => p.Mobil).ThenInclude(m => m.Pemilik)
            .Include(p => p.Penyewa)
            .Include(p => p.Pembayaran)
            .FirstOrDefaultAsync(p => p.Id == id);

        if (pesanan is null) return NotFound();

        if (pesanan.Penyewa != user) return Unauthorized();

        return View(pesanan);
    }

    public async Task<IActionResult> Pembayaran(int id)
    {
        var user = await _signInManager.GetUser();
        if (user is null || user.Role != UserRoles.Penyewa) return Unauthorized();

        var pesanan = await _appDbContext.TblPesanan
            .Include(p => p.Mobil).ThenInclude(m => m.Pemilik)
            .Include(p => p.Penyewa)
            .Include(p => p.Pembayaran)
            .FirstOrDefaultAsync(p => p.Id == id);

        if (pesanan is null) return NotFound();

        if (pesanan.Penyewa != user) return Unauthorized();

        if (pesanan.Status != StatusPesanan.BelumBayar) return BadRequest();

        return View(new PembayaranVM { PesananId = id });
    }

    [HttpPost]
    public async Task<IActionResult> Pembayaran(PembayaranVM vm)
    {
        var user = await _signInManager.GetUser();
        if (user is null || user.Role != UserRoles.Penyewa) return Unauthorized();

        var pesanan = await _appDbContext.TblPesanan
            .Include(p => p.Mobil).ThenInclude(m => m.Pemilik)
            .Include(p => p.Penyewa)
            .Include(p => p.Pembayaran)
            .FirstOrDefaultAsync(p => p.Id == vm.PesananId);

        if (pesanan is null) return BadRequest();

        if (pesanan.Penyewa != user) return Unauthorized();

        if (pesanan.Status != StatusPesanan.BelumBayar) return BadRequest();

        var metodePembayaran = await _appDbContext.TblMetodePembayaran.FirstOrDefaultAsync(m => m.Id == vm.MetodePembayaranId);
        if (metodePembayaran is null) return BadRequest();

        var pembayaran = new Pembayaran
        {
            TanggalBayar = DateTime.Now,
            MetodePembayaran = metodePembayaran,
            Pesanan = pesanan,
            PesananId = pesanan.Id
        };

        pesanan.Pembayaran = pembayaran;
        pesanan.Status = StatusPesanan.SudahBayar;

        _appDbContext.TblPembayaran.Add(pembayaran);
        _appDbContext.TblPesanan.Update(pesanan);

        try
        {
            await _appDbContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error saat pembayaran");
            ModelState.AddModelError(string.Empty, "Gagal saat memproses pembayaran");
            return View(vm);
        }

        return RedirectToAction(nameof(DetailPesanan), new { id = vm.PesananId });
    }
}

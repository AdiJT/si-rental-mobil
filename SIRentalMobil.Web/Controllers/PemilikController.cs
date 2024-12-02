using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIRentalMobil.Domain.Entities;
using SIRentalMobil.Domain.Enums;
using SIRentalMobil.Infrastructure.Database;
using SIRentalMobil.Web.Authentication;

namespace SIRentalMobil.Web.Controllers;

[Authorize(Roles = UserRoles.Pemilik)]
public class PemilikController : Controller
{
    private readonly AppDbContext _appDbContext;
    private readonly ISignInManager _signInManager;
    private readonly ILogger<PemilikController> _logger;

    public PemilikController(AppDbContext appDbContext, ISignInManager signInManager, ILogger<PemilikController> logger)
    {
        _appDbContext = appDbContext;
        _signInManager = signInManager;
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        var user = await _signInManager.GetUser();
        if(user is null || user.Role != UserRoles.Pemilik) return Unauthorized();

        user = await _appDbContext.TblUser
            .Include(u => u.DaftarMobil).ThenInclude(m => m.DaftarPesanan).ThenInclude(p => p.Pembayaran)
            .Include(u => u.DaftarMobil).ThenInclude(m => m.DaftarPesanan).ThenInclude(p => p.Penyewa)
            .FirstOrDefaultAsync(u => u == user);

        return View(user);
    }

    public async Task<IActionResult> DetailPemesanan(int id)
    {
        var user = await _signInManager.GetUser();

        if (user is null || user.Role != UserRoles.Pemilik) return Unauthorized();

        var pesanan = await _appDbContext.TblPesanan
            .Include(p => p.Penyewa)
            .Include(p => p.Mobil).ThenInclude(m => m.Pemilik)
            .Include(p => p.Pembayaran)
            .FirstOrDefaultAsync(p => p.Id == id);

        if(pesanan is null) return NotFound();

        if (pesanan.Mobil.Pemilik != user) return Unauthorized();

        return View(pesanan);
    }

    public async Task<IActionResult> TerimaPesanan(int id)
    {
        var pesanan = await _appDbContext.TblPesanan.FirstOrDefaultAsync(p => p.Id == id);
        if (pesanan is null) return NotFound();

        if(pesanan.Status == StatusPesanan.BelumDiterima)
            pesanan.Status = StatusPesanan.BelumBayar;

        _appDbContext.TblPesanan.Update(pesanan);

        try
        {
            await _appDbContext.SaveChangesAsync(); 
        }
        catch(Exception ex)
        {
            _logger.LogError(ex, "Error Terima Pesanan At {@time}", DateTime.Now);
        }

        return RedirectToAction(nameof(DetailPemesanan), new { id });
    }

    public async Task<IActionResult> TolakPesanan(int id)
    {
        var pesanan = await _appDbContext.TblPesanan
            .Include(p => p.Mobil)
            .FirstOrDefaultAsync(p => p.Id == id);

        if (pesanan is null) return NotFound();

        if (pesanan.Status == StatusPesanan.BelumDiterima)
        {
            pesanan.Status = StatusPesanan.Batal;
            pesanan.Mobil.Status = StatusMobil.Tersedia;

            _appDbContext.TblMobil.Update(pesanan.Mobil);
        }

        _appDbContext.TblPesanan.Update(pesanan);

        try
        {
            await _appDbContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error Terima Pesanan At {@time}", DateTime.Now);
        }

        return RedirectToAction(nameof(DetailPemesanan), new { id });
    }
}
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIRentalMobil.Domain.Entities;
using SIRentalMobil.Infrastructure.Database;
using SIRentalMobil.Web.Authentication;

namespace SIRentalMobil.Web.Controllers;

[Authorize(Roles = UserRoles.Pemilik)]
public class PemilikController : Controller
{
    private readonly AppDbContext _appDbContext;
    private readonly ISignInManager _signInManager;

    public PemilikController(AppDbContext appDbContext, ISignInManager signInManager)
    {
        _appDbContext = appDbContext;
        _signInManager = signInManager;
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
        var pesanan = await _appDbContext.TblPesanan
            .Include(p => p.Penyewa)
            .Include(p => p.Mobil).ThenInclude(m => m.Pemilik)
            .Include(p => p.Pembayaran)
            .FirstOrDefaultAsync(p => p.Id == id);

        if(pesanan is null) return NotFound();

        return View(pesanan);
    }
}
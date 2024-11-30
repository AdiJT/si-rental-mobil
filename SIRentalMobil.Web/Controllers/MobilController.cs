using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIRentalMobil.Domain.Enums;
using SIRentalMobil.Infrastructure.Database;
using SIRentalMobil.Web.Models.MobilModels;

namespace SIRentalMobil.Web.Controllers;

public class MobilController : Controller
{
    private readonly AppDbContext _appDbContext;

    public MobilController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<IActionResult> Pencarian(
        bool luarKota = false,
        bool? sopir = null,
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

        if(sopir is not null)
            daftarMobil = daftarMobil.Where(m => m.Sopir == sopir).ToList();

        var jumlahHari = 1;
        if(tanggalMulai is not null && tanggalAkhir is not null)
        {
            jumlahHari = (int)Math.Ceiling(TimeSpan.FromDays(tanggalAkhir.Value.DayNumber - tanggalMulai.Value.DayNumber).TotalDays) + 1;
            daftarMobil = daftarMobil.Where(m => m.MaksHariSewa >= jumlahHari).ToList();
        }

        return View(new PencarianVM
        {
            DaftarMobil = daftarMobil,
            Sopir = sopir,
            LuarKota = luarKota,
            TanggalMulai = tanggalMulai,
            TanggalAkhir = tanggalAkhir,
            JumlahHariSewa = jumlahHari
        }); 
    }

    public async Task<IActionResult> Detail(
        int id, 
        bool luarKota = false,
        bool? sopir = null,
        DateOnly? tanggalMulai = null,
        DateOnly? tanggalAkhir = null)
    {
        var mobil = await _appDbContext.TblMobil
            .Include(m => m.Pemilik)
            .FirstOrDefaultAsync(m => m.Id == id);

        if (mobil is null) return NotFound();

        var jumlahHari = 1;
        if (tanggalMulai is not null && tanggalAkhir is not null)
            jumlahHari = (int)Math.Ceiling(TimeSpan.FromDays(tanggalAkhir.Value.DayNumber - tanggalMulai.Value.DayNumber).TotalDays) + 1;

        return View(new DetailVM
        {
            Mobil = mobil,
            Sopir = sopir,
            LuarKota = luarKota,
            TanggalMulai = tanggalMulai,
            TanggalAkhir = tanggalAkhir,
            JumlahHariSewa = jumlahHari
        });
    }

    public IActionResult Tambah()
    {
        return View();
    }
}

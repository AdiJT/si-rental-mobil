using Microsoft.AspNetCore.Mvc;

namespace SIRentalMobil.Web.Controllers;

public class PemilikController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult TambahMobil()
    {
        return View();
    }

    public IActionResult DetailPemesanan()
    {
        return View();
    }
}
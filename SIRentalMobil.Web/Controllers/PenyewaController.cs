using Microsoft.AspNetCore.Mvc;

namespace SIRentalMobil.Web.Controllers;

public class PenyewaController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Pemesanan()
    {
        return View();
    }

    public IActionResult Pembayaran()
    {
        return View();
    }
}

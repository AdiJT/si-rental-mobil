using Microsoft.AspNetCore.Mvc;

namespace SIRentalMobil.Web.Controllers;

public class MobilController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult HasilPencarian()
    { 
        return View(); 
    }

    public IActionResult Detail()
    {
        return View();
    }
}

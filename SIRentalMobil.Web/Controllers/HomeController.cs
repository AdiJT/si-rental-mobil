using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIRentalMobil.Domain.Entities;
using SIRentalMobil.Web.Authentication;
using SIRentalMobil.Web.Models;
using SIRentalMobil.Web.Models.HomeModels;
using System.Diagnostics;

namespace SIRentalMobil.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISignInManager _signInManager;

        public HomeController(ILogger<HomeController> logger, ISignInManager signInManager)
        {
            _logger = logger;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string? returnUrl)
        {
            returnUrl ??= Url.Action(nameof(Index))!;

            return View(new LoginVM { ReturnUrl = returnUrl });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM vm)
        {
            if (!ModelState.IsValid) return View(vm);

            var result = await _signInManager.SignIn(vm.Email, vm.Password);
            if(result.IsFailure)
            {
                ModelState.AddModelError(string.Empty, result.Error.Message);
                return View(vm);
            }

            return Redirect(vm.ReturnUrl);
        }

        public IActionResult Daftar()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = $"{UserRoles.Pemilik}, {UserRoles.Penyewa}")]
        public async Task<IActionResult> Logout(string? returnUrl = null)
        {
            returnUrl ??= Url.Action(nameof(Index))!;

            var result = await _signInManager.SignOut();
            if(result.IsFailure) return StatusCode(StatusCodes.Status500InternalServerError);

            return Redirect(returnUrl);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

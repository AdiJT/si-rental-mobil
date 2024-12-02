using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIRentalMobil.Domain.Entities;
using SIRentalMobil.Infrastructure.Database;
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
        private readonly AppDbContext _appDbContext;
        private readonly IPasswordHasher<User> _passwordHasher;

        public HomeController(
            ILogger<HomeController> logger,
            ISignInManager signInManager,
            AppDbContext appDbContext,
            IPasswordHasher<User> passwordHasher)
        {
            _logger = logger;
            _signInManager = signInManager;
            _appDbContext = appDbContext;
            _passwordHasher = passwordHasher;
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
            return View(new DaftarVM());
        }

        [HttpPost]
        public async Task<IActionResult> Daftar(DaftarVM vm)
        {
            if (!ModelState.IsValid) return View(vm);

            if(await _appDbContext.TblUser.AnyAsync(u => u.Email == vm.Email))
            {
                ModelState.AddModelError(nameof(DaftarVM.Email), $"Email '{vm.Email}' sudah digunakan");
                return View(vm);
            }

            if (await _appDbContext.TblUser.AnyAsync(u => u.NIK == vm.NIK))
            {
                ModelState.AddModelError(nameof(DaftarVM.NIK), $"NIK '{vm.NIK}' sudah digunakan");
                return View(vm);
            }

            var user = new User
            {
                Nama = vm.Nama,
                NIK = vm.NIK,
                Alamat = vm.Alamat,
                NoHP = vm.NoHP,
                Role = vm.Role,
                Email = vm.Email
            };

            user.PasswordHash = _passwordHasher.HashPassword(user, vm.Password);
            _appDbContext.TblUser.Add(user);
            await _appDbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Login));
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

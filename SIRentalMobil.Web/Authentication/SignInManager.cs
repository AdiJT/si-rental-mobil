using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SIRentalMobil.Domain.Commons;
using SIRentalMobil.Domain.Entities;
using SIRentalMobil.Infrastructure.Database;
using System.Security.Claims;

namespace SIRentalMobil.Web.Authentication;

public class SignInManager : ISignInManager
{
    private readonly IHttpContextAccessor _contextAccessor;
    private readonly IPasswordHasher<User> _passwordHasher;
    private readonly ILogger<ISignInManager> _logger;
    private readonly AppDbContext _appDbContext;

    public SignInManager(
        IHttpContextAccessor contextAccessor,
        IPasswordHasher<User> passwordHasher,
        ILogger<ISignInManager> logger,
        AppDbContext appDbContext)
    {
        _contextAccessor = contextAccessor;
        _passwordHasher = passwordHasher;
        _logger = logger;
        _appDbContext = appDbContext;
    }

    public async Task<User?> GetUser()
    {
        var httpContext = _contextAccessor.HttpContext;

        if(httpContext is null) return null;

        var email = httpContext.User.Identity?.Name;

        if(email is null ) return null;

        var user = await _appDbContext.TblUser.FirstOrDefaultAsync(u => u.Email == email);

        return user;
    }

    public async Task<Result> SignIn(string email, string password)
    {
        var httpContext = _contextAccessor.HttpContext;
        if (httpContext is null) return new Error("Login.Failed", "Login gagal");

        //Cek apakah akun ada
        var user = await _appDbContext.TblUser.FirstOrDefaultAsync(u => u.Email == email);
        if (user is null)
            return new Error("Login.UserNotFound", $"Account dengan email '{email}' tidak ditemukan");

        //Bandingkan password dengan password di database
        var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, password);
        if (result == PasswordVerificationResult.Failed)
            return new Error("Login.PasswordSalah", "Password yang dimasukkan salah!");

        //Buat claim
        var claims = new List<Claim>
        {
            new(ClaimTypes.Name, user.Email),
            new(ClaimTypes.Role, user.Role)
        };

        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

        //Sign In
        await httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);

        _logger.LogInformation("{@Email} logged in at {@Time} UTC", user.Email, DateTime.UtcNow);

        return Result.Success();
    }

    public async Task<Result> SignOut()
    {
        var httpContext = _contextAccessor.HttpContext;
        if (httpContext is null) return new Error("SignOut.Failed", "Log Out gagal");

        await httpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

        return Result.Success();
    }
}

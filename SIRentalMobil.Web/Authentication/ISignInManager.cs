using SIRentalMobil.Domain.Commons;
using SIRentalMobil.Domain.Entities;

namespace SIRentalMobil.Web.Authentication;

public interface ISignInManager
{
    Task<Result> SignIn(string email, string password);
    Task<Result> SignOut();
    Task<User?> GetUser();
}
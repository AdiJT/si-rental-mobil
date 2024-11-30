using System.ComponentModel.DataAnnotations;

namespace SIRentalMobil.Web.Models.HomeModels;

public class LoginVM
{
    [Display(Name = "Email")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Email { get; set; } = string.Empty;

    [Display(Name = "Password")]
    [Required(ErrorMessage = "{0} harus diisi")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;

    [Required(ErrorMessage = "{0} harus diisi")]
    public required string ReturnUrl { get; set; } = string.Empty;
}
using SIRentalMobil.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace SIRentalMobil.Web.Models.HomeModels;

public class DaftarVM
{
    [Display(Name = "NIK")]
    [Required(ErrorMessage = "{0} harus diisi")]
    [Length(16, 16, ErrorMessage = "Panjang {0} harus {1}")]
    [RegularExpression("^[0-9]{16}$")]
    public string NIK { get; set; } = string.Empty;

    [Display(Name = "Nama")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Nama { get; set; } = string.Empty;

    [Display(Name = "Nomor HP")]
    [Required(ErrorMessage = "{0} harus diisi")]
    [RegularExpression("^(08|\\+?62)\\d{10}$", ErrorMessage = "{0} tidak valid")]
    public string NoHP { get; set; } = string.Empty;

    [Display(Name = "Alamat")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Alamat { get; set; } = string.Empty;

    [Display(Name = "Role")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Role { get; set; } = string.Empty;

    [Display(Name = "Email")]
    [Required(ErrorMessage = "{0} harus diisi")]
    [RegularExpression("^[A-Za-z0-9]{3,}@[a-z]{3,}(.[a-z]{2,})+$", ErrorMessage = "{0} tidak valid")]
    public string Email { get; set; } = string.Empty;

    [Display(Name = "Password")]
    [Required(ErrorMessage = "{0} harus diisi")]
    [DataType(DataType.Password)]   
    public string Password { get; set; } = string.Empty;

    [Display(Name = "Konfirmasi Password")]
    [Required(ErrorMessage = "{0} harus diisi")]
    [Compare(nameof(Password), ErrorMessage = "{0} harus sama dengan {1}")]
    [DataType(DataType.Password)]
    public string PasswordConfirmation { get; set; } = string.Empty;
}

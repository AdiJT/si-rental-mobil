using System.ComponentModel.DataAnnotations;

namespace SIRentalMobil.Web.Models.PenyewaModels;

public class PembayaranVM
{
    [Required(ErrorMessage = "Harus ada")]
    public required int PesananId { get; set; }

    [Required(ErrorMessage = "Harus dipilih")]
    public int MetodePembayaranId { get; set; }
}
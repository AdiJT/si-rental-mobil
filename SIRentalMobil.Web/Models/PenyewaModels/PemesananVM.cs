using SIRentalMobil.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace SIRentalMobil.Web.Models.PenyewaModels;

public class PemesananVM
{
    [Required]
    public required int MobilId { get; set; }

    public required Mobil Mobil { get; set; }

    [Required]
    public required bool Sopir { get; set; }

    [Required]
    public required bool LuarKota { get; set; }

    [Display(Name = "Tanggal Mulai Sewa")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required DateOnly TanggalMulai { get; set; }

    [Display(Name = "Tanggal Akhir Sewa")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required DateOnly TanggalAkhir { get; set; }

    public required int JumlahHariSewa { get; set; }
}

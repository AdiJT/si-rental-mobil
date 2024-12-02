using SIRentalMobil.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace SIRentalMobil.Web.Models.MobilModels;

public class PencarianVM
{
    public required List<Mobil> DaftarMobil { get; set; }
    public required bool LuarKota { get; set; }
    public required bool Sopir { get; set; }

    [Required(ErrorMessage = "Harus diiisi")]
    public required DateOnly TanggalMulai { get; set; }

    [Required(ErrorMessage = "Harus diiisi")]
    public required DateOnly TanggalAkhir { get; set; }

    public required int JumlahHariSewa { get; set; }
}

using SIRentalMobil.Domain.Entities;

namespace SIRentalMobil.Web.Models.MobilModels;

public class PencarianVM
{
    public required List<Mobil> DaftarMobil { get; set; }
    public required bool LuarKota { get; set; }
    public required bool? Sopir { get; set; }
    public required DateOnly? TanggalMulai { get; set; }
    public required DateOnly? TanggalAkhir { get; set; }
    public required int JumlahHariSewa { get; set; }
}

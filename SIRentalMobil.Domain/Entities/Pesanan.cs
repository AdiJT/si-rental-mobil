using SIRentalMobil.Domain.Abstracts;
using SIRentalMobil.Domain.Enums;

namespace SIRentalMobil.Domain.Entities;

public class Pesanan : Entity
{
    public const double TarifLuarKota = 100_000d;
    public const double TarifSopir = 100_000d;
    public const double TarifAplikasi = 50_000d;

    public DateTime TanggalPesan { get; set; }
    public DateTime TanggalAwalSewa { get; set; }
    public DateTime TanggalAkhirSewa { get; set; }
    public bool Sopir { get; set; }
    public bool LuarKota { get; set; }
    public StatusPesanan Status { get; set; }

    public int JumlahHariSewa => (int)Math.Ceiling(TanggalAkhirSewa.Subtract(TanggalAwalSewa).TotalDays) + 1;
    public double TotalHarga => 
        (Mobil.Tarif + (LuarKota ? TarifLuarKota : 0)) * JumlahHariSewa + 
        (Sopir ? TarifSopir : 0) + 
        TarifAplikasi;

    public User Penyewa { get; set; }
    public Mobil Mobil { get; set; }
    public Pembayaran? Pembayaran { get; set; }
}
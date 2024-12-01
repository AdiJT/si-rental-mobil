using SIRentalMobil.Domain.Abstracts;
using SIRentalMobil.Domain.Enums;

namespace SIRentalMobil.Domain.Entities;

public class Pesanan : Entity
{
    public DateTime TanggalPesan { get; set; }
    public DateTime TanggalAwalSewa { get; set; }
    public DateTime TanggalAkhirSewa { get; set; }
    public bool Sopir { get; set; }
    public bool LuarKota { get; set; }
    public StatusPesanan Status { get; set; }

    public int JumlahHariSewa => (int)Math.Ceiling(TanggalAkhirSewa.Subtract(TanggalAwalSewa).TotalDays);
    public double TotalHarga => (Mobil.Tarif + (LuarKota ? 100 : 0)) * JumlahHariSewa + (Sopir ? 200 : 0);

    public User Penyewa { get; set; }
    public Mobil Mobil { get; set; }
    public Pembayaran? Pembayaran { get; set; }
}
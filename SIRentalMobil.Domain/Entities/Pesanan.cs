using SIRentalMobil.Domain.Abstracts;

namespace SIRentalMobil.Domain.Entities;

public class Pesanan : Entity
{
    public DateTime TanggalPesan { get; set; }
    public DateTime TanggalAwalSewa { get; set; }
    public DateTime TanggalAkhirSewa { get; set; }
    public bool Sopir { get; set; }
    public bool LuarKota { get; set; }
    public StatusPesanan Status { get; set; }

    public User Penyewa { get; set; }
    public Mobil Mobil { get; set; }
    public Pembayaran Pembayaran { get; set; }
}

public enum StatusPesanan
{
    BelumBayar, SudahBayar, Batal
}
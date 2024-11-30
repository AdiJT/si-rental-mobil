using SIRentalMobil.Domain.Abstracts;

namespace SIRentalMobil.Domain.Entities;

public class Pembayaran : Entity
{
    public DateTime TanggalBayar { get; set; }
    public int PesananId { get; set; }

    public MetodePembayaran MetodePembayaran { get; set; }
    public Pesanan Pesanan { get; set; }
}

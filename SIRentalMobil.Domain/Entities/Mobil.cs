using SIRentalMobil.Domain.Abstracts;
using SIRentalMobil.Domain.Enums;

namespace SIRentalMobil.Domain.Entities;

public class Mobil : Entity
{
    public string Nama { get; set; } = string.Empty;
    public Uri UrlGambar { get; set; }
    public double Tarif { get; set; }
    public int MaksPenumpang { get; set; }
    public StatusMobil Status { get; set; }
    public bool LuarKota { get; set; }
    public int MaksHariSewa { get; set; }
    public bool Sopir { get; set; }

    public User Pemilik { get; set; }
    public List<Pesanan> DaftarPesanan { get; set; } = [];
}
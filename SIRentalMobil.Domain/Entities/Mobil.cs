using SIRentalMobil.Domain.Abstracts;
using SIRentalMobil.Domain.Enums;

namespace SIRentalMobil.Domain.Entities;

public class Mobil : Entity
{
    public string Nama { get; set; } = string.Empty;
    public string Jenis { get; set; } = string.Empty;
    public int CC { get; set; }
    public int Tahun { get; set; }
    public string NomorPlat { get; set; } = string.Empty;
    public JenisTransmisi JenisTransmisi { get; set; }
    public JenisBensin JenisBensin { get; set; }
    public Uri UrlGambar { get; set; }
    public double Tarif { get; set; }
    public int MaksPenumpang { get; set; }
    public string Dekripsi { get; set; }
    public StatusMobil Status { get; set; }
    public int MaksHariSewa { get; set; }
    public bool LuarKota { get; set; }
    public bool Sopir { get; set; }

    public User Pemilik { get; set; }
    public List<Pesanan> DaftarPesanan { get; set; } = [];
}
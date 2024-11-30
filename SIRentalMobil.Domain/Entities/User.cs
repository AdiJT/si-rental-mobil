using SIRentalMobil.Domain.Abstracts;

namespace SIRentalMobil.Domain.Entities;

public class User : Entity
{
    public string NIK { get; set; } = string.Empty;
    public string Nama { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public string NoHP { get; set; } = string.Empty;
    public string Alamat { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;

    public List<Mobil> DaftarMobil { get; set; } = [];
    public List<Pesanan> DaftarPesanan { get; set; } = [];
}

public static class UserRoles
{
    public const string Pemilik = "Pemilik";
    public const string Penyewa = "Penyewa";
}

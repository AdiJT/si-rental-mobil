using SIRentalMobil.Domain.Abstracts;

namespace SIRentalMobil.Domain.Entities;

public class MetodePembayaran : Entity
{
    public string Nama { get; set; } = string.Empty;
}
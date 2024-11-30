using Microsoft.EntityFrameworkCore;
using SIRentalMobil.Domain.Entities;

namespace SIRentalMobil.Infrastructure.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {   
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);
        modelBuilder.SeedingData();
    }

    public DbSet<User> TblUser { get; set; }
    public DbSet<Mobil> TblMobil { get; set; }
    public DbSet<MetodePembayaran> TblMetodePembayaran { get; set; }
    public DbSet<Pesanan> TblPesanan { get; set; }
    public DbSet<Pembayaran> TblPembayaran { get; set; }
}

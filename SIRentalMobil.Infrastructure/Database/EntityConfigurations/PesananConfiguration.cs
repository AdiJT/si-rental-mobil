using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIRentalMobil.Domain.Entities;

namespace SIRentalMobil.Infrastructure.Database.EntityConfigurations;

internal class PesananConfiguration : IEntityTypeConfiguration<Pesanan>
{
    public void Configure(EntityTypeBuilder<Pesanan> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.TanggalPesan).HasColumnType("timestamp without time zone");
        builder.Property(p => p.TanggalAwalSewa).HasColumnType("timestamp without time zone");
        builder.Property(p => p.TanggalAkhirSewa).HasColumnType("timestamp without time zone");

        builder.HasOne(p => p.Penyewa).WithMany(p => p.DaftarPesanan);
        builder.HasOne(p => p.Mobil).WithMany(m => m.DaftarPesanan);
        builder.HasOne(p => p.Pembayaran).WithOne(p => p.Pesanan).HasForeignKey<Pembayaran>(p => p.PesananId);
    }
}

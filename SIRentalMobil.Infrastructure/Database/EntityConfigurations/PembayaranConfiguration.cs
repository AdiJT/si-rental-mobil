using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIRentalMobil.Domain.Entities;

namespace SIRentalMobil.Infrastructure.Database.EntityConfigurations;

internal class PembayaranConfiguration : IEntityTypeConfiguration<Pembayaran>
{
    public void Configure(EntityTypeBuilder<Pembayaran> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.TanggalBayar).HasColumnType("timestamp without time zone");

        builder.HasOne(x => x.MetodePembayaran).WithMany();
        builder.HasOne(x => x.Pesanan).WithOne(p => p.Pembayaran).HasForeignKey<Pembayaran>(x => x.PesananId);
    }
}

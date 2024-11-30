using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIRentalMobil.Domain.Entities;

namespace SIRentalMobil.Infrastructure.Database.EntityConfigurations;

internal class MobilConfiguration : IEntityTypeConfiguration<Mobil>
{
    public void Configure(EntityTypeBuilder<Mobil> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Pemilik).WithMany(u => u.DaftarMobil);
        builder.HasMany(x => x.DaftarPesanan).WithOne(p => p.Mobil);
    }
}

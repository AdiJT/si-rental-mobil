using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIRentalMobil.Domain.Entities;

namespace SIRentalMobil.Infrastructure.Database.EntityConfigurations;

internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasMany(x => x.DaftarMobil).WithOne(m => m.Pemilik);
        builder.HasMany(x => x.DaftarPesanan).WithOne(m => m.Penyewa);
    }
}

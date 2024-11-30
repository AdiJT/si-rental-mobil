using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIRentalMobil.Domain.Entities;

namespace SIRentalMobil.Infrastructure.Database.EntityConfigurations;

internal class MetodePembayaranConfiguration : IEntityTypeConfiguration<MetodePembayaran>
{
    public void Configure(EntityTypeBuilder<MetodePembayaran> builder)
    {
        builder.HasKey(m => m.Id);    
    }
}

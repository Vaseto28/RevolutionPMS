using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RevolutionPMS.Data.Models;

namespace RevolutionPMS.Data.EntitiesConfigurations;

public class PropertyTypeEntityConfiguration : IEntityTypeConfiguration<PropertyType>
{
    public void Configure(EntityTypeBuilder<PropertyType> builder)
    {
        builder
            .HasOne(x => x.AccommodationType)
            .WithMany(x => x.PropertyTypes)
            .HasForeignKey(x => x.AccommodationTypeId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}


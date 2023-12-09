using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RevolutionPMS.Data.Models;

namespace RevolutionPMS.Data.EntitiesConfigurations;

public class BillingTemplateEntityConfiguration : IEntityTypeConfiguration<BillingTemplate>
{
    public void Configure(EntityTypeBuilder<BillingTemplate> builder)
    {
        builder
            .Property(x => x.Price)
            .HasColumnType("decimal(18,2)");

        builder
            .Property(x => x.TaxPersentage)
            .HasColumnType("decimal(18,2)");
    }
}


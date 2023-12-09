using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RevolutionPMS.Data.Models;

namespace RevolutionPMS.Data.EntitiesConfigurations;

public class CurrencyEntityConfiguration : IEntityTypeConfiguration<Currency>
{
    public void Configure(EntityTypeBuilder<Currency> builder)
    {
        builder
            .Property(x => x.ExchangeRate)
            .HasColumnType("decimal(18,2)");
    }
}


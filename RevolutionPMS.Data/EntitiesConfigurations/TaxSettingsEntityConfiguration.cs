using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RevolutionPMS.Data.Models;

namespace RevolutionPMS.Data.EntitiesConfigurations
{
    public class TaxSettingsEntityConfiguration : IEntityTypeConfiguration<TaxSettings>
	{
        public void Configure(EntityTypeBuilder<TaxSettings> builder)
        {
            builder
                .HasOne(x => x.DefaultCurrency)
                .WithMany(x => x.TaxSettings)
                .HasForeignKey(x => x.CurrencyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(x => x.TaxPersentage)
                .HasColumnType("decimal(18,2)");
        }
    }
}


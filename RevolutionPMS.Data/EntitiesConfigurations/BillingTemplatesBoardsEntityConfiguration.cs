using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RevolutionPMS.Data.Models;

namespace RevolutionPMS.Data.EntitiesConfigurations;

public class BillingTemplatesBoardsEntityConfiguration : IEntityTypeConfiguration<BillingTemplatesBoards>
{
    public void Configure(EntityTypeBuilder<BillingTemplatesBoards> builder)
    {
        builder
            .HasOne(x => x.BillingTemplate)
            .WithMany(x => x.BillingTemplatesBoards)
            .HasForeignKey(x => x.BillingTemplateId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(x => x.Board)
            .WithMany(x => x.BillingTemplatesBoards)
            .HasForeignKey(x => x.BoardId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasKey(x => new { x.BillingTemplateId, x.BoardId});
    }
}


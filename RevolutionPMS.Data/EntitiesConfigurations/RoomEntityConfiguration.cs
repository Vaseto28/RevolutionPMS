using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RevolutionPMS.Data.Models;

namespace RevolutionPMS.Data.EntitiesConfigurations;

public class RoomEntityConfiguration : IEntityTypeConfiguration<Room>
{
    public void Configure(EntityTypeBuilder<Room> builder)
    {
        builder
            .HasOne(x => x.RoomType)
            .WithMany(x => x.Rooms)
            .HasForeignKey(x => x.RoomTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(x => x.Property)
            .WithMany(x => x.Rooms)
            .HasForeignKey(x => x.PropertyId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(x => x.Issue)
            .WithMany(x => x.Rooms)
            .HasForeignKey(x => x.IssueId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(x => x.HouseholdTask)
            .WithMany(x => x.Rooms)
            .HasForeignKey(x => x.HouseholdTaskId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}


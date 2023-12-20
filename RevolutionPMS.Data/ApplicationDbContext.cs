using System.Reflection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RevolutionPMS.Data.Models;

namespace RevolutionPMS.Data;

public class RevolutionPMSDbContext : IdentityDbContext
{
    public RevolutionPMSDbContext(DbContextOptions<RevolutionPMSDbContext> options)
        : base(options)
    {
    }

    public RevolutionPMSDbContext() : base()
    {
    }

    public DbSet<PropertyType> PropertyTypes { get; set; } = null!;

    public DbSet<Property> Properties { get; set; } = null!;

    public DbSet<RoomType> RoomTypes { get; set; } = null!;

    public DbSet<Room> Rooms { get; set; } = null!;

    public DbSet<Currency> Currencies { get; set; } = null!;

    public DbSet<TaxSettings> TaxSettings { get; set; } = null!;

    public DbSet<Board> Boards { get; set; } = null!;

    public DbSet<BillingTemplate> BillingTemplates { get; set; } = null!;

    public DbSet<Issue> Issues { get; set; } = null!;

    public DbSet<HouseholdTask> HouseholdTasks { get; set; } = null!;

    public DbSet<Company> Companies { get; set; } = null!;

    public DbSet<BillingTemplatesBoards> BillingTemplatesBoards { get; set; } = null!;

    public DbSet<AccommodationType> AccommodationTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder.UseLazyLoadingProxies());
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        Assembly assembly = Assembly.GetAssembly(typeof(RevolutionPMSDbContext)) ?? Assembly.GetExecutingAssembly();

        builder.ApplyConfigurationsFromAssembly(assembly);

        base.OnModelCreating(builder);
    }
}

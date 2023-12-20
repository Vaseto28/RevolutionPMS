using Microsoft.EntityFrameworkCore;
using RevolutionPMS.Data;
using RevolutionPMS.Data.Models;
using RevolutionPMS.Services.Contracts;
using RevolutionPMS.Web.ViewModels.SettingsModels;

namespace RevolutionPMS.Services;

public class SettingsService : ISettingsService
{
    private readonly RevolutionPMSDbContext dbCtx;

    public SettingsService(RevolutionPMSDbContext dbCtx)
    {
        this.dbCtx = dbCtx;
    }

    public async Task AddAccommodationTypeAsync(AccommodationTypeViewModel model)
    {
        AccommodationType accommodationType = new AccommodationType()
        {
            Name = model.Name
        };

        await this.dbCtx.AccommodationTypes.AddAsync(accommodationType);
        await this.dbCtx.SaveChangesAsync();
    }

    public async Task AddPropertyTypeAsync(PropertyTypeViewModel model)
    {
        PropertyType propertyType = new PropertyType()
        {
            Name = model.Name
        };

        await this.dbCtx.PropertyTypes.AddAsync(propertyType);
        await this.dbCtx.SaveChangesAsync();
    }

    public async Task<ICollection<AccommodationTypeViewModel>> GetAllAccommodationTypesAsync()
    {
        return await this.dbCtx.AccommodationTypes
            .Select(x => new AccommodationTypeViewModel()
            {
                Name = x.Name
            })
            .ToArrayAsync();
    }

    public async Task<ICollection<PropertyTypeViewModel>> GetAllPropertyTypesAsync()
    {
        return await this.dbCtx
            .PropertyTypes
            .Select(x => new PropertyTypeViewModel()
            {
                Name = x.Name
            })
            .ToArrayAsync();
    }
}


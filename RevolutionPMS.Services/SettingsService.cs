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

    public async Task AddPropertyTypeAsync(PropertyTypeViewModel model)
    {
        PropertyType propertyType = new PropertyType()
        {
            Name = model.Name
        };

        await this.dbCtx.PropertyTypes
            .AddAsync(propertyType);

        await this.dbCtx.SaveChangesAsync();
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


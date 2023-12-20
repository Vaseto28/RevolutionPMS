using RevolutionPMS.Web.ViewModels.SettingsModels;

namespace RevolutionPMS.Services.Contracts;

public interface ISettingsService
{
    Task<ICollection<PropertyTypeViewModel>> GetAllPropertyTypesAsync();

    Task AddPropertyTypeAsync(PropertyTypeViewModel model);

    Task AddAccommodationTypeAsync(AccommodationTypeViewModel model);

    Task<ICollection<AccommodationTypeViewModel>> GetAllAccommodationTypesAsync();
}


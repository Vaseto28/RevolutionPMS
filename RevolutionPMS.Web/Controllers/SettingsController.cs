using Microsoft.AspNetCore.Mvc;
using RevolutionPMS.Services.Contracts;
using RevolutionPMS.Web.ViewModels.SettingsModels;

namespace RevolutionPMS.Web.Controllers
{
    public class SettingsController : Controller
    {
        private readonly ISettingsService settingsService;

        public SettingsController(ISettingsService settingsService)
        {
            this.settingsService = settingsService;
        }

        public IActionResult Menu()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AccommodationTypes()
        {
            AccommodationTypeViewModel model = new AccommodationTypeViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AccommodationTypes(AccommodationTypeViewModel model)
        {
            if (string.IsNullOrWhiteSpace(model.Name))
            {
                return RedirectToAction("Error", "Home");
            }

            await this.settingsService.AddAccommodationTypeAsync(model);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> PropertyTypes()
        {
            PropertyTypeViewModel propertyTypeViewModel = new PropertyTypeViewModel()
            {
                PropertyTypes = await this.settingsService.GetAllPropertyTypesAsync(),
                AccommodationTypeViewModels = await this.settingsService.GetAllAccommodationTypesAsync()
            };

            return View(propertyTypeViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> PropertyTypes(PropertyTypeViewModel model)
        {
            if (string.IsNullOrWhiteSpace(model.Name))
            {
                return RedirectToAction("Error", "Home");
            }

            await this.settingsService.AddPropertyTypeAsync(model);

            return RedirectToAction("Index", "Home");
        }
    }
}


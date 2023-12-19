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
        public async Task<IActionResult> PropertyTypes()
        {
            PropertyTypeViewModel propertyTypeViewModel = new PropertyTypeViewModel()
            {
                PropertyTypes = await this.settingsService.GetAllPropertyTypesAsync()
            };

            return View(propertyTypeViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> PropertyTypes(PropertyTypeViewModel model)
        {
            await this.settingsService.AddPropertyTypeAsync(model);

            return RedirectToAction("Index", "Home");
        }
    }
}


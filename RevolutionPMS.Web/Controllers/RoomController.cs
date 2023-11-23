using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RevolutionPMS.Web.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Calendar()
        {
            return View();
        }
    }
}


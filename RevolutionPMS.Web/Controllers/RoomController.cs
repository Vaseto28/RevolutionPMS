using Microsoft.AspNetCore.Mvc;

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


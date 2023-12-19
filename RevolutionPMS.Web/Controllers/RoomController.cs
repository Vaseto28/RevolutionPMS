using Microsoft.AspNetCore.Mvc;

namespace RevolutionPMS.Web.Controllers
{
    public class RoomController : BaseController
    {
        public IActionResult Calendar()
        {
            return View();
        }
    }
}


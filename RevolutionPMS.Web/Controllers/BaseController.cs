using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RevolutionPMS.Web.Controllers;

[Authorize]
public class BaseController : Controller
{

}


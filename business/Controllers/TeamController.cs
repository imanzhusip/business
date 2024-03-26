using Microsoft.AspNetCore.Mvc;

namespace business.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

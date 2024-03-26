using Microsoft.AspNetCore.Mvc;

namespace business.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

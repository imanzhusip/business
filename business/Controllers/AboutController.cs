using Microsoft.AspNetCore.Mvc;

namespace business.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

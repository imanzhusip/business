using Microsoft.AspNetCore.Mvc;

namespace business.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace business.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

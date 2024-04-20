using Microsoft.AspNetCore.Mvc;

namespace Courses.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
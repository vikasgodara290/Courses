using Microsoft.AspNetCore.Mvc;

namespace Courses.Controllers
{
    public class ContentController : Controller
    {
        public IActionResult Content()
        {
            return View();
        }
    }
}

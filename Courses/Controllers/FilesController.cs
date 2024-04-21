using Microsoft.AspNetCore.Mvc;

namespace Courses.Controllers
{
    public class FilesController : Controller
    {
        [HttpGet]
        public IActionResult Files()
        {   
            return View();
        }
    }
}

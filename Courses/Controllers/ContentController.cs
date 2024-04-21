using Microsoft.AspNetCore.Mvc;

namespace Courses.Controllers
{
    public class ContentController : Controller
    {
        [HttpGet]
        public IActionResult Content(int CourseId)
        {
            ViewBag.CourseId = CourseId;    
            return View();
        }
    }
}

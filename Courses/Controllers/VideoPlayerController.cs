using Microsoft.AspNetCore.Mvc;

namespace Courses.Controllers
{
    public class VideoPlayerController : Controller
    {
        public IActionResult VideoPlayer()
        {
            return View();
        }
    }
}

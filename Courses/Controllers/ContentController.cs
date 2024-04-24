using Courses.Domain;
using Courses.Services;
using Microsoft.AspNetCore.Mvc;

namespace Courses.Controllers
{
    public class ContentController : Controller
    {
        private readonly IContentService _contentService;
        public ContentController(IContentService contentService)
        {
            _contentService = contentService;
        }

        [HttpGet]
        public IActionResult Content(int CourseId)
        {
            ViewBag.CourseId = CourseId; 
            List<CourseWiseContent> list = new List<CourseWiseContent>();
            list = _contentService.GetCourseWiseList(CourseId);
            return View(list);
        }
    }
}

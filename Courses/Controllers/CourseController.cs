using Courses.Domain;
using Courses.Services;
using Microsoft.AspNetCore.Mvc;

namespace Courses.Controllers
{
    public class CourseController : Controller
    {
        ICourseDetailsService _courseDetailsService;
        public CourseController(ICourseDetailsService courseDetailsService)
        {
            _courseDetailsService = courseDetailsService;
        }

        public IActionResult Course()
        {
            var list = _courseDetailsService.courseDetails(10);

            Course course = new Course();
            foreach (var item in list)
            {
                course.CourseId = item.CourseId;
                course.CourseName = item.CourseName;
                course.StartDate = item.StartDate;
                course.EndDate = item.EndDate;
                course.Description = item.Description;
            }
            return View(course);
        }
    }
}

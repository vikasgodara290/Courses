using Courses.Domain;
using Courses.Services;
using Microsoft.AspNetCore.Mvc;

namespace Courses.Controllers
{
    public class FilesController : Controller
    {
        private readonly IFileService _fileService;
        public FilesController(IFileService fileService)
        {
            _fileService = fileService;
        }
        [HttpGet]
        public IActionResult Files(int ContentId)
        {
            List<ContentWiseFiles> list = new List<ContentWiseFiles>();
            list = _fileService.GetContentWiseFiles(ContentId);
            return View(list);
        }
    }
}

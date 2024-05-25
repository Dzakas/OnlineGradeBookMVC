using Microsoft.AspNetCore.Mvc;
using OGB.Application.Interfaces;
using OGB.Application.Services;

namespace OnlineGradeBookMVC.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherService _teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TeachersList()
        {
            var model = _teacherService.GetAllTeachers(10, 1);
            return View(model);
        }
        [HttpGet]
        public IActionResult TeachersContactInformation()
        {
            var model = _teacherService.GetAllTeachersContactInfo(10, 1);
            return View(model);
        }
        [HttpGet]
        public IActionResult TeachersAddresses()
        {
            var model = _teacherService.GetAllTeachersAddress(10, 1);
            return View(model);
        }
    }
}

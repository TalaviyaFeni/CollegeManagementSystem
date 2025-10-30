using Microsoft.AspNetCore.Mvc;
using CollegeManagementSystem.Data;
using System.Linq;

namespace CollegeManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.StudentCount = _context.Students.Count();
            ViewBag.FacultyCount = _context.Faculties.Count();
            ViewBag.DepartmentCount = _context.Departments.Count();
            ViewBag.CourseCount = _context.Courses.Count();
            ViewBag.ResultCount = _context.Results.Count();
            return View("Index");
        }

        [HttpGet]
        public JsonResult GetDashboardData()
        {
            var data = new
            {
                studentCount = _context.Students.Count(),
                facultyCount = _context.Faculties.Count(),
                departmentCount = _context.Departments.Count(),
                courseCount = _context.Courses.Count(),
                resultCount = _context.Results.Count()
            };
            return Json(data);
        }
    }
}

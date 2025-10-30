
using Microsoft.AspNetCore.Mvc;
using CollegeManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Controllers
{
    public class AdminController : Controller
    {
        private readonly CollegeContext _context;

        public AdminController(CollegeContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.FacultyCount = await _context.Faculties.CountAsync();
            ViewBag.DepartmentCount = await _context.Departments.CountAsync();
            ViewBag.CourseCount = await _context.Courses.CountAsync();
            ViewBag.StudentCount = await _context.Students.CountAsync();

            var facultyList = await _context.Faculties.ToListAsync();
            return View(facultyList);
        }

        public async Task<IActionResult> Courses(int id)
        {
            var courses = await _context.Courses
                .Where(c => c.FacultyId == id)
                .ToListAsync();

            return View(courses);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using CollegeManagementSystem.Data;
using CollegeManagementSystem.Models;
using System.Linq;

namespace CollegeManagementSystem.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CoursesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // 👁️ List all courses
        public IActionResult Index()
        {
            var courses = _context.Courses.ToList();
            return View(courses);
        }

        // ✚ Add Course (GET)
        public IActionResult Create()
        {
            return View();
        }

        // ✚ Add Course (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Courses.Add(course);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }

        // ✏️ Edit Course (GET)
        public IActionResult Edit(int id)
        {
            var course = _context.Courses.Find(id);
            if (course == null)
                return NotFound();
            return View(course);
        }

        // ✏️ Edit Course (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Course course)
        {
            if (id != course.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(course);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }

        // 🗑️ Delete Course (GET)
        public IActionResult Delete(int id)
        {
            var course = _context.Courses.Find(id);
            if (course == null)
                return NotFound();
            return View(course);
        }

        // 🗑️ Delete Course (POST)
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var course = _context.Courses.Find(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        // 👁️ View Details
        public IActionResult Details(int id)
        {
            var course = _context.Courses.Find(id);
            if (course == null)
                return NotFound();
            return View(course);
        }
    }
}

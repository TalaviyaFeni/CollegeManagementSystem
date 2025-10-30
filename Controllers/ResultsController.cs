using Microsoft.AspNetCore.Mvc;
using CollegeManagementSystem.Data;
using CollegeManagementSystem.Models;

namespace CollegeManagementSystem.Controllers
{
    public class ResultsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResultsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // 🧾 List all results
        public IActionResult Index()
        {
            var results = _context.Results.ToList();
            return View(results);
        }

        // ➕ Add new result
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Result result)
        {
            if (ModelState.IsValid)
            {
                _context.Results.Add(result);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(result);
        }

        // ✏️ Edit result
        public IActionResult Edit(int id)
        {
            var result = _context.Results.Find(id);
            if (result == null) return NotFound();
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(Result result)
        {
            if (ModelState.IsValid)
            {
                _context.Results.Update(result);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(result);
        }

        // 👁️ View result details
        public IActionResult Details(int id)
        {
            var result = _context.Results.Find(id);
            if (result == null) return NotFound();
            return View(result);
        }

        // 🗑️ Delete result
        public IActionResult Delete(int id)
        {
            var result = _context.Results.Find(id);
            if (result == null) return NotFound();
            return View(result);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var result = _context.Results.Find(id);
            if (result != null)
            {
                _context.Results.Remove(result);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}

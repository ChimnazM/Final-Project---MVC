using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcFinalProject.Constants;
using MvcFinalProject.DAL;
using MvcFinalProject.Models;
using System.Threading.Tasks;

namespace MvcFinalProject.Areas.Dashboard.Controllers
{ [Area("Dashboard")]
    //[Authorize(Roles = RoleConstants.Admin)]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public async  Task<IActionResult> Index()
        {
            var categories = await _context.Categories.ToListAsync();
            return View(categories);
        }
        public async Task<IActionResult> Detail(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if(category == null) return NotFound();
            return View(category);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int id)
        {
            Category category = await _context.Categories.FindAsync(id);
            if (category == null) return NotFound();
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Category category)
        {
            bool isExist = await _context.Categories.AnyAsync(c => c.Id == id);
            if (!isExist) return NotFound();

            if (category == null) return NotFound();
            if (id != category.Id) return BadRequest();
            if (!ModelState.IsValid) return View();

            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<ActionResult> Delete(int id)
        {
            Category category = await _context.Categories.FindAsync(id);
            if (category == null) return NotFound();
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]

        public async Task<ActionResult> DeleteCategory(int id)
        {
            var cats = await _context.Categories.FindAsync(id);
            if (cats == null) return NotFound();
            _context.Categories.Remove(cats);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }






    }
}

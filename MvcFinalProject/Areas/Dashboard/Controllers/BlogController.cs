using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcFinalProject.Constants;
using MvcFinalProject.DAL;
using MvcFinalProject.Models;
using System.Threading.Tasks;

namespace MvcFinalProject.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    //[Authorize(Roles = RoleConstants.Admin)]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        //private readonly IWebHostEnvironment _env;

        public BlogController(AppDbContext context)
        {
            _context = context;

        }
        public async Task<IActionResult> Index()
        {
            var blogs = await _context.Blogs.ToListAsync();
            return View(blogs);
        }
        public async Task<IActionResult> Detail(int id)
        {
            var blog=await _context.Blogs.FindAsync(id);
            return View(blog);
        }
        public async Task<IActionResult> Update(int id)
        {
            Blog blog = await _context.Blogs.FindAsync(id);
            if (blog == null) return NotFound();
            return View(blog);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Blog blog)
        {
            bool isExist = await _context.Blogs.AnyAsync(c => c.Id == id);
            if (!isExist) return NotFound();

            if (blog == null) return NotFound();
            if (id != blog.Id) return BadRequest();
            if (!ModelState.IsValid) return View();

            _context.Blogs.Update(blog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            Blog blog = await _context.Blogs.FindAsync(id);
            if (blog == null) return NotFound();
            return View(blog);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            Blog blog = await _context.Blogs.FindAsync(id);
            _context.Blogs.Remove(blog);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}

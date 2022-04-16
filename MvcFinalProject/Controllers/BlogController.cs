using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcFinalProject.DAL;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public  async Task<IActionResult> Index()
        {
            var blogs = await _context.Blogs.Take(12).ToListAsync();

            return View(blogs);
        }
        public async Task<IActionResult> Details(int id)
        {
            var blog=await _context.Blogs.FirstOrDefaultAsync(b=>b.Id == id);
            return View(blog);
        }
    }
}

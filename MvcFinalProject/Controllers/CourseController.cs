using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcFinalProject.DAL;
using MvcFinalProject.ViewModels;
using System.Threading.Tasks;

namespace MvcFinalProject.Controllers
{
    public class CourseController : Controller
    {

        private readonly AppDbContext _context;

        public CourseController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var courses = await _context.Courses.ToListAsync();
            return View(courses);
        }
        public async Task<IActionResult> Detail(int id)
        {
            var course=await _context.Courses.FirstOrDefaultAsync(c=>c.Id==id);
            CourseVM courseVM = new CourseVM()
            {
                Course = course,
                Feature = await _context.Features.FirstOrDefaultAsync(f => f.Id == id)
            };
            return View(courseVM);
        }
    }
}

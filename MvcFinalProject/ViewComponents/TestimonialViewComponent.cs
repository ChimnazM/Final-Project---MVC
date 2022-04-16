using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcFinalProject.DAL;
using System.Threading.Tasks;

namespace MvcFinalProject.ViewComponents
{
    public class TestimonialViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public TestimonialViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var testimonial = await _context.Testimonials.ToListAsync();
            return View(testimonial);
        }
    }
}

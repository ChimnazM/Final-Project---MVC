using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcFinalProject.DAL;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.ViewComponents
{
    public class NoticeBoardViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public NoticeBoardViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Notices = await _context.Notices.OrderByDescending(n => n.Id).ToListAsync();
            return View(Notices);
        }
    }
}


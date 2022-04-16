using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcFinalProject.DAL;
using MvcFinalProject.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            AboutVM aboutVM = new AboutVM()
            {
                  Teachers=await _context.Teachers.Include(t=>t.Contact).Take(4).ToListAsync(),
                  Welcome=await _context.Welcomes.FirstOrDefaultAsync()

            };
           return View(aboutVM);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcFinalProject.DAL;
using MvcFinalProject.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Controllers
{
    public class EventController : Controller
    {

        private readonly AppDbContext _context;

        public EventController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var events = await _context.Events.ToListAsync();
            return View(events);
        }
        public async Task<IActionResult> Details(int id)
        {
            Event events = await _context.Events.Include(e=>e.EventSpeakers).ThenInclude(ec=>ec.Speaker).FirstOrDefaultAsync(e=>e.Id== id);
            return View(events);
        }
    }
}

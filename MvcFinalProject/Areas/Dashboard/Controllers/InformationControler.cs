using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using MvcFinalProject.DAL;
using MvcFinalProject.Models;
using System.Threading.Tasks;

namespace MvcFinalProject.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class InformationController : Controller
    {
        
        private readonly AppDbContext _context;

        public InformationController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var informations = await _context.Informations.ToListAsync();
            return View(informations);
        }
        public async Task<IActionResult> Detail(int id)
        {
            var information = await _context.Informations.FindAsync(id);
            if (information == null) return NotFound();
            return View(information);
        }
        public async Task<IActionResult> Update(int id)
        {
            var information = await _context.Informations.FindAsync(id);
            if (information == null) return NotFound();
            return View(information);
        }
        public async Task<IActionResult> Update(int id, Information information)
        {
            bool isExist = await _context.Informations.AnyAsync(i => i.Id == id);
            if (!isExist) return NotFound();

            if (information == null) return NotFound();
            if (id != information.Id) return BadRequest();
            //if (!ModelState.IsValid) return View();

            _context.Informations.Update(information);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<ActionResult> Delete(int id)
        {
            var i = await _context.Informations.FindAsync(id);
            if (i == null) return NotFound();
            return View(i);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]

        public async Task<ActionResult> DeleteInformation(int id)
        {
            var information = await _context.Informations.FindAsync(id);
            if (information == null) return NotFound();
            _context.Informations.Remove(information);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Information i)
        {
            if (!ModelState.IsValid) return View();

            await _context.Informations.AddAsync(i);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


    }
}

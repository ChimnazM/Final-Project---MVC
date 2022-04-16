using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcFinalProject.Constants;
using MvcFinalProject.DAL;
using MvcFinalProject.Extentions;
using MvcFinalProject.Models;
using MvcFinalProject.Utils;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MvcFinalProject.Areas.Dashboard.Controllers
{
    public class WelcomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public WelcomeController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<Welcome> w = await _context.Welcomes.ToListAsync();
            return View(w);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var w = await _context.Welcomes.FindAsync(id);
            if (w == null) return NotFound();
            return View(w);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Welcome w)
        {
            //if (!ModelState.IsValid) return View();

            if (!w.ImageFile.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Welcome.ImageFile), "File type is unsupported, please select image");
                return View();
            }
            if (w.ImageFile.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Welcome.ImageFile), "File size cannot be greater than 1 mb");
                return View();
            }

            w.Image = FileUtils.Create(FileConstants.ImagePathAbout, w.ImageFile);


            await _context.Welcomes.AddAsync(w);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var w = await _context.Welcomes.FindAsync(id);
            if (w == null) return NotFound();
            return View(w);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Welcome w)
        {
            //if (!ModelState.IsValid) return View();
            if (w.Id != id) return BadRequest();

            if (!w.ImageFile.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Welcome.ImageFile), "File type is unsupported, please select image");
                return View();
            }
            if (w.ImageFile.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Welcome.ImageFile), "File size cannot be greater than 1 mb");
                return View();
            }

            w.Image = FileUtils.Create(FileConstants.ImagePathAbout, w.ImageFile);


            bool isExist = await _context.Welcomes.AnyAsync(l => l.Id == id);
            if (!isExist) return NotFound();

            _context.Welcomes.Update(w);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var w = await _context.Welcomes.FindAsync(id);
            if (w == null) return NotFound();
            return View(w);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteWelcome(int id)
        {
            var w = await _context.Welcomes.FindAsync(id);
            FileUtils.Delete(Path.Combine(FileConstants.ImagePathAbout, w.Image));
            _context.Welcomes.Remove(w);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}

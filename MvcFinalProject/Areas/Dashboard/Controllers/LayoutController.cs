using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcFinalProject.Constants;
using MvcFinalProject.DAL;
using MvcFinalProject.Extentions;
using MvcFinalProject.Models;
using MvcFinalProject.Utils;
using System.Threading.Tasks;

namespace MvcFinalProject.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class LayoutController : Controller
    {
        private readonly AppDbContext _context;

        //private readonly IWebHostEnvironment _env;

        public LayoutController(AppDbContext context)
        {
            _context = context;

        }
        public async Task<IActionResult> Index()
        {
            var layouts = await _context.Layout.ToListAsync();
            return View(layouts);
        }
        public async Task<IActionResult> Detail(int id)
        {
            var layouts = await _context.Layout.FindAsync(id);
            if (layouts == null) return NotFound();
            return View(layouts);
        }
         public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Layout layout)
        {
            //if (!ModelState.IsValid) return View();

            if (!layout.NavImageFile.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Layout.NavImageFile), "File type is unsupported, please select image");
                return View();
            }
            if (layout.FooterImageFile.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Layout.FooterImageFile), "File size cannot be greater than 1 mb");
                return View();
            }

            layout.NavLogo = FileUtils.Create(FileConstants.ImagePathLogo, layout.NavImageFile);
            layout.FooterLogo = FileUtils.Create(FileConstants.ImagePathLogo, layout.FooterImageFile);


            await _context.Layout.AddAsync(layout);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            Layout layout = await _context.Layout.FindAsync(id);
            if (layout == null) return NotFound();
            return View(layout);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Layout layout)
        {
            if (!ModelState.IsValid) return View();
            if (layout.Id != id) return BadRequest();

            if (!layout.NavImageFile.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Layout.NavImageFile), "File type is unsupported, please select image");
                return View();
            }
            if (layout.NavImageFile.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Layout.NavImageFile), "File size cannot be greater than 1 mb");
                return View();
            }

            if (!layout.FooterImageFile.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Layout.FooterImageFile), "File type is unsupported, please select image");
                return View();
            }
            if (layout.FooterImageFile.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Layout.FooterImageFile), "File size cannot be greater than 1 mb");
                return View();
            }

            layout.NavLogo = FileUtils.Create(FileConstants.ImagePathLogo, layout.NavImageFile);
            layout.FooterLogo = FileUtils.Create(FileConstants.ImagePathLogo, layout.FooterImageFile);


            bool isExist = await _context.Layout.AnyAsync(l => l.Id == id);
            if (!isExist) return NotFound();

            _context.Layout.Update(layout);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            Layout layout = await _context.Layout.FindAsync(id);
            if (layout == null) return NotFound();
            return View(layout);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteLayout(int id)
        {
            Layout layout = await _context.Layout.FindAsync(id);
            _context.Layout.Remove(layout);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}

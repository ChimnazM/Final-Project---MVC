using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcFinalProject.Areas.Dashboard.ViewModels;
using MvcFinalProject.Constants;
using MvcFinalProject.DAL;
using MvcFinalProject.Extentions;
using MvcFinalProject.Models;
using MvcFinalProject.Utils;
using System.IO;
using System.Threading.Tasks;

namespace MvcFinalProject.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;

        //private readonly IWebHostEnvironment _env;

        public SliderController(AppDbContext context)
        {
            _context = context;

        }

        public async Task<IActionResult> Index()
        {
            var sliders = await _context.Sliders.ToListAsync();
            return View(sliders);
        }
        public async Task<IActionResult> Detail(int id)
        {
            var slider=await _context.Sliders.FindAsync(id);
            return View(slider);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
           
           

            if (!slider.ImageFile.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Slider.ImageFile), "File type is unsupported, please select image");
                return View();
            }
            if (slider.ImageFile.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Slider.ImageFile), "File size cannot be greater than 1 mb");
                return View();
            }

            slider.Image = FileUtils.Create(FileConstants.ImagePathSlider, slider.ImageFile);

            await _context.Sliders.AddAsync(slider);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<ActionResult> Delete(int id)
        {
            Slider slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]

        public async Task<ActionResult> DeleteSlider(int id)
        {
            var slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            FileUtils.Delete(Path.Combine(FileConstants.ImagePathSlider, slider.Image));
            _context.Sliders.Remove(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public ActionResult CreateMultiple()
        {
            return View();
        }
        public async Task<ActionResult> CreateMultiple(SliderMultiVM model)
        {
            if (!ModelState.IsValid) return View();

            foreach (var image in model.Images)
            {
                byte order = 1;

                if (!image.IsOkay())
                {
                    ModelState.AddModelError(nameof(Slider.ImageFile), $"There is problem in your image named {image.FileName}");
                    return View();
                }

                Slider slider = new Slider
                {
                    TopTitle = model.Title,
                    Description = model.Desc,
                    Image = FileUtils.Create(FileConstants.ImagePathSlider, image),
                    Order = order++,
                };

                await _context.Sliders.AddAsync(slider);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Index"); ;
        }

        public async Task<IActionResult> Update(int id)
        {
            Slider slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Slider slider)
        {
            if (!ModelState.IsValid) return View();
            if (slider.Id != id) return BadRequest();

            if (!slider.ImageFile.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Slider.ImageFile), "File type is unsupported, please select image");
                return View();
            }
            if (slider.ImageFile.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Slider.ImageFile), "File size cannot be greater than 1 mb");
                return View();
            }

            slider.Image = FileUtils.Create(FileConstants.ImagePathSlider, slider.ImageFile);

            bool isExist = await _context.Sliders.AnyAsync(l => l.Id == id);
            if (!isExist) return NotFound();

            _context.Sliders.Update(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        //    public async Task<IActionResult> Create(Slider slider)
        //    {
        //        if (!ModelState.IsValid) return View();

        //        if (!slider.ImageFile.IsOkay())
        //        {
        //            ModelState.AddModelError(nameof(Slider.ImageFile), "File type is unsupported, please select image");
        //            return View();
        //        }
        //        if (!slider.SignatureImageFile.IsOkay())
        //        {
        //            ModelState.AddModelError(nameof(Slider.SignatureImageFile), "File type is unsupported, please select image");
        //            return View();
        //        }




        //        #region uzunkod
        //        //string wwwRootPath = _env.WebRootPath;

        //        //// image starts
        //        //var folderPath = Path.Combine(wwwRootPath, "assets", "img");

        //        //FileStream stream = new FileStream(fullPath, FileMode.Create);
        //        //await slider.ImageFile.CopyToAsync(stream);
        //        //stream.Close();

        //        // signature starts
        //        //var fileNameSign = Guid.NewGuid() + slider.SignatureImageFile.FileName;
        //        //var fullPathSign = Path.Combine(wwwRootPath, "assets", "images", fileNameSign);

        //        //FileStream streamSign = new FileStream(fullPathSign, FileMode.Create);
        //        //await slider.SignatureImageFile.CopyToAsync(streamSign);
        //        //streamSign.Close();

        //        #endregion
        //        //var folderPath = Path.Combine(_env.WebRootPath, "assets", "images");

        //        slider.Image = FileUtils.Create(FileConstants.ImagePath, slider.ImageFile);
        //        slider.SignatureImage = FileUtils.Create(FileConstants.ImagePath, slider.SignatureImageFile);
        //        slider.RightIcon = "test";
        //        slider.LeftIcon = "test";

        //        await _context.Sliders.AddAsync(slider);
        //        await _context.SaveChangesAsync();

        //        return RedirectToAction(nameof(Index));
        //    }
        //    }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcFinalProject.Areas.ViewModels;
using MvcFinalProject.Constants;
using MvcFinalProject.DAL;
using MvcFinalProject.Extentions;
using MvcFinalProject.Models;
using MvcFinalProject.Utils;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;

        public TeacherController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var teachers = await _context.Teachers.ToListAsync();
            return View(teachers);
        }
        public async Task<IActionResult> Detail(int id)
        {
            var teacher = await _context.Teachers.Include(t=>t.Skill).Include(t=>t.Contact).FirstOrDefaultAsync(t=>t.Id==id);
            return View(teacher);
        }
        public async Task<IActionResult> Update(int id)
        {
            var teacher = await _context.Teachers.Include(t => t.Contact).Include(t => t.Skill).FirstOrDefaultAsync(f => f.Id == id);
            if (teacher == null) return NotFound();

            TeacherPostViewModel model = new TeacherPostViewModel
            {
                SkillIds = teacher.Skill.Select(c => c.Id).ToList(),
                Fullname = teacher.Fullname,
                Title = teacher.Title,
                Profession = teacher.Profession,
                Description = teacher.Description,
               
                Skills = await _context.Skills.ToListAsync(),
                Contact = await _context.Contacts.FirstOrDefaultAsync(),
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, TeacherPostViewModel model)
        {
            var teacher = await _context.Teachers.Include(t => t.Contact).Include(t => t.Skill).FirstOrDefaultAsync(f => f.Id == id);
            if (teacher == null) return NotFound();

            model.Skills = await _context.Skills.ToListAsync();
            model.Contact = await _context.Contacts.FirstOrDefaultAsync();

            //if (!ModelState.IsValid) return View(model);

            List<Skill> skills = new List<Skill>();
            foreach (var skillId in model.SkillIds)
            {
                var skill = await _context.Skills.FindAsync(skillId);
                if (skill == null)
                {
                    ModelState.AddModelError(nameof(TeacherPostViewModel.SkillIds), "Choose a valid skill");
                    return View(model);
                }
                skills.Add(new Skill { Id = skillId });
            }

            //if (model.Image != null)
            //{
            //    if (!model.ImageFile.IsOkay())
            //    {
            //        ModelState.AddModelError(nameof(TeacherPostVM.Image), "There is a problem in your file");
            //        return View(model);
            //    }

            //    FileUtils.Delete(Path.Combine(FileConstants.ImagePathTeacher, teacher.Image));
            //}

            if (!model.ImageFile.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Teacher.MainImage), "File type is unsupported, please select image");
                return View();
            }
            if (model.ImageFile.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Teacher.MainImage), "File size cannot be greater than 1 mb");
                return View();
            }

            model.MainImage = FileUtils.Create(FileConstants.ImagePathTeacher, model.ImageFile);
            model.DetailImage = FileUtils.Create(FileConstants.ImagePathTeacher, model.ImageFile);


            teacher.Title = model.Title;
            teacher.Profession = model.Profession;
            teacher.Description = model.Description;
            teacher.Contact = model.Contact;
            teacher.MainImage = model.MainImage != null ? FileUtils.Create(FileConstants.ImagePathTeacher, model.ImageFile) : teacher.MainImage;
            teacher.DetailImage = model.DetailImage != null ? FileUtils.Create(FileConstants.ImagePathTeacher, model.ImageFile) : teacher.DetailImage;
            _context.Teachers.Update(teacher);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Create()
        {
            TeacherPostViewModel model = new TeacherPostViewModel
            {
                Skills = await _context.Skills.ToListAsync()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeacherPostViewModel model)
        {
            model.Skills = await _context.Skills.ToListAsync();

            //if (!ModelState.IsValid) return View(model);

            List<Skill> skills = new List<Skill>();
            foreach (var skillId in model.SkillIds)
            {
                var skill = await _context.Skills.FindAsync(skillId);
                if (skill == null)
                {
                    ModelState.AddModelError(nameof(TeacherPostViewModel.SkillIds), "Choose a valid skill");
                    return View(model);
                }
                skills.Add(new Skill { Id = skillId });
            };

            if (!model.ImageFile.IsOkay())
            {
                ModelState.AddModelError(nameof(TeacherPostViewModel.ImageFile), "There is a problem in your file");
                return View(model);
            };


            Teacher teacher = new Teacher
            {
                Fullname = model.Fullname,
                Title = model.Title,
                Description = model.Description,
                Profession = model.Profession,
               
                Contact = model.Contact,
                MainImage = FileUtils.Create(FileConstants.ImagePathTeacher, model.ImageFile),
                DetailImage = FileUtils.Create(FileConstants.ImagePathTeacher, model.ImageFile),
                Skill = skills,

            };

            await _context.Teachers.AddAsync(teacher);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var teacher = await _context.Teachers.Include(x => x.Skill).Include(x=>x.Contact).FirstOrDefaultAsync(c => c.Id == id);

          
            return View(teacher);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteTeacher(int id)
        {
            var teacher = await _context.Teachers.Include(x => x.Skill).Include(s => s.Contact).FirstOrDefaultAsync(c => c.Id == id);

           
            if (teacher == null) return NotFound();


            FileUtils.Delete(Path.Combine(FileConstants.ImagePathTeacher, teacher.MainImage));
            FileUtils.Delete(Path.Combine(FileConstants.ImagePathTeacher, teacher.DetailImage));
            _context.Remove(teacher);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcFinalProject.DAL;
using MvcFinalProject.Models;
using MvcFinalProject.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;

        public TeacherController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var teachers = await _context.Teachers.Include(t => t.Contact).ToListAsync();

            return View(teachers);
        }
        public async Task<IActionResult> Detail(int id)
        {
            TeacherVM teacherVM = new TeacherVM()
            {

                Skils = await _context.Skills.Where(s => s.TeacherId == id).ToListAsync(),
                Contact = await _context.Contacts.FirstOrDefaultAsync(c=>c.TeacherId==id),
                Teacher = await _context.Teachers.FirstOrDefaultAsync(t => t.Id == id),


            };
           
            return View(teacherVM);
        }
    }
}

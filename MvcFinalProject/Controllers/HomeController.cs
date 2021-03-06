using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MvcFinalProject.DAL;
using MvcFinalProject.Models;
using MvcFinalProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM model = new HomeVM
            {
                Sliders = await _context.Sliders.OrderBy(s => s.Order).ToListAsync(),
                Informations = await _context.Informations.ToListAsync(),
                //Notices = await _context.Notices.OrderByDescending(n => n.Id).ToListAsync(),
                WhyUs = await _context.WhyUs.FirstOrDefaultAsync(),
                Courses = await _context.Courses.Take(3).ToListAsync(),
                Events = await _context.Events.Take(4).OrderByDescending(e => e.Id).ToListAsync(),
                Blogs = await _context.Blogs.Take(3).ToListAsync(),
            };
            return View(model);
        }


    }
}

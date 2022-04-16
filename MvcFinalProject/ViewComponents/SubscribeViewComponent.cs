using Microsoft.AspNetCore.Mvc;
using MvcFinalProject.DAL;
using System.Threading.Tasks;

namespace MvcFinalProject.ViewComponents
{
    public class SubscribeViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public SubscribeViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
           

            return View();
        }
    }
}

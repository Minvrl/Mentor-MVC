using Mentor_MVC.Data;
using Mentor_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mentor_MVC.Controllers
{
    public class PricingController : Controller
    {
        private AppDbContext _context;

        public PricingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            PricingViewModel vm = new PricingViewModel() 
            { 
                Prices =_context.Prices.Include(x => x.Features).ToList(),
                Features = _context.Features.ToList()
            };

            return View(vm);
        }
    }
}

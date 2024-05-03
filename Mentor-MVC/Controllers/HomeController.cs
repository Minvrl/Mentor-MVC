using Mentor_MVC.Data;
using Mentor_MVC.Models;
using Mentor_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Mentor_MVC.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context; 
        }
        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel()
            {
                Courses = _context.Courses.Include(x=> x.Trainer).ToList(),
                Trainers = _context.Trainers.ToList()
            };
            return View(vm);
        }

    }
}

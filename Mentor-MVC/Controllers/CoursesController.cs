using Mentor_MVC.Data;
using Mentor_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mentor_MVC.Controllers
{
    public class CoursesController:Controller
    {
        private AppDbContext _context;
        public CoursesController(AppDbContext context)
        {
             _context = context;    
        }
        public IActionResult Index()
        {
            List<Course> courses = _context.Courses.Include( x => x.Trainer).ToList();

            return View(courses);
        }
    }
}

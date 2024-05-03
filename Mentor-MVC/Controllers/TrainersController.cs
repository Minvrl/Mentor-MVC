using Mentor_MVC.Data;
using Mentor_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mentor_MVC.Controllers
{
    public class TrainersController:Controller
    {
        private AppDbContext _context;
        public TrainersController( AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Trainer> trainers = _context.Trainers.ToList();
            return View(trainers);  
        }
    }
}

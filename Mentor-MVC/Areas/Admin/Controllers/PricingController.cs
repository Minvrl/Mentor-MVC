using Humanizer.Localisation;
using Mentor_MVC.Data;
using Mentor_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mentor_MVC.Areas.Admin.Controllers
{
    [Area("admin")]
    public class PricingController : Controller
    {
        AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context=context;
        }
        public IActionResult Index()
        {
            var prices = _context.Prices.Include(x=> x.Features).ToList();
            return View(prices);
        }

        public IActionResult Create()
        {
            ViewBag.Features = _context.Features.ToList();
            return View();  
        }

        [HttpPost]
        public IActionResult Create(Price price)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Features = _context.Features.ToList();
                return View(price);
            }

            //foreach (var featureId in price.FeatureId)
            //{
            //    if (!_context.Features.Any(x => x.Id == featureId)) return RedirectToAction("notfound", "error");

            //    FeaturePrice featp = new FeaturePrice
            //    {
            //        FeatureId = featureId,
            //        Price = price
            //    };
            //    price.Features.Add(featp);
            //}


            _context.Prices.Add(price);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Edit(int id) 
        {
            var price = _context.Prices.Include(x => x.Features).FirstOrDefault(x=> x.Id == id);
            if (price == null) return RedirectToAction("Error", "NotFound");

            return View(price);
        }

        [HttpPost]
        public IActionResult Edit(Price price)
        {
            if (!ModelState.IsValid)
            {
                return View(price);
            }
            Price? existPrice = _context.Prices.Include(x => x.Features).FirstOrDefault(x => x.Id == price.Id);
            

            if (existPrice == null) return RedirectToAction("Error", "NotFound");

            existPrice.Name = price.Name;
            existPrice.ButtonURL = price.ButtonURL;
            existPrice.Fee = price.Fee;
            existPrice.IsAdvanced = price.IsAdvanced;   
            existPrice.IsFeatured = price.IsFeatured;   
            _context.SaveChanges();

            return RedirectToAction("index");

        }

        public IActionResult Delete(int id) 
        {
            var delPrice = _context.Prices.Find(id);
            if (delPrice == null) return NotFound();

            _context.Prices.Remove(delPrice);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}

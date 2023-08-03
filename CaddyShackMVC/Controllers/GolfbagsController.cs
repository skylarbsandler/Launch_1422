using Microsoft.AspNetCore.Mvc;
using CaddyShackMVC.Models;
using CaddyShackMVC.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace CaddyShackMVC.Controllers
{
    public class GolfbagsController : Controller
    {
        private readonly CaddyShackContext _context;

        public GolfbagsController(CaddyShackContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var golfbags = _context.GolfBags;
            return View(golfbags);
        }

        [Route("/Golfbags/{id:int}")]
        public IActionResult Show(int id)
        {
            var golfbags = _context.GolfBags.Find(id);
            return View(golfbags);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var golfbag = _context.GolfBags.Find(id);

            _context.GolfBags.Remove(golfbag);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        [Route("/Golfbags/")]
        public IActionResult Create(GolfBag golfbag)
        {

            _context.GolfBags.Add(golfbag);
            _context.SaveChanges();

            var newGolfbagId = golfbag.Id;

            return RedirectToAction("show", new { id = newGolfbagId });
        }

        //[Route("/Golfbags/{id:int}/edit")]
        //public IActionResult Edit(int id)
        //{
        //    var golfbag = _context.GolfBags.Find(id);

        //    return View(golfbag);
        //}
    }
}

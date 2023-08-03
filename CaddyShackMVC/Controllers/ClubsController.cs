using Microsoft.AspNetCore.Mvc;
using CaddyShackMVC.Models;
using CaddyShackMVC.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace CaddyShackMVC.Controllers
{
    public class ClubsController : Controller
    {
        private readonly CaddyShackContext _context;

        public ClubsController(CaddyShackContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/Golfbags/{golfbagId:int}/clubs")]
        public IActionResult Create(int golfbagId, Club club)
        {
            var golfbag = _context.GolfBags
                .Where(g => g.Id == golfbagId)
                .Include(g => g.Clubs)
                .First();

            golfbag.Clubs.Add(club);
            _context.SaveChanges();

            return RedirectToAction("show", new { golfbagId = golfbag.Id });
        }

        //[Route("/Golfbags/{id:int}/edit")]
        //public IActionResult Edit(int id)
        //{
        //    var golfbag = _context.GolfBags.Find(id);

        //    return View(golfbag);
        //}

        [Route("/Golfbags/{golfbagId:int}/edit")]
        public IActionResult New(int golfbagId)
        {
            var golfbag = _context.GolfBags
               .Where(g => g.Id == golfbagId)
               .Include(g => g.Clubs)
               .First();

            return View(golfbag);
        }
    }
}

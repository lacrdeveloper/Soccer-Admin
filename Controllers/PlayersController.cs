using System.Linq;
using soccerleague.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace soccerleague.Controllers
{
    public class PlayersController : Controller
    {
        MyDbContext db = new MyDbContext();
        public ActionResult Index()
        {
            return View(db.Players.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Players player)
        {
            if (ModelState.IsValid) { 
            
                db.Players.Add(player);
                db.SaveChanges();
                return RedirectToAction("Index", "Players");
            }
            else
            {
                return BadRequest(JsonConvert.SerializeObject(ModelState.Values.Select(e => e.Errors).ToList()));
            }

            //return View(player);
        }

        public ActionResult Update(int id)
        {
            return View(db.Players.Where(s => s.Id == id).First());
        }

        [HttpPost]
        public ActionResult Update(Players player)
        {
            if(ModelState.IsValid)
            {
                Players p = db.Players.Where(s => s.Id == player.Id).First();
                p.Firstname = player.Firstname;
                p.Lastname = player.Lastname;
                p.Birthday = player.Birthday;
                db.SaveChanges();
                return RedirectToAction("Index", "Players");
            }

            return View(player);
            
        }

        [HttpPost]
        public bool Delete(int id)
        {
            try
            {
                Players player = db.Players.Where(s => s.Id == id).First();
                db.Players.Remove(player);
                db.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }

        }

    }
}
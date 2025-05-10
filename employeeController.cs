using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class cinematicketController : Controller
    {
        cinematicketEntities db = new cinematicketEntities();

        // GET: cinematicket
        public ActionResult Index()
        {
            return View(db.movies1.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(movies movie)
        {
            if (ModelState.IsValid)
            {
                db.movies1.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            movies movie = db.movies1.Find(id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(movies movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            movies movie = db.movies1.Find(id);
            return View(movie);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            movies movie = db.movies1.Find(id);
            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult ConfirmedDelete(int id)
        {
            movies movie = db.movies1.Find(id);
            db.movies1.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HeroesAndVillians.Data;
using HeroesAndVillians.Models;

namespace HeroesAndVillians.Controllers
{
    public class CharactersController : Controller
    {
        //private variable that will be accessed through the controller methods
        private Context db = new Context();

        // GET: Characters that will return a list of characters
        public ActionResult Index()
        {
            return View(db.Character.ToList());
        }

       // GET: Characters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Characters/Create
        
        [HttpPost]//designates the  ActionResult Method as a post method
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Creator,CreationDate,Fav")] Characters characters)
        {
            if (ModelState.IsValid)
            {
                db.Character.Add(characters);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(characters);
        }

        // GET: Characters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Characters characters = db.Character.Find(id);
            if (characters == null)
            {
                return HttpNotFound();
            }
            return View(characters);
        }

        // POST: Characters/Edit/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Creator,CreationDate,Fav")] Characters characters)
        {
            if (ModelState.IsValid)
            {
                db.Entry(characters).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(characters);
        }

        // GET: Characters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Characters characters = db.Character.Find(id);
            if (characters == null)
            {
                return HttpNotFound();
            }
            return View(characters);
        }

        // POST: Characters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Characters characters = db.Character.Find(id);
            db.Character.Remove(characters);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //dispose of the controller when finished to prevent data leaks
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

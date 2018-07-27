using HeroesAndVillians.Data;
using HeroesAndVillians.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HeroesAndVillians.Controllers
{
    public class HomeController : Controller
    {
        //holds a reference to the context object instance
        private Context _context = new Context();


  

        // GET: Characters - returns a list of the characters
        public ActionResult Index()
        {

            CharactersViewModel character = new CharactersViewModel(_context.Character.ToList());

            return View(character);
        }

        public ActionResult Add()
        {
            
            return View();
        }


 
        [HttpPost]
        public ActionResult Add([Bind(Include = "Id, Name, Creator, CreationDate, Favorite")] Characters character)
        {
            if (ModelState.IsValid)
            {
                _context.Character.Add(character);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }

            return View(character);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var character = _context.Character.Find(id);
            if (character == null)
            {
                return HttpNotFound();

            }
            return View(character);

        }


        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Name, Creator, CreationDate, Favorite")] Characters character)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(character).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(character);

        }

        public ActionResult Delete(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var character = new Characters();
            if (character == null)
            {
                return HttpNotFound();
            }

            return View(character);

        }

        [HttpPost, ActionName("Delete")]
        public ActionResult ConfirmDelete(int? id)
        {
            var character = _context.Character.Find(id);
            _context.Character.Remove(character);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        //private field to track if the dispose method has already been called
        private bool _disposed = false;

        protected override void Dispose(bool disposing)
        {
            if (_disposed)
                return;
            if (disposing)
            {
                _context.Dispose();
            }

            _disposed = true;

            base.Dispose(disposing);
        }
    }
}
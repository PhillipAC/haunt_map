using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using haunt_map.Models;

namespace haunt_map.Controllers
{
    public class HauntController : Controller
    {
        private HauntDBContext db = new HauntDBContext();

        //
        // GET: /Haunt/

        public ActionResult Index()
        {
            return View(db.Haunts.ToList());
        }

        //
        // GET: /Haunt/Details/5

        public ActionResult Details(int id = 0)
        {
            Haunt haunt = db.Haunts.Find(id);
            if (haunt == null)
            {
                return HttpNotFound();
            }
            return View(haunt);
        }

        //
        // GET: /Haunt/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Haunt/Create

        [HttpPost]
        public ActionResult Create(Haunt haunt)
        {
            if (ModelState.IsValid)
            {
                db.Haunts.Add(haunt);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(haunt);
        }

        //
        // GET: /Haunt/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Haunt haunt = db.Haunts.Find(id);
            if (haunt == null)
            {
                return HttpNotFound();
            }
            return View(haunt);
        }

        //
        // POST: /Haunt/Edit/5

        [HttpPost]
        public ActionResult Edit(Haunt haunt)
        {
            if (ModelState.IsValid)
            {
                db.Entry(haunt).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(haunt);
        }

        //
        // GET: /Haunt/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Haunt haunt = db.Haunts.Find(id);
            if (haunt == null)
            {
                return HttpNotFound();
            }
            return View(haunt);
        }

        //
        // POST: /Haunt/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Haunt haunt = db.Haunts.Find(id);
            db.Haunts.Remove(haunt);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
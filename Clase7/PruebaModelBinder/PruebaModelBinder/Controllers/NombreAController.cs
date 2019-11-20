using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PruebaModelBinder.Models;

namespace PruebaModelBinder.Controllers
{
    public class NombreAController : Controller
    {
        private PruebaMBContext db = new PruebaMBContext();

        // GET: NombreA
        public ActionResult Index()
        {
            return View(db.nombres.ToList());
        }

        // GET: NombreA/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NombreA nombreA = db.nombres.Find(id);
            if (nombreA == null)
            {
                return HttpNotFound();
            }
            return View(nombreA);
        }

        // GET: NombreA/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NombreA/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nombre")] NombreA nombreA)
        {
            if (ModelState.IsValid)
            {
                db.nombres.Add(nombreA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nombreA);
        }

        // GET: NombreA/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NombreA nombreA = db.nombres.Find(id);
            if (nombreA == null)
            {
                return HttpNotFound();
            }
            return View(nombreA);
        }

        // POST: NombreA/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre")] NombreA nombreA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nombreA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nombreA);
        }

        // GET: NombreA/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NombreA nombreA = db.nombres.Find(id);
            if (nombreA == null)
            {
                return HttpNotFound();
            }
            return View(nombreA);
        }

        // POST: NombreA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NombreA nombreA = db.nombres.Find(id);
            db.nombres.Remove(nombreA);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

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

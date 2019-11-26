using AccentureAcademy.Clase11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccentureAcademy.Clase11.Controllers
{
    public class GeneroController : Controller
    {

        private TiendaDeMusica db;

        public GeneroController()
        {
            db = new TiendaDeMusica();
        }

        // GET: Genero
        public ActionResult Editar(int id)
        {
            Genero genero = db.Genero.Find(id);
            return View(genero);
        }

        [HttpPost]
        public ActionResult Editar(Genero genero)
        {
            if (this.ModelState.IsValid)
            {

                db.Genero.Attach(genero);
                db.Entry(genero).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                //return RedirectToAction("Listar");
                return Content("Genero editado");
            }

            return new HttpStatusCodeResult(505, "Error interno del servidor.");
        }

        public ActionResult EditarHTML5(int id)
        {
            Genero genero = db.Genero.Find(id);
            return View();
        }
    }
}
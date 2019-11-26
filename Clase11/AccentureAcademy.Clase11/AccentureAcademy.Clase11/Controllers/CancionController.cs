using AccentureAcademy.Clase11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccentureAcademy.Clase11.Controllers
{
    public class CancionController : Controller
    {
        private TiendaDeMusica db = new TiendaDeMusica();
        public ActionResult Editar(int id)
        {
            Cancion cancion = db.Cancion.Find(id);
            return View(cancion);
        }

        [HttpPost]
        public ActionResult Editar(Cancion cancion)
        {
            if (this.ModelState.IsValid)
            {

                db.Cancion.Attach(cancion);
                db.Entry(cancion).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                //return RedirectToAction("Listar");
                return Content("Cancion editada");
            }

            return new HttpStatusCodeResult(505, "Error interno del servidor.");
        }
    }
}
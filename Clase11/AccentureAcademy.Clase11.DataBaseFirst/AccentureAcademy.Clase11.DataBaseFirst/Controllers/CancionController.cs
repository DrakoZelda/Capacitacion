using AccentureAcademy.Clase11.DataBaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccentureAcademy.Clase11.DataBaseFirst.Controllers
{
    public class CancionController : Controller
    {
        private AcademyMusicStoreEntities db = new AcademyMusicStoreEntities();

        // GET: Cancion
        public ActionResult Editar(int id)
        {
            Cancion c = db.Cancion.Find(id);
            return View(c);
        }

        [HttpPost]
        public ActionResult Editar(Cancion c)
        {
            if (this.ModelState.IsValid)
            {
                db.Cancion.Attach(c);
                db.Entry(c).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                //return new ContentResult() { };

                return Content("La cancion se ha actualizado satisfactoriamente");
            }

            return new HttpStatusCodeResult(505, "Internal server Error, Hacker Detected");
        }
    }
}
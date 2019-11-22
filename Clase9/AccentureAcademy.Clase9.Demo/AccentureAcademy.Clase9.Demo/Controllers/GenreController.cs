using AccentureAcademy.Clase9.Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccentureAcademy.Clase9.Demo.Controllers
{
    public class GenreController : Controller
    {
        private AccentureAcademyBookStoreEntities db = new AccentureAcademyBookStoreEntities();

        public ActionResult Mostrar()
        {
            return View(db.Genre.ToList());
        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Crear(string title)
        {
            if(title == null || title.Length == 0)
            {
                return Content("No puedo insertar los datos, falta el titulo");
            }

            Genre nuevoGenero = new Genre();
            nuevoGenero.Title = title;

            db.Genre.Add(nuevoGenero);
            db.SaveChanges();

            return RedirectToAction("Mostrar");
        }
    }
}
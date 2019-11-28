using AccentureAcademy.Clase13.Dudas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccentureAcademy.Clase13.Dudas.Controllers
{
    public class LibroController : Controller
    {
        private AccentureAcademyBookStoreEntities db = new AccentureAcademyBookStoreEntities();

        public ActionResult Agregar()
        {
            Book libro = new Book();
            return View("Editar", libro);
        }

        [HttpPost]
        public ActionResult Agregar(Book book, int autores)
        {
            WrittenBy escritoPor = new WrittenBy();
            //escritorPor.Book = book
            escritoPor.Autor = db.Autor.Find(autores);
            book.WrittenBy.Add(escritoPor);

            db.Book.Add(book);
            db.SaveChanges();

            return Content("Libro creado satisfactoriamente.");
        }
        
        public ActionResult Editar(int id)
        {
            Book libro = db.Book.Find(id);
            return View(libro);
        }

        [HttpPost]
        public ActionResult Editar(Book libro)
        {
            db.Book.Attach(libro);
            db.Entry(libro).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return Content("Libro editado satisfactoriamente.");
        }
    }
}
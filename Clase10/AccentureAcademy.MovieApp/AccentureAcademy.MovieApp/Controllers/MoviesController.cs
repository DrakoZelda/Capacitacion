using AccentureAcademy.MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace AccentureAcademy.MovieApp.Controllers
{
    public class MoviesController : Controller
    {
        private AccentureAcademyMovieDbEntities db = new AccentureAcademyMovieDbEntities();

        // GET: Movies
        public ActionResult Listar()
        {
            List<Movie> movies = this.db.Movie.ToList();
            return View(movies);
        }

        public ActionResult ListarAsync()
        {
            //List<Movie> movies = db.Movie.ToList();
            //Thread.Sleep(5000);
            return View();
        }

        public ActionResult Editar(int id)
        {
            Movie m = this.db.Movie.Find(id);
            return View(m);
        }

        [HttpPost]
        public ActionResult Editar(Movie movie)
        {
            db.Movie.Attach(movie);
            db.Entry(movie).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Listar");
        }

        public ActionResult Agregar()
        {
            return View("Editar", new Movie());
        }

        [HttpPost]
        public ActionResult Agregar(Movie movie)
        {
            db.Movie.Add(movie);
            db.SaveChanges();
            return RedirectToAction("Listar");

        }

        public ActionResult JsonListar()
        {
            List<Movie> movies = db.Movie.ToList();
            return Json(movies);
        }

        public ActionResult Eliminar(int id)
        {
            Movie movie = db.Movie.Find(id);
            db.Movie.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Listar");
        }
    }
}
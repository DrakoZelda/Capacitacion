using AccentureAcademy.Clase12.Dudas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccentureAcademy.Clase12.Dudas.Controllers
{
    public class DudaController : Controller
    {
        // GET: Duda
        public ActionResult DropDownListFor()
        {
            List<String> nombres = new List<String>()
            {
                "juan",
                "pedro",
                "carlos",
                "sofia"
            };
            return View(nombres);
        }

        public ActionResult JavascriptPost(int id)
        {

            //recuperar un genero de la base de datos
            Genero g = new Genero() { Id = id, Nombre = "SCI" };
            return View(g);
        }

        [HttpPost]
        public ActionResult JavascriptPost(Genero genero)
        {
            //Actualiza la base de datos
            return Content("El genero se actualizo satisfactoriamente");
        }

        public ActionResult ListBinding()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ListBinding(IEnumerable<int> numeros)
        {
            return View();
        }
    }
}
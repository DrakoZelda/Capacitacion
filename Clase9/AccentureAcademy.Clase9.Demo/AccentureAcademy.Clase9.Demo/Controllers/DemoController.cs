using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccentureAcademy.Clase9.Demo.Controllers
{
    public class DemoController : Controller
    {
        public string SaludarSinV(string nombre)
        {
            return $"hola {nombre}";
        }

        public ViewResult SaludarConV(string nombre)
        {
            if (nombre.Trim().Length == 0 || nombre == null)
            {
                nombre = "[SIN NOMBRE]";
            }
            ViewBag.NombreParaMostrar = nombre;
            return View();
        }

        public ActionResult Sumar(int? a, int? b)
        {
            if(!a.HasValue)
            {
                a = 0;
            }

            if (!b.HasValue)
            {
                b = 0;
            }
            int suma = a.Value + b.Value;
            return View(suma);
        }

        public ActionResult SumarP(int a=0, int b = 0)
        {
            int suma = a + b;
            return View("Suma", suma);
        }
    }
}
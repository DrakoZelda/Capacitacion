using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccentureAcademy.MVC.Clase8.Controllers
{
    public class AccentureAcademyController : Controller
    {
        public string HelloWorld()
        {
            return "<html><body><h1>Hello World</h1></body></html>";
        }

        public string SaludarCompleto(string nombre, string apellido)
        {

            return (nombre + " " + apellido);
        }

        public int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
    }
}
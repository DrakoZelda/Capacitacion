using AccentureAcademy.Clase11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccentureAcademy.Clase11.Controllers
{
    public class DummyController : Controller
    {
        private TiendaDeMusica db;

        public DummyController()
        {
            db = new TiendaDeMusica();
        }
        public ActionResult GenerarDatosPrueba()
        {
            
            Genero folk = new Genero();
            folk.Nombre = "Folclore";

            Genero oldie = new Genero();
            oldie.Nombre = "Oldie";

            Genero indie = new Genero();
            indie.Nombre = "Indie";

            Cancion hastaLaRaiz = new Cancion();
            hastaLaRaiz.Titulo = "Hasta la Raiz";
            hastaLaRaiz.Compositor = "Natalia LaFourcade";
            hastaLaRaiz.SegundosDuracion = 190;
            hastaLaRaiz.Genero = folk;

            Cancion africa = new Cancion();
            africa.Titulo = "Africa";
            africa.Compositor = "Toto";
            africa.SegundosDuracion = 125;
            africa.Genero = oldie;

            Cancion forma = new Cancion();
            forma.Titulo = "La fiesta de la forma";
            forma.SegundosDuracion = 125;
            forma.Compositor = "Los reyes del falsete";
            forma.Genero = indie;

            db.Cancion.Add(hastaLaRaiz);
            db.Cancion.Add(africa);
            db.Cancion.Add(forma);

            db.SaveChanges();

            return Content("Datos Generados Satisfactoriamente");
        }
    }
}
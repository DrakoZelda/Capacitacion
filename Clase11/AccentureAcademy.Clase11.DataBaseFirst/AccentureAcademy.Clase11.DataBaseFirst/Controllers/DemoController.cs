using AccentureAcademy.Clase11.DataBaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccentureAcademy.Clase11.DataBaseFirst.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            Cancion c = new Cancion();
            c.MeGusta = true;
            return View();
        }
    }
}
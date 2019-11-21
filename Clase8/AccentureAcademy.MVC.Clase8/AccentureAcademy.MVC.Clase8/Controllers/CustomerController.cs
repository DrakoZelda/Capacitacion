using AccentureAcademy.MVC.Clase8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccentureAcademy.MVC.Clase8.Controllers
{
    public class CustomerController : Controller
    {
        private AccentureAcademyBankEntities db = new AccentureAcademyBankEntities();
        // GET: Customer
        public string EnrollCustomer(string name)
        {
            db.Customer.Add(new Customer()
            {
                Name = name
            });
            db.SaveChanges();

            return "Customer successfully enrolled";
        }

        public JsonResult GetCustomerList()
        {
            return Json(db.Customer.ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}
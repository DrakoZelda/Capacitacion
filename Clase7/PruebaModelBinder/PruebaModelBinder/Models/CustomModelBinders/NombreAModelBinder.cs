using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;
using IModelBinder = System.Web.Mvc.IModelBinder;
using ModelBindingContext = System.Web.Mvc.ModelBindingContext;

namespace PruebaModelBinder.Models.CustomModelBinders
{
    public class NombreAModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpRequestBase request = controllerContext.HttpContext.Request;

            int id = Convert.ToInt32(request.Form.Get("Id"));
            string first = request.Form.Get("FirstName");
            string middle = request.Form.Get("MiddleName");
            string last = request.Form.Get("LastName");

            return new NombreA()
            {
                Id = id,
                Nombre = string.Concat(first, " ", middle, " ", last)
            };
        }
    }
}
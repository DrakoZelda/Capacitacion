using System.Web;
using System.Web.Mvc;

namespace AccentureAcademy.Clase12.Dudas
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

using System.Web;
using System.Web.Mvc;

namespace AccentureAcademy.Clase11.DataBaseFirst
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

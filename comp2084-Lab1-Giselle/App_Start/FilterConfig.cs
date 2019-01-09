using System.Web;
using System.Web.Mvc;

namespace comp2084_Lab1_Giselle
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

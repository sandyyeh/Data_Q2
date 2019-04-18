using System.Web;
using System.Web.Mvc;

namespace Sandy_20190417_Data_Q2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

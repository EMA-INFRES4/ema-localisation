using ema_localisation.Controllers;
using System.Web;
using System.Web.Mvc;

namespace ema_localisation
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new TimerFilterAttribute());
        }
    }
}
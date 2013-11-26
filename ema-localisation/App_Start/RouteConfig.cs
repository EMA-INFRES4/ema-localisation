using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ema_localisation
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            ClassRoute cr = new ClassRoute("{lang}/{controller}/{action}", new MvcRouteHandler());
            routes.Add(cr);
            routes.MapRoute(
                "Home",                                              // Route name
                "{lang}/{controller}/{action}/{id}",                           // URL with parameters
                new { lang = "fr", controller = "Home", action = "Index", id = "" }  // Parameter defaults
            );
        }
    }
}
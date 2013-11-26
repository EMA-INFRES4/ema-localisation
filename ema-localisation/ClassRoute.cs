using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Routing;

namespace ema_localisation
{
    public class ClassRoute : Route
    {
        public ClassRoute(string url, IRouteHandler routeHandler) : base(url,routeHandler) {
            
        }
        
        public override RouteData GetRouteData(HttpContextBase httpContext)
        {
            var data = base.GetRouteData(httpContext);
            string lang = "en";
            if (data != null && data.Values.Values.Count > 0)
            {
                lang = data.Values.Values.ElementAt(0).ToString();
            }
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang); ;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(lang); ;
            return data;
        }
    }
}
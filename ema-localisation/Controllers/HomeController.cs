using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace ema_localisation.Controllers
{

    [TimerFilter]
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            Thread.Sleep(100);
            return View();
        }

    }
}

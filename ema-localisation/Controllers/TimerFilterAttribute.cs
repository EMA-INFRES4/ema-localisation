﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ema_localisation.Controllers
{
    public class TimerFilterAttribute : ActionFilterAttribute
    {
        public static DateTime t1;
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            t1 = DateTime.Now;
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.Controller.ViewBag.timeToAction = (DateTime.Now - t1).TotalMilliseconds;
        }
    }
}
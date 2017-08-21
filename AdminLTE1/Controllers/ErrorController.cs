using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLTE1.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult error403()
        {
            return View();
        }
        public ActionResult error404()
        {
            return View();
        }
    }
}
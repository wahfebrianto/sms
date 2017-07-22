using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace AdminLTE1.Controllers
{
    public class RFQController : Controller
    {
        // GET: RFQ
        public ActionResult Index()
        {
            //return Redirect(Request.UrlReferrer.ToString());
            return View();
        }
    }
}
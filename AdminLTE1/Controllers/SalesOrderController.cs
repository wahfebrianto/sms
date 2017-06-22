using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLTE1.Controllers
{
    public class SalesOrderController : Controller
    {
        // GET: SalesOrder
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Transaksi()
        {
            return View();
        }
    }
}
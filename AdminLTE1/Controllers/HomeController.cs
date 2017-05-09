using System.Web.Mvc;

namespace AdminLTE1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public ActionResult AnotherLink()
        {
            ViewBag.Title = "Home";
            return View("Index");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLTE1.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult move()
        {
            String Controller = Request.QueryString["controller"];
            String id = Request.QueryString["id"];
            Int64 projid = Convert.ToInt64(Request.QueryString["projid"]);
            String url = "";
            if (id != "0")
            {
                url += Url.Action("History", Controller);
                url += "?id=" + id;
            }
            else
            {
                url += Url.Action("Index", Controller);
            }
            Session["project"] = projid;
            return Redirect(url);
        }
    }
}
using AdminLTE1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLTE1.Controllers
{
    public class FindPricesController : Controller
    {
        // GET: FindPrices
        public ActionResult Index()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "find_price"))
            {
                TempData["back_url"] = Request.UrlReferrer.ToString();
                return Redirect(Url.Action("error403", "Error"));
            }
            using (var db = new dbsmsEntities())
            {
                if (Session["project"] != null && db.projects.Find(Session["project"]).status1.findprices == 1 && Request.QueryString["action"] == null)
                {
                    return View("History");
                }
                else if (Session["project"] != null)
                {
                    return View();
                }
                else
                {
                    return Redirect(Url.Action("index", "Home"));
                }
            }
        }

        public String save_all(string detail)
        {
            try
            {
                using (var db = new dbsmsEntities())
                {
                    Int64 projid = Convert.ToInt64(Session["project"]);
                    List<findprice> deleted = db.projects.Find(projid).findprices.ToList();
                    if(deleted.Count > 0)
                        db.findprices.RemoveRange(deleted);
                    db.SaveChanges();
                    String[] res = detail.Split('ѥ');
                    for (int i = 0; i < res.Length - 1; i++)
                    {
                        String[] result = res[i].Split('Ё');
                        findprice data = new findprice();
                        data.supplierid = Convert.ToInt64(result[0]);
                        data.address = "";
                        data.itemdescription = result[1];
                        data.qty = Convert.ToInt64(result[2]);
                        data.unitprice = Convert.ToInt64(result[3]);
                        data.timeneeded = Convert.ToInt64(result[4]);
                        data.description = result[5];
                        data.status = 1;
                        data.projectid = Convert.ToInt64(Session["project"]);
                        db.findprices.Add(data);
                    }
                    db.SaveChanges();
                    using (var db1 = new dbsmsEntities())
                    {
                        db1.findprices.Find(GlobalFunction.get_max_id("findprices")).project.status1.findprices = 1;
                        db1.SaveChanges();
                        return "success";
                    }
                }
            }
            catch (Exception e)
            {
                return "fail";
            }

        }
    }
}
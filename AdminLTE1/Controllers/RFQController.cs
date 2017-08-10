using AdminLTE1.Helpers;
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
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "rfq"))
            {
                TempData["back_url"] = Request.UrlReferrer.ToString();
                return Redirect(Url.Action("error403", "Error"));
            }
            //return Redirect(Request.UrlReferrer.ToString());
            using (var db = new dbsmsEntities())
            {
                if(Session["project"] != null && db.projects.Find(Session["project"]).status1.rfq == 1)
                {
                    return View("History");
                }
                else
                {
                    return View();
                }
            }
        }

        public String save_all(String date,long customerid,string to,string description, String projectName, string detail)
        {
            try
            {
                using (var db = new dbsmsEntities())
                {
                    status s = new status();
                    project p = new project();
                    p.status1 = s;
                    p.name = projectName;
                    p.status = 0;
                    p.description = "";
                    db.projects.Add(p);
                    db.SaveChanges();
                    Session["project"] = db.projects.Select(x => x.id).Max();
                }
                DateTime datenow = Convert.ToDateTime(date);
                using (var db = new dbsmsEntities())
                {
                    hrfq newdata = new hrfq();
                    newdata.date = datenow;
                    newdata.customerid = customerid;
                    newdata.to = to;
                    newdata.description = description;
                    newdata.projectid = Convert.ToInt64(Session["project"]);
                    db.hrfqs.Add(newdata);
                    String[] res = detail.Split('ѥ');
                    for(int i=0;i<res.Length-1;i++)
                    {
                        String[] result = res[i].Split('Ё');
                        drfq data = new drfq();
                        data.itemcategoryid = Convert.ToInt64(result[0]);
                        data.itemdescription = result[1];
                        data.qty = Convert.ToInt32(result[2]);
                        data.unitprice = Convert.ToInt32(result[3]);
                        data.subtotal = data.qty * data.unitprice;
                        db.drfqs.Add(data);
                    }
                    db.SaveChanges();
                    using (var db1 = new dbsmsEntities())
                    {
                        db1.hrfqs.Find(GlobalFunction.get_max_id("hrfq")).project.status1.rfq = 1;
                        db1.hrfqs.Find(GlobalFunction.get_max_id("hrfq")).project.customerid = customerid;
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
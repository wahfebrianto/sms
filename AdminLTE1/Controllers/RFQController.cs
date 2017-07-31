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

        public ActionResult new_project(String projectName)
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
            return Redirect(Url.Action("Index", "RFQ"));
        }

        public String save_all(String date,long customerid,string to,string description,long projectid,string detail)
        {
            try
            {
                DateTime datenow = Convert.ToDateTime(date);
                using (var db = new dbsmsEntities())
                {
                    hrfq newdata = new hrfq();
                    newdata.date = datenow;
                    newdata.customerid = customerid;
                    newdata.to = to;
                    newdata.description = description;
                    newdata.projectid = projectid;
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
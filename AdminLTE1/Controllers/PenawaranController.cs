using AdminLTE1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLTE1.Controllers
{
    public class PenawaranController : Controller
    {
        // GET: Penawaran
        public ActionResult Index()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "penawaran"))
            {
                TempData["back_url"] = Request.UrlReferrer.ToString();
                return Redirect(Url.Action("error403", "Error"));
            }
            using (var db = new dbsmsEntities())
            {
                if (Session["project"] != null && db.projects.Find(Session["project"]).status1.penawaran == 1)
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

        public String save_all(String quotedate, String quoteto, Int64 projectid,String desc, Int64 total, Int64 disc, Int64 grandtotal,String detail)
        {
            try
            {
                DateTime datenow = Convert.ToDateTime(quotedate);
                using (var db = new dbsmsEntities())
                {
                    hpenawaran newdata = new hpenawaran();
                    newdata.date = datenow;
                    newdata.projectid = projectid;
                    newdata.number = GlobalFunction.generate_code("PNW");
                    newdata.customerid = db.projects.Find(projectid).customer.id;
                    newdata.to = quoteto;
                    newdata.description = desc;
                    newdata.disc = disc;
                    newdata.total = total;
                    newdata.grandtotal = grandtotal;
                    db.hpenawarans.Add(newdata);
                    String[] res = detail.Split('ѥ');
                    for (int i = 0; i < res.Length - 1; i++)
                    {
                        String[] result = res[i].Split('Ё');
                        dpenawaran data = new dpenawaran();
                        //itemcatid+"Ё"+itemdescription+"Ё"+suppid+"Ё"+qty+"Ё"+unitprice+"Ё"+subtotal
                        data.itemcategoryid = Convert.ToInt64(result[0]);
                        data.itemdescription = result[1];
                        data.supplierid = Convert.ToInt32(result[2]);
                        data.qty = Convert.ToInt32(result[3]);
                        data.unitprice = Convert.ToInt32(result[4]);
                        data.subtotal = data.qty * data.unitprice;
                        //data.penawaranid = GlobalFunction.get_max_id("hpenawaran");
                        db.dpenawarans.Add(data);
                    }
                    db.SaveChanges();
                    using (var db1 = new dbsmsEntities())
                    {
                        db1.hpenawarans.Find(GlobalFunction.get_max_id("hpenawaran")).project.status1.penawaran = 1;
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
using AdminLTE1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLTE1.Controllers
{
    public class SalesInvoiceController : Controller
    {
        // GET: SalesInvoice
        public ActionResult Index()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "sales_invoice"))
            {
                TempData["back_url"] = Request.UrlReferrer.ToString();
                return Redirect(Url.Action("error403", "Error"));
            }
            return View();
        }
        public ActionResult Transaksi()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "sales_invoice"))
            {
                TempData["back_url"] = Request.UrlReferrer.ToString();
                return Redirect(Url.Action("error403", "Error"));
            }
            return View();
        }
        public ActionResult History()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "sales_invoice"))
            {
                TempData["back_url"] = Request.UrlReferrer.ToString();
                return Redirect(Url.Action("error403", "Error"));
            }
            return View();
        }
        public String delete_it(Int64 id)
        {
            try
            {
                using (var db = new dbsmsEntities())
                {

                    hsalesinvoice data = db.hsalesinvoices.Find(id);
                    List<dsalesinvoice> ddata = data.dsalesinvoices.ToList();
                    db.dsalesinvoices.RemoveRange(ddata);
                    db.hsalesinvoices.Remove(data);
                    db.SaveChanges();
                    return "success";
                }
            }
            catch
            {
                return "fail";
            }
        }
        //sidate: sidate, terms:terms, disc:disc, desc: desc, detail: detail
        public String save_it(String sidate,String terms, Int64 disc, String desc, String detail)
        {
            try
            {
                DateTime datenow = Convert.ToDateTime(sidate);
                using (var db = new dbsmsEntities())
                {
                    hsalesinvoice newdata = new hsalesinvoice();
                    newdata.date = datenow;
                    newdata.description = desc;
                    newdata.terms = terms;
                    newdata.projectid = Convert.ToInt64(Session["project"]);
                    newdata.customerid = db.projects.Find(Convert.ToInt64(Session["project"])).hsalesorders.First().customerid;
                    newdata.number = GlobalFunction.generate_code("INV");
                    db.hsalesinvoices.Add(newdata);
                    Int64 total = 0;
                    String[] res = detail.Split('ѥ');
                    for (int i = 0; i < res.Length - 1; i++)
                    {
                        String[] result = res[i].Split('Ё');
                        dsalesinvoice data = new dsalesinvoice();
                        //detail += itemcatid + "Ё" + itemdescription + "Ё" + qty + "Ё" + unitprice;
                        data.itemcategoryid = Convert.ToInt64(result[0]);
                        data.itemdescription = result[1];
                        data.qty = Convert.ToInt32(result[2]);
                        data.unitprice = Convert.ToInt32(result[3]);
                        data.subtotal = data.qty * data.unitprice;
                        total += data.subtotal;
                        //data.penawaranid = GlobalFunction.get_max_id("hpenawaran");
                        db.dsalesinvoices.Add(data);
                    }
                    total -= db.projects.Find(Convert.ToInt64(Session["project"])).hsalesorders.First().dp;
                    newdata.total = total;
                    newdata.diskon = disc;
                    newdata.grandtotal = newdata.total - newdata.diskon;
                    db.SaveChanges();
                    using (var db1 = new dbsmsEntities())
                    {
                        db1.projects.Find(Convert.ToInt64(Session["project"])).status1.salesinvoice = 1;
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
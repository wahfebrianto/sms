using AdminLTE1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLTE1.Controllers
{
    public class PurchaseInvoiceController : Controller
    {
        // GET: PurchaseInvoice
        public ActionResult Index()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "purchase_invoice"))
            {
                TempData["back_url"] = Request.UrlReferrer.ToString();
                return Redirect(Url.Action("error403", "Error"));
            }
            return View();
        }

        public ActionResult Transaksi()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "purchase_invoice"))
            {
                TempData["back_url"] = Request.UrlReferrer.ToString();
                return Redirect(Url.Action("error403", "Error"));
            }
            return View();
        }
        public ActionResult History()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "purchase_invoice"))
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

                    hpurchaseinvoice data = db.hpurchaseinvoices.Find(id);
                    List<dpurchaseinvoice> ddata = data.dpurchaseinvoices.ToList();
                    db.dpurchaseinvoices.RemoveRange(ddata);
                    db.hpurchaseinvoices.Remove(data);
                    db.SaveChanges();
                    return "success";
                }
            }
            catch
            {
                return "fail";
            }
        }

        //data: { pino: pino, pidate: pidate, poid: poid, desc: desc, detail: detail, disc:disc },
        public String save_it(String pino, String pidate, Int64 poid, Int64 disc, String desc, String detail)
        {
            try
            {
                DateTime datenow = Convert.ToDateTime(pidate);
                using (var db = new dbsmsEntities())
                {
                    hpurchaseinvoice newdata = new hpurchaseinvoice();
                    newdata.date = datenow;
                    newdata.description = desc;
                    newdata.poid = poid;
                    newdata.supplierid = db.hpoes.Find(poid).supplierid;
                    newdata.projectid = Convert.ToInt64(Session["project"]);
                    newdata.terms = "C.O.D";
                    newdata.number = pino;
                    db.hpurchaseinvoices.Add(newdata);
                    Int64 total = 0;
                    String[] res = detail.Split('ѥ');
                    for (int i = 0; i < res.Length - 1; i++)
                    {
                        String[] result = res[i].Split('Ё');
                        dpurchaseinvoice data = new dpurchaseinvoice();
                        //detail += itemcatid + "Ё" + itemdescription + "Ё" + qty + "Ё" + unitprice;
                        data.itemcategoryid = Convert.ToInt64(result[0]);
                        data.itemdescription = result[1];
                        data.qty = Convert.ToInt32(result[2]);
                        data.unitprice = Convert.ToInt32(result[3]);
                        data.subtotal = data.qty * data.unitprice;
                        total += data.subtotal;
                        //data.penawaranid = GlobalFunction.get_max_id("hpenawaran");
                        db.dpurchaseinvoices.Add(data);
                    }
                    total -= db.hpoes.Find(poid).dp;
                    newdata.total = total;
                    newdata.diskon = disc;
                    newdata.grandtotal = newdata.total - newdata.diskon;
                    db.SaveChanges();
                    using (var db1 = new dbsmsEntities())
                    {
                        db1.projects.Find(Convert.ToInt64(Session["project"])).status1.purchaseinvoice = 1;
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
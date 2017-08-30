using AdminLTE1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLTE1.Controllers
{
    public class PurchaseOrderController : Controller
    {
        // GET: PurchaseOrder
        public ActionResult Index()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "purchase_order"))
            {
                TempData["back_url"] = Request.UrlReferrer.ToString();
                return Redirect(Url.Action("error403", "Error"));
            }
            return View();
        }
        public ActionResult Transaksi()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "purchase_order"))
            {
                TempData["back_url"] = Request.UrlReferrer.ToString();
                return Redirect(Url.Action("error403", "Error"));
            }
            using (var db = new dbsmsEntities())
            {
                Int64 id = Convert.ToInt64(Request.QueryString["id"]);
                Byte status = db.hpoes.Find(id).status;
                if (status == 1 && Request.QueryString["action"]=="null") return Redirect(Url.Action("History", "PurchaseOrder") + "?id=" + id);
            }
            return View();
        }
        public ActionResult History()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "purchase_order"))
            {
                TempData["back_url"] = Request.UrlReferrer.ToString();
                return Redirect(Url.Action("error403", "Error"));
            }
            using (var db = new dbsmsEntities())
            {
                Int64 id = Convert.ToInt64(Request.QueryString["id"]);
                Byte status = db.hpoes.Find(id).status;
                if (status == 0) return Redirect(Url.Action("Transaksi", "PurchaseOrder") + "?id=" + id);
            }
            return View();
        }
        public String save_it(String podate, Int64 poid, String expecteddate, String shipto, String terms, Int64 projectid, String desc, Int64 dp, Int64 discount, Int64 remainingpayment, String detail, Boolean edit = false)
        {
            try
            {
                DateTime datenow = Convert.ToDateTime(podate);
                DateTime datenow1 = Convert.ToDateTime(expecteddate);
                using (var db = new dbsmsEntities())
                {
                    hpo newdata = db.hpoes.Find(poid);
                    newdata.date = datenow;
                    newdata.expecteddate = datenow1;
                    newdata.terms = terms;
                    newdata.description = desc;
                    newdata.dp = dp;
                    newdata.discount = discount;
                    newdata.grandtotal = remainingpayment;
                    newdata.to = shipto;
                    newdata.status = 1;
                    db.SaveChanges();
                    if (dp > 0 && !edit)
                    {
                        using (var db1 = new dbsmsEntities())
                        {
                            hpurchaseinvoice newdata1 = new hpurchaseinvoice();
                            newdata1.date = datenow;
                            newdata1.number = GlobalFunction.generate_code("DP");
                            newdata1.projectid = projectid;
                            newdata1.terms = terms;
                            newdata1.supplierid = newdata.supplierid;
                            newdata1.description = "Down payment untuk PO : " + newdata.number;
                            newdata1.total = dp;
                            newdata1.grandtotal = dp;
                            newdata1.poid = poid;
                            newdata1.diskon = 0;
                            db1.hpurchaseinvoices.Add(newdata1);
                            dpurchaseinvoice newdata2 = new dpurchaseinvoice();
                            newdata2.itemcategoryid = 2;
                            newdata2.itemdescription = "Down Payment";
                            newdata2.qty = 1;
                            newdata2.unitprice = dp;
                            newdata2.subtotal = dp;
                            db1.dpurchaseinvoices.Add(newdata2);
                            db1.hpoes.Find(poid).project.status1.purchaseinvoice = 1;
                            db1.SaveChanges();
                        }
                    }
                    using (var db1 = new dbsmsEntities())
                    {
                        //purchasepayment pp = new purchasepayment();
                        //pp.projectid = projectid;
                        //pp.purchaseinvoiceid = GlobalFunction.get_max_id("hpurchaseinvoice");
                        //pp.number = db1.hpurchaseinvoices.Find(GlobalFunction.get_max_id("hpurchaseinvoice")).number;
                        //pp.date = datenow;
                        //pp.supplierid = newdata.supplierid;
                        //pp.total = dp;
                        //pp.description = "Pembayaran DP untuk PO : " + newdata.number;
                        //pp.type = terms;
                        //pp.note = "";
                        //db1.purchasepayments.Add(pp);
                        db1.hpoes.Find(poid).project.status1.purchaseorder = 1;
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
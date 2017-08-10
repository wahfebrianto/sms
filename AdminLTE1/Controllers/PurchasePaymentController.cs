using AdminLTE1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLTE1.Controllers
{
    public class PurchasePaymentController : Controller
    {
        // GET: PurchasePayment
        public ActionResult Index()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "purchase_payment"))
            {
                TempData["back_url"] = Request.UrlReferrer.ToString();
                return Redirect(Url.Action("error403", "Error"));
            }
            return View();
        }

        public ActionResult History()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "purchase_payment"))
            {
                TempData["back_url"] = Request.UrlReferrer.ToString();
                return Redirect(Url.Action("error403", "Error"));
            }
            return View();
        }

        //data: { pdate: pdate, ptype: ptype, pnote: pnote, pinvid: pinvid},
        public String save_it(String pdate, String ptype, Int64 pinvid, String pnote)
        {
            try
            {
                DateTime datenow = Convert.ToDateTime(pdate);
                using (var db = new dbsmsEntities())
                {
                    purchasepayment newdata = new purchasepayment();
                    newdata.date = datenow;
                    newdata.description = "";
                    newdata.purchaseinvoiceid = pinvid;
                    newdata.supplierid = db.hpurchaseinvoices.Find(pinvid).supplierid;
                    newdata.projectid = Convert.ToInt64(Session["project"]);
                    newdata.type = ptype;
                    newdata.note = pnote;
                    newdata.total = db.hpurchaseinvoices.Find(pinvid).grandtotal;
                    newdata.number = db.hpurchaseinvoices.Find(pinvid).number;
                    db.hpurchaseinvoices.Find(pinvid).status = 1;
                    db.purchasepayments.Add(newdata);
                    db.projects.Find(Convert.ToInt64(Session["project"])).status1.purchasepayment = 1;
                    db.SaveChanges();
                    return "success";
                }
            }
            catch (Exception e)
            {
                return "fail";
            }

        }
    }
}
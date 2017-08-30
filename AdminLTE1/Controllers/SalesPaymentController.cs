using AdminLTE1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLTE1.Controllers
{
    public class SalesPaymentController : Controller
    {
        // GET: SalesPayment
        public ActionResult Index()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "sales_payment"))
            {
                TempData["back_url"] = Request.UrlReferrer.ToString();
                return Redirect(Url.Action("error403", "Error"));
            }
            return View();
        }
        public ActionResult History()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "sales_payment"))
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

                    salespayment data = db.salespayments.Find(id);
                    data.hsalesinvoice.status = 0;
                    db.salespayments.Remove(data);
                    db.SaveChanges();
                    return "success";
                }
            }
            catch
            {
                return "fail";
            }
        }

        //data: { pdate: pdate, ptype: ptype, pnote: pnote, pinvid: pinvid},
        public String save_it(String pdate, String ptype, Int64 pinvid, String pnote)
        {
            try
            {
                DateTime datenow = Convert.ToDateTime(pdate);
                using (var db = new dbsmsEntities())
                {
                    salespayment newdata = new salespayment();
                    newdata.date = datenow;
                    newdata.description = "";
                    newdata.salesinvoiceid = pinvid;
                    newdata.to = db.hsalesinvoices.Find(pinvid).customer.name + "\n" + db.hsalesinvoices.Find(pinvid).customer.address + "\n" + db.hsalesinvoices.Find(pinvid).customer.city + "\n" + db.hsalesinvoices.Find(pinvid).customer.phone;
                    newdata.projectid = Convert.ToInt64(Session["project"]);
                    newdata.type = ptype;
                    newdata.note = pnote;
                    newdata.total = db.hsalesinvoices.Find(pinvid).grandtotal;
                    newdata.number = db.hsalesinvoices.Find(pinvid).number;
                    db.hsalesinvoices.Find(pinvid).status = 1;
                    db.salespayments.Add(newdata);
                    db.projects.Find(Convert.ToInt64(Session["project"])).status1.salespayment = 1;
                    db.SaveChanges();
                    return GlobalFunction.get_max_id("salespayment").ToString();
                }
            }
            catch (Exception e)
            {
                return "fail";
            }

        }
    }
}
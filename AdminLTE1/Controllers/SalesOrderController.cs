using AdminLTE1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLTE1.Controllers
{
    public class SalesOrderController : Controller
    {
        // GET: SalesOrder
        public ActionResult Index()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "sales_order"))
            {
                TempData["back_url"] = Request.UrlReferrer.ToString();
                return Redirect(Url.Action("error403", "Error"));
            }
            using (var db = new dbsmsEntities())
            {
                if (Session["project"] != null && db.projects.Find(Session["project"]).status1.salesorder == 1)
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
        public String save_all(String sodate, String expecteddate, String designdate, String terms, Int64 tcustomer, String usedesign, Int64 projectid, String desc, Int64 total, Int64 dp, Int64 remainingpayment, String detail)
        {
            try
            {
                DateTime datenow = Convert.ToDateTime(sodate);
                DateTime datenow1 = Convert.ToDateTime(expecteddate);
                DateTime datenow2 = Convert.ToDateTime(designdate);
                String newSOnum = GlobalFunction.generate_code("SO");
                using (var db = new dbsmsEntities())
                {
                    hsalesorder newdata = new hsalesorder();
                    newdata.date = datenow;
                    newdata.expecteddate = datenow1;
                    if (usedesign == "true")
                        newdata.designdate = datenow2;
                    newdata.terms = terms;
                    newdata.customerid = tcustomer;
                    newdata.projectid = projectid;
                    newdata.description = desc;
                    newdata.number = newSOnum;
                    newdata.dp = dp;
                    newdata.total = total;
                    newdata.grandtotal = remainingpayment;
                    db.hsalesorders.Add(newdata);
                    String[] res = detail.Split('ѥ');
                    for (int i = 0; i < res.Length - 1; i++)
                    {
                        String[] result = res[i].Split('Ё');
                        dsalesorder data = new dsalesorder();
                        //itemcatid+"Ё"+itemdescription+"Ё"+qty+"Ё"+unitprice+"Ё"+subtotal
                        data.itemcategoryid = Convert.ToInt64(result[0]);
                        data.itemdescription = result[1];
                        data.qty = Convert.ToInt32(result[2]);
                        data.unitprice = Convert.ToInt32(result[3]);
                        data.subtotal = data.qty * data.unitprice;
                        //data.penawaranid = GlobalFunction.get_max_id("hpenawaran");
                        db.dsalesorders.Add(data);
                    }
                    db.SaveChanges();
                    if (dp > 0)
                    {
                        using (var db1 = new dbsmsEntities())
                        {
                            hsalesinvoice newdata1 = new hsalesinvoice();
                            newdata1.date = datenow;
                            newdata1.number = GlobalFunction.generate_code("INV");
                            newdata1.projectid = projectid;
                            newdata1.terms = terms;
                            newdata1.customerid = tcustomer;
                            newdata1.description = "Down payment untuk SO : " + newSOnum;
                            newdata1.total = dp;
                            newdata1.grandtotal = dp;
                            db1.hsalesinvoices.Add(newdata1);
                            dsalesinvoice newdata2 = new dsalesinvoice();
                            newdata2.itemcategoryid = 2;
                            newdata2.itemdescription = "Down Payment";
                            newdata2.qty = 1;
                            newdata2.unitprice = dp;
                            newdata2.subtotal = dp;
                            db1.dsalesinvoices.Add(newdata2);
                            db1.hsalesinvoices.Find(GlobalFunction.get_max_id("hsalesinvoice")).project.status1.salesinvoice = 1;
                            db1.SaveChanges();
                        }
                    }
                    using (var db1 = new dbsmsEntities())
                    {
                        foreach (Int64 item in db.projects.Find(Convert.ToInt64(Session["project"])).hpenawarans.First().dpenawarans.Select(x=>x.supplierid).Distinct())
                        {
                            String newponumb = GlobalFunction.generate_code("PO");
                            Int64 total_ = 0;
                            hpo newhpo = new hpo();
                            newhpo.date = datenow;
                            newhpo.projectid = Convert.ToInt64(Session["project"]);
                            newhpo.number = newponumb;
                            newhpo.supplierid = item;
                            newhpo.terms = "C.O.D";
                            newhpo.to = "";
                            db1.hpoes.Add(newhpo);
                            Int64 maxday = 0;
                            foreach (dpenawaran item2 in db.projects.Find(Convert.ToInt64(Session["project"])).hpenawarans.First().dpenawarans.Where(x=>x.supplierid==item))
                            {
                                dpo newdpo = new dpo();
                                newdpo.itemcategoryid = item2.itemcategoryid;
                                newdpo.itemdescription = item2.itemdescription;
                                newdpo.qty = item2.qty;
                                newdpo.unitprice = item2.hpenawaran.project.findprices.Where(x => x.supplierid == item && x.itemdescription == item2.itemdescription).First().unitprice;
                                newdpo.subtotal = newdpo.qty * newdpo.unitprice;
                                if (item2.hpenawaran.project.findprices.Where(x => x.supplierid == item && item2.itemdescription == x.itemdescription).First().timeneeded > maxday) maxday = item2.hpenawaran.project.findprices.Where(x => x.supplierid == item && item2.itemdescription == x.itemdescription).First().timeneeded;
                                total_ += newdpo.subtotal;
                                db1.dpoes.Add(newdpo);
                            }
                            newhpo.total = total_;
                            newhpo.dp = 0;
                            newhpo.discount = 0;
                            newhpo.grandtotal = total_;
                            newhpo.expecteddate = datenow.AddDays(maxday);
                            db1.SaveChanges();
                        }
                        db1.hsalesorders.Find(GlobalFunction.get_max_id("hsalesorder")).project.status1.salesorder = 1;
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
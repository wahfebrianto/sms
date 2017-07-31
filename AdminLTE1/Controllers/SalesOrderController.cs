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
                            db1.hsalesinvoices.Add(newdata1);
                            dsalesinvoice newdata2 = new dsalesinvoice();
                            newdata2.itemcategoryid = 2;
                            newdata2.itemdescription = "Down Payment";
                            newdata2.qty = 1;
                            newdata2.unitprice = dp;
                            newdata2.subtotal = dp;
                            db1.dsalesinvoices.Add(newdata2);
                            db1.SaveChanges();
                        }
                    }
                    using (var db1 = new dbsmsEntities())
                    {
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
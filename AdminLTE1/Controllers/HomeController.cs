using System.Web.Mvc;
using System.Linq;
using AdminLTE1.Helpers;
using System;
using System.Collections.Generic;

namespace AdminLTE1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session["user"] = Session["user"]??"";
            return View();
        }

        public ActionResult History()
        {
            return View("History");
        }
        public String edit_desc(Int64 projid,String desc)
        {
            try
            {
                using (var db = new dbsmsEntities())
                {
                    db.projects.Find(projid).description = desc;
                    db.SaveChanges();
                }
                return "success";
            }
            catch
            {
                return "fail";
            }
            
        }
        public String delete_project(Int64 projid)
        {
            try
            {
                using(var db = new dbsmsEntities())
                {
                    project p = db.projects.Find(projid);
                    List<salespayment> item1 = p.salespayments.ToList();
                    db.salespayments.RemoveRange(item1);
                    List<hsalesinvoice> item2 = p.hsalesinvoices.ToList();
                    foreach (hsalesinvoice item in item2)
                    {
                        db.dsalesinvoices.RemoveRange(item.dsalesinvoices);
                    }
                    db.hsalesinvoices.RemoveRange(item2);
                    List<hsuratjalan> item3 = p.hsuratjalans.ToList();
                    foreach (hsuratjalan item in p.hsuratjalans)
                    {
                        db.dsuratjalans.RemoveRange(item.dsuratjalans);
                    }
                    db.hsuratjalans.RemoveRange(item3);
                    List<purchasepayment> item4 = p.purchasepayments.ToList();
                    
                    db.purchasepayments.RemoveRange(item4);
                    List<hpurchaseinvoice> item5 = p.hpurchaseinvoices.ToList();
                    foreach (hpurchaseinvoice item in p.hpurchaseinvoices)
                    {
                        db.dpurchaseinvoices.RemoveRange(item.dpurchaseinvoices);
                    }
                    db.hpurchaseinvoices.RemoveRange(item5);
                    List<hreceiveitem> item6 = p.hreceiveitems.ToList();
                    foreach (hreceiveitem item in p.hreceiveitems)
                    {
                        db.dreceiveitems.RemoveRange(item.dreceiveitems);
                    }
                    db.hreceiveitems.RemoveRange(item6);
                    List<hpo> item7 = p.hpoes.ToList();
                    foreach (hpo item in p.hpoes)
                    {
                        db.dpoes.RemoveRange(item.dpoes);
                    }
                    db.hpoes.RemoveRange(item7);
                    List<hsalesorder> item8 = p.hsalesorders.ToList();
                    foreach (hsalesorder item in p.hsalesorders)
                    {
                        db.dsalesorders.RemoveRange(item.dsalesorders);
                    }
                    db.hsalesorders.RemoveRange(item8);
                    List<hpenawaran> item9 = p.hpenawarans.ToList();
                    foreach (hpenawaran item in p.hpenawarans)
                    {
                        db.dpenawarans.RemoveRange(item.dpenawarans);
                    }
                    db.hpenawarans.RemoveRange(item9);
                    List<findprice> item10 = p.findprices.ToList();
                    db.findprices.RemoveRange(item10);
                    List<hrfq> item11 = p.hrfqs.ToList();
                    foreach (hrfq item in p.hrfqs)
                    {
                        db.drfqs.RemoveRange(item.drfqs);
                    }
                    db.hrfqs.RemoveRange(item11);
                    //deletenote
                    db.rfqnotes.RemoveRange(p.rfqnotes);
                    db.findpricesnotes.RemoveRange(p.findpricesnotes);
                    db.penawarannotes.RemoveRange(p.penawarannotes);
                    db.salesordernotes.RemoveRange(p.salesordernotes);
                    db.ponotes.RemoveRange(p.ponotes);
                    db.receiveitemnotes.RemoveRange(p.receiveitemnotes);
                    db.purchaseinvoicenotes.RemoveRange(p.purchaseinvoicenotes);
                    db.purchasepaymentnotes.RemoveRange(p.purchasepaymentnotes);
                    db.suratjalannotes.RemoveRange(p.suratjalannotes);
                    db.salesinvoicenotes.RemoveRange(p.salesinvoicenotes);
                    db.salespaymentnotes.RemoveRange(p.salespaymentnotes);
                    //endofdeletenote
                    db.projects.Remove(p);
                    db.SaveChanges();
                }
                return "success";
            }
            catch (Exception e)
            {
                return "fail";
                throw;
            }
        }

        public String add_note(String text,String controller)
        {
            try
            {
                using (var db = new dbsmsEntities())
                {
                    if (controller.ToLower() == "rfq")
                    {
                        rfqnote data = new rfqnote();
                        data.projectid = Convert.ToInt64(Session["project"]);
                        data.username = Session["user"].ToString();
                        data.text = text;
                        data.date = DateTime.Now;
                        db.rfqnotes.Add(data);
                    }
                    else if (controller.ToLower() == "findprices")
                    {
                        findpricesnote data = new findpricesnote();
                        data.projectid = Convert.ToInt64(Session["project"]);
                        data.username = Session["user"].ToString();
                        data.text = text;
                        data.date = DateTime.Now;
                        db.findpricesnotes.Add(data);
                    }
                    else if (controller.ToLower() == "penawaran")
                    {
                        penawarannote data = new penawarannote();
                        data.projectid = Convert.ToInt64(Session["project"]);
                        data.username = Session["user"].ToString();
                        data.text = text;
                        data.date = DateTime.Now;
                        db.penawarannotes.Add(data);
                    }
                    else if (controller.ToLower() == "salesorder")
                    {
                        salesordernote data = new salesordernote();
                        data.projectid = Convert.ToInt64(Session["project"]);
                        data.username = Session["user"].ToString();
                        data.text = text;
                        data.date = DateTime.Now;
                        db.salesordernotes.Add(data);
                    }
                    else if (controller.ToLower() == "purchaseorder")
                    {
                        ponote data = new ponote();
                        data.projectid = Convert.ToInt64(Session["project"]);
                        data.username = Session["user"].ToString();
                        data.text = text;
                        data.date = DateTime.Now;
                        db.ponotes.Add(data);
                    }
                    else if (controller.ToLower() == "receiveitem")
                    {
                        receiveitemnote data = new receiveitemnote();
                        data.projectid = Convert.ToInt64(Session["project"]);
                        data.username = Session["user"].ToString();
                        data.text = text;
                        data.date = DateTime.Now;
                        db.receiveitemnotes.Add(data);
                    }
                    else if (controller.ToLower() == "purchaseinvoice")
                    {
                        purchaseinvoicenote data = new purchaseinvoicenote();
                        data.projectid = Convert.ToInt64(Session["project"]);
                        data.username = Session["user"].ToString();
                        data.text = text;
                        data.date = DateTime.Now;
                        db.purchaseinvoicenotes.Add(data);
                    }
                    else if (controller.ToLower() == "purchasepayment")
                    {
                        purchasepaymentnote data = new purchasepaymentnote();
                        data.projectid = Convert.ToInt64(Session["project"]);
                        data.username = Session["user"].ToString();
                        data.text = text;
                        data.date = DateTime.Now;
                        db.purchasepaymentnotes.Add(data);
                    }
                    else if (controller.ToLower() == "suratjalan")
                    {
                        suratjalannote data = new suratjalannote();
                        data.projectid = Convert.ToInt64(Session["project"]);
                        data.username = Session["user"].ToString();
                        data.text = text;
                        data.date = DateTime.Now;
                        db.suratjalannotes.Add(data);
                    }
                    else if (controller.ToLower() == "salesinvoice")
                    {
                        salesinvoicenote data = new salesinvoicenote();
                        data.projectid = Convert.ToInt64(Session["project"]);
                        data.username = Session["user"].ToString();
                        data.text = text;
                        data.date = DateTime.Now;
                        db.salesinvoicenotes.Add(data);
                    }
                    else if (controller.ToLower() == "salespayment")
                    {
                        salespaymentnote data = new salespaymentnote();
                        data.projectid = Convert.ToInt64(Session["project"]);
                        data.username = Session["user"].ToString();
                        data.text = text;
                        data.date = DateTime.Now;
                        db.salespaymentnotes.Add(data);
                    }
                    db.SaveChanges();
                    return "success";

                }
            }
            catch (Exception)
            {
                return "fail";
            }
            
            
        }

        public ActionResult Jump()
        {
            Int64 id = Convert.ToInt64(Request.QueryString["id"]);
            Session["project"] = id;
            List<String> listid = GlobalFunction.getId(id, 0);
            for (int i = listid.Count-1; i >= 0; i--)
            {
                if (!(GlobalFunction.is_allowed(id, listid[i]) && GlobalFunction.has_privilege(Session["user"].ToString(),"select",listid[i]))) listid.RemoveAt(i) ;
            }
            try
            {
                return RedirectToAction("Index", listid[0]);
            }
            catch
            {
                try
                {
                    listid = GlobalFunction.getId(id, 1);
                    for (int i = listid.Count - 1; i >= 0; i--)
                    {
                        if (!(GlobalFunction.is_allowed(id, listid[i]) && GlobalFunction.has_privilege(Session["user"].ToString(), "select", listid[i]))) listid.RemoveAt(i);
                    }
                    return RedirectToAction("Index", listid.Last());
                }
                catch
                {
                    TempData["back_url"] = Request.UrlReferrer.ToString();
                    return Redirect(Url.Action("error403", "Error"));
                }
            }
        }
        public string change_password(string oldPassword,string newPassword)
        {
            
            using(var db = new dbsmsEntities())
            {
                try
                {
                    string pass = MD5.Hash(oldPassword);
                    string username = Session["user"].ToString();
                    user user_ = (from u in db.users
                                  where u.password == pass && u.username == username
                                  select u).First();
                    user_.password = MD5.Hash(newPassword);
                    db.SaveChanges();
                    return "1";
                }
                catch (System.Exception e)
                {
                    return "0";
                }
            }
            
        }

        public ActionResult FinishProject()
        {
            using (var db = new dbsmsEntities())
            {
                Int64 id = Convert.ToInt64(Session["project"]);
                db.projects.Find(id).status = 1;
                db.SaveChanges();
            }
            return Redirect(Url.Action("Index", "Home"));
        }

        public String repeat_project(Int64 projid, String projname)
        {
            try
            {
                using (var db = new dbsmsEntities())
                {
                    project p_lama = db.projects.Find(projid);
                    hrfq hrfq_lama = p_lama.hrfqs.First();
                    List<drfq> drfq_lama = hrfq_lama.drfqs.ToList();
                    List<findprice> findprice_lama = p_lama.findprices.ToList();
                    hpenawaran hpenawaran_lama = p_lama.hpenawarans.First();
                    List<dpenawaran> dpenawaran_lama = hpenawaran_lama.dpenawarans.ToList();

                    status s = new status();
                    project p_baru = new project();
                    p_baru.status1 = s;
                    p_baru.name = projname;
                    p_baru.status = 0;
                    p_baru.customer = p_lama.customer;
                    p_baru.description = "";
                    db.projects.Add(p_baru);

                    hrfq hrfq_baru = new hrfq();
                    hrfq_baru.customer = hrfq_lama.customer;
                    hrfq_baru.date = DateTime.Now;
                    hrfq_baru.description = "";
                    hrfq_baru.to = hrfq_lama.to;
                    hrfq_baru.description = hrfq_lama.description;
                    hrfq_baru.project = p_baru;
                    db.hrfqs.Add(hrfq_baru);

                    drfq_lama.ForEach(x =>
                    {
                        drfq drfq_baru = new drfq();
                        drfq_baru.hrfq = hrfq_baru;
                        drfq_baru.itemcategoryid = x.itemcategoryid;
                        drfq_baru.itemdescription = x.itemdescription;
                        drfq_baru.qty = x.qty;
                        drfq_baru.subtotal = x.subtotal;
                        drfq_baru.unitprice = x.unitprice;
                        db.drfqs.Add(drfq_baru);
                    });

                    findprice_lama.ForEach(x =>
                    {
                        findprice findprice_baru = new findprice();
                        findprice_baru.address = x.address;
                        findprice_baru.description = x.description;
                        findprice_baru.itemdescription = x.itemdescription;
                        findprice_baru.project = p_baru;
                        findprice_baru.qty = x.qty;
                        findprice_baru.status = x.status;
                        findprice_baru.supplier = x.supplier;
                        findprice_baru.timeneeded = x.timeneeded;
                        findprice_baru.unitprice = x.unitprice;
                        db.findprices.Add(findprice_baru);
                    });

                    hpenawaran hpenawaran_baru = new hpenawaran();
                    hpenawaran_baru.customer = hpenawaran_lama.customer;
                    hpenawaran_baru.date = DateTime.Now;
                    hpenawaran_baru.description = "";
                    hpenawaran_baru.to = hpenawaran_lama.to;
                    hpenawaran_baru.description = hpenawaran_lama.description;
                    hpenawaran_baru.project = p_baru;
                    hpenawaran_baru.disc = hpenawaran_lama.disc;
                    hpenawaran_baru.grandtotal = hpenawaran_lama.grandtotal;
                    hpenawaran_baru.number = GlobalFunction.generate_code("PNW");
                    hpenawaran_baru.to = hpenawaran_lama.to;
                    hpenawaran_baru.total = hpenawaran_lama.total;
                    db.hpenawarans.Add(hpenawaran_baru);

                    dpenawaran_lama.ForEach(x =>
                    {
                        dpenawaran dpenawaran_baru = new dpenawaran();
                        dpenawaran_baru.hpenawaran = hpenawaran_baru;
                        dpenawaran_baru.itemcategoryid = x.itemcategoryid;
                        dpenawaran_baru.itemdescription = x.itemdescription;
                        dpenawaran_baru.qty = x.qty;
                        dpenawaran_baru.subtotal = x.subtotal;
                        dpenawaran_baru.unitprice = x.unitprice;
                        dpenawaran_baru.supplier = x.supplier;
                        db.dpenawarans.Add(dpenawaran_baru);
                    });

                    p_baru.status1.rfq = 1;
                    p_baru.status1.findprices = 1;
                    p_baru.status1.penawaran = 1;

                    db.SaveChanges();
                }
                Int64 id = GlobalFunction.get_max_id("project");
                Session["project"] = id;
                return "success";
            }
            catch 
            {
                return "fail";
            }
        }

        public String get_unpaid(Int64 projid)
        {
            try
            {
                using (var db = new dbsmsEntities())
                {
                    List<hpurchaseinvoice> hpi = db.hpurchaseinvoices.Where(x => x.projectid == projid && x.status != 1).ToList();
                    List<hsalesinvoice> hsi = db.hsalesinvoices.Where(x => x.projectid == projid && x.status != 1).ToList();
                    String hpirow = "<table class='table table-hover table-bordered'>" +
                        "<caption class='text-center text-bold'>Unpaid Purchase Invoice</caption><thead>" +
                        "<tr>" +
                            "<th class='col-md-3 text-center'>Invoice Number</th>" +
                            "<th class='col-md-3 text-center'>Supplier Name</th>" +
                        "</tr></thead><tbody>" ;
                    foreach (hpurchaseinvoice item in hpi)
                    {
                        hpirow += "<tr>" +
                            "<td><a href='"+ Url.Action("move","Project") +"?controller=PurchasePayment&projid="+projid+"&id=0'>" + item.number + "</a></td>" +
                            "<td>" + item.supplier.name + "</td>" +
                        "</tr>";
                    }
                    hpirow += "</tbody></table>";
                    if(hpi.Count <= 0)
                    {
                        hpirow = "All purchase invoices have been paid";
                    }
                    String hsirow = "<table class='table table-hover table-bordered'>" +
                        "<caption class='text-center text-bold'>Unpaid Sales Invoice</caption><thead>" +
                        "<tr>" +
                            "<th class='col-md-6 text-center'>Invoice Number</th>" +
                            "<th class='col-md-6 text-center'>Customer Name</th>" +
                        "</tr></thead><tbody>";
                    foreach (hsalesinvoice item in hsi)
                    {
                        hsirow += "<tr>" +
                            "<td><a href='" + Url.Action("move", "Project") + "?controller=SalesPayment&projid=" + projid + "&id=0'>" + item.number + "</a></td>" +
                            "<td>" + item.customer.name + "</td>" +
                        "</tr>";
                    }
                    hsirow += "</tbody></table>";
                    if (hsi.Count <= 0)
                    {
                        hsirow = "All sales invoices have been paid";
                    }
                    return "<div class='col-md-5'>" +
                        hpirow +
                    "<br/>" +
                        hsirow +
                    "</div>";
                }
            }
            catch
            {
                return "undefined";
            }
        }
    }
}
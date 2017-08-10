using AdminLTE1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLTE1.Controllers
{
    public class ReceiveItemController : Controller
    {
        // GET: ReceiveItem
        public ActionResult Index()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "receive_item"))
            {
                TempData["back_url"] = Request.UrlReferrer.ToString();
                return Redirect(Url.Action("error403", "Error"));
            }
            return View();
        }

        public ActionResult Transaksi()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "receive_item"))
            {
                TempData["back_url"] = Request.UrlReferrer.ToString();
                return Redirect(Url.Action("error403", "Error"));
            }
            return View();
        }
        public ActionResult History()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "receive_item"))
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
                using(var db= new dbsmsEntities())
                {

                    hreceiveitem data = db.hreceiveitems.Find(id);
                    List<dreceiveitem> ddata = data.dreceiveitems.ToList();
                    db.dreceiveitems.RemoveRange(ddata);
                    db.hreceiveitems.Remove(data);
                    db.SaveChanges();
                    return "success";
                }
            }
            catch
            {
                return "fail";
            }
        }
        //data: { ridate: ridate, poid: poid, desc: desc, detail: detail },
        public String save_it(String ridate, Int64 poid, String desc, String detail)
        {
            try
            {
                DateTime datenow = Convert.ToDateTime(ridate);
                using (var db = new dbsmsEntities())
                {
                    hreceiveitem newdata = new hreceiveitem();
                    newdata.date = datenow;
                    newdata.description = desc;
                    newdata.poid = poid;
                    newdata.supplierid = db.hpoes.Find(poid).supplierid;
                    newdata.projectid = Convert.ToInt64(Session["project"]);
                    newdata.number = GlobalFunction.generate_code("RI");
                    db.hreceiveitems.Add(newdata);
                    String[] res = detail.Split('ѥ');
                    for (int i = 0; i < res.Length - 1; i++)
                    {
                        String[] result = res[i].Split('Ё');
                        dreceiveitem data = new dreceiveitem();
                        //detail += itemcatid + "Ё" + itemdescription + "Ё" + qty;
                        data.itemcategoryid = Convert.ToInt64(result[0]);
                        data.itemdescription = result[1];
                        data.qty = Convert.ToInt32(result[2]);
                        //data.penawaranid = GlobalFunction.get_max_id("hpenawaran");
                        db.dreceiveitems.Add(data);
                    }
                    db.SaveChanges();
                    using (var db1 = new dbsmsEntities())
                    {
                        hpo po_ = db1.hpoes.Find(poid);
                        bool penuh = true;
                        foreach(dpo item in po_.dpoes.ToList())
                        {
                            Int64 total = 0;
                            foreach(hreceiveitem item2 in db1.hreceiveitems.Where(x=> x.poid == poid))
                            {
                                foreach(dreceiveitem item3 in item2.dreceiveitems.Where(x=> x.itemcategoryid == item.itemcategoryid && x.itemdescription == item.itemdescription))
                                {
                                    total += item3.qty;
                                }
                            }
                            if(total != item.qty)
                            {
                                penuh = false;
                            }
                        }
                        if (penuh)
                        {
                            po_.status = 2;
                        }
                            
                        db1.projects.Find(Convert.ToInt64(Session["project"])).status1.receiveitem = 1;
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
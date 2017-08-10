using AdminLTE1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLTE1.Controllers
{
    public class SuratJalanController : Controller
    {
        // GET: SuratJalan
        public ActionResult Index()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "surat_jalan"))
            {
                TempData["back_url"] = Request.UrlReferrer.ToString();
                return Redirect(Url.Action("error403", "Error"));
            }
            return View();
        }
        public ActionResult Transaksi()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "surat_jalan"))
            {
                TempData["back_url"] = Request.UrlReferrer.ToString();
                return Redirect(Url.Action("error403", "Error"));
            }
            return View();
        }
        public ActionResult History()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "surat_jalan"))
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

                    hsuratjalan data = db.hsuratjalans.Find(id);
                    List<dsuratjalan> ddata = data.dsuratjalans.ToList();
                    db.dsuratjalans.RemoveRange(ddata);
                    db.hsuratjalans.Remove(data);
                    db.SaveChanges();
                    return "success";
                }
            }
            catch
            {
                return "fail";
            }
        }
        public String save_it(String sjdate, String shipto, String desc, String detail)
        {
            try
            {
                DateTime datenow = Convert.ToDateTime(sjdate);
                using (var db = new dbsmsEntities())
                {
                    hsuratjalan newdata = new hsuratjalan();
                    newdata.date = datenow;
                    newdata.description = desc;
                    newdata.to = shipto;
                    newdata.projectid = Convert.ToInt64(Session["project"]);
                    newdata.number = GlobalFunction.generate_code("SJ");
                    db.hsuratjalans.Add(newdata);
                    String[] res = detail.Split('ѥ');
                    for (int i = 0; i < res.Length - 1; i++)
                    {
                        String[] result = res[i].Split('Ё');
                        dsuratjalan data = new dsuratjalan();
                        //detail += itemcatid + "Ё" + itemdescription + "Ё" + qty;
                        data.itemcategoryid = Convert.ToInt64(result[0]);
                        data.itemdescription = result[1];
                        data.qty = Convert.ToInt32(result[2]);
                        //data.penawaranid = GlobalFunction.get_max_id("hpenawaran");
                        db.dsuratjalans.Add(data);
                    }
                    db.SaveChanges();
                    using (var db1 = new dbsmsEntities())
                    {
                        db1.projects.Find(Convert.ToInt64(Session["project"])).status1.suratjalan = 1;
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
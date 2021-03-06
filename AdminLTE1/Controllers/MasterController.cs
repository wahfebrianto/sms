﻿using AdminLTE1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLTE1.Controllers
{
    public class MasterController : Controller
    {
        // GET: Master
        public ActionResult Master_Kategori()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "master_kategori"))
            {
                TempData["back_url"] = Request.UrlReferrer.ToString();
                return Redirect(Url.Action("error403", "Error"));
            }
            ViewBag.success = TempData["success"];
            return View();
        }

        public ActionResult Master_Supplier()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "master_supplier"))
            {
                TempData["back_url"] = Request.UrlReferrer.ToString();
                return Redirect(Url.Action("error403", "Error"));
            }
            ViewBag.success = TempData["success"];
            return View();
        }

        public ActionResult Master_Customer()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "master_customer"))
            {
                TempData["back_url"] = Request.UrlReferrer.ToString();
                return Redirect(Url.Action("error403", "Error"));
            }
            ViewBag.success = TempData["success"];
            return View();
        }

        public ActionResult Master_User()
        {
            if (!GlobalFunction.has_privilege(Session["user"].ToString(), "select", "master_user"))
            {
                TempData["back_url"] = Request.UrlReferrer.ToString();
                return Redirect(Url.Action("error403", "Error"));
            }
            ViewBag.success = TempData["success"];
            return View();
        }

        [HttpPost]
        public ActionResult save_category(string catId, string catName, string catDesc)
        {
            using (var db = new dbsmsEntities())
            {
                if (String.IsNullOrEmpty(catId))
                {
                    item_category data = new item_category();
                    data.name = catName;
                    data.description = catDesc;
                    data.status = 1;
                    db.item_category.Add(data);
                }
                else
                {
                    item_category data = db.item_category.Find(Convert.ToInt64(catId));
                    data.name = catName;
                    data.description = catDesc;
                }
                db.SaveChanges();
            }
            TempData["success"] = "Your data has been saved.";
            return RedirectToAction("Master_Kategori", "Master");
        }

        [HttpGet]
        public ActionResult delete_category(string catId)
        {
            using (var db = new dbsmsEntities())
            {
                if (!String.IsNullOrEmpty(catId))
                {
                    item_category data = db.item_category.Find(Convert.ToInt64(catId));
                    data.status = 0;
                }
                db.SaveChanges();
            }
            TempData["success"] = "Your data has been deleted.";
            return RedirectToAction("Master_Kategori", "Master");
        }
        [HttpPost]
        public ActionResult save_supplier(string suppId, string suppName, string suppAddress, string suppCity, string suppPhone, string suppDesc, int mode=0)
        {
            using (var db = new dbsmsEntities())
            {
                if (String.IsNullOrEmpty(suppId))
                {
                    supplier data = new supplier();
                    data.name = suppName;
                    data.phone = suppPhone;
                    data.city = suppCity;
                    data.address = suppAddress;
                    data.description = suppDesc;
                    data.status = 1;
                    db.suppliers.Add(data);
                }
                else
                {
                    supplier data = db.suppliers.Find(Convert.ToInt64(suppId));
                    data.name = suppName;
                    data.address = suppAddress;
                    data.phone = suppPhone;
                    data.city = suppCity;
                    data.description = suppDesc;
                }
                db.SaveChanges();
            }
            TempData["success"] = "Your data has been saved.";
            if (mode != 0)
            {
                return null;
            }
            return RedirectToAction("Master_Supplier", "Master");
        }

        [HttpGet]
        public ActionResult delete_supplier(string suppId)
        {
            using (var db = new dbsmsEntities())
            {
                if (!String.IsNullOrEmpty(suppId))
                {
                    supplier data = db.suppliers.Find(Convert.ToInt64(suppId));
                    data.status = 0;
                }
                db.SaveChanges();
            }
            TempData["success"] = "Your data has been deleted.";
            return RedirectToAction("Master_Supplier", "Master");
        }

        [HttpPost]
        public ActionResult save_customer(string custId, string custName, string custAddress, string custCity, string custPhone, string custDesc,int mode=0)
        {
            using (var db = new dbsmsEntities())
            {
                if (String.IsNullOrEmpty(custId))
                {
                    customer data = new customer();
                    data.name = custName;
                    data.phone = custPhone;
                    data.city = custCity;
                    data.address = custAddress;
                    data.description = custDesc;
                    data.status = 1;
                    db.customers.Add(data);
                }
                else
                {
                    customer data = db.customers.Find(Convert.ToInt64(custId));
                    data.name = custName;
                    data.address = custAddress;
                    data.phone = custPhone;
                    data.city = custCity;
                    data.description = custDesc;
                }
                db.SaveChanges();
            }
            TempData["success"] = "Your data has been saved.";
            if(mode != 0)
            {
                return null;
            }
            return RedirectToAction("Master_Customer", "Master");
        }
        [HttpGet]
        public ActionResult delete_customer(string custId)
        {
            using (var db = new dbsmsEntities())
            {
                if (!String.IsNullOrEmpty(custId))
                {
                    customer data = db.customers.Find(Convert.ToInt64(custId));
                    data.status = 0;
                }
                db.SaveChanges();
            }
            TempData["success"] = "Your data has been deleted.";
            return RedirectToAction("Master_Customer", "Master");
        }

        [HttpPost]
        public string save_user(string userId, string userName, string userUserName, string userDesc)
        {
            string userPass = "";
            using (var db = new dbsmsEntities())
            {
                if (db.users.Select(x => x.username).Contains(userUserName))
                {
                    return "0";
                }
                if (String.IsNullOrEmpty(userId))
                {
                    user data = new user();
                    data.name = userName;
                    data.username = userUserName;
                    userPass = userUserName + "123";
                    data.password = MD5.Hash(userPass);
                    data.description = userDesc;
                    data.status = 1;
                    db.users.Add(data);
                }
                else
                {
                    user data = db.users.Find(Convert.ToInt64(userId));
                    data.name = userName;
                    data.username = userUserName;
                    data.password = MD5.Hash(userPass);
                    data.description = userDesc;
                }
                db.SaveChanges();
            }
            return "1";
        }

        [HttpGet]
        public ActionResult delete_user(string userId)
        {
            using (var db = new dbsmsEntities())
            {
                if (!String.IsNullOrEmpty(userId))
                {
                    user data = db.users.Find(Convert.ToInt64(userId));
                    data.status = 0;
                }
                db.SaveChanges();
            }
            TempData["success"] = "Your data has been deleted.";
            return RedirectToAction("Master_User", "Master");
        }

        public String getRole(string userid)
        {
            using (var db = new dbsmsEntities())
            {
                String result = "";
                List<role> data = db.users.Find(Convert.ToInt64(userid)).roles.ToList();
                foreach (role item in data)
                {
                    result += item.id + "|";
                }
                return result;
            }
        }
        public ActionResult save_role(String param, String userid)
        {
            using (var db = new dbsmsEntities())
            {
                user data = db.users.Find(Convert.ToInt64(userid));
                db.roles.ToList().ForEach(x => x.users.Remove(data));
                foreach (String item in param.Split('|'))
                {
                    if (!String.IsNullOrEmpty(item))
                    {
                        role rol = db.roles.Find(Convert.ToInt64(item));
                        data.roles.Add(rol);
                    }
                }
                db.SaveChanges();
            }
            return RedirectToAction("Master_User", "Master");
        }

        public String reset_pass(String userid)
        {
            using (var db = new dbsmsEntities())
            {
                user data = db.users.Find(Convert.ToInt64(userid));
                data.password = MD5.Hash(data.username + "123");
                db.SaveChanges();
            }
            return "reset ke username + 123";
        }

        public Int64 get_max_id(String tableName)
        {
            Int64 id = GlobalFunction.get_max_id(tableName);
            return id;
        }
    }
}
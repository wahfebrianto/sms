﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace AdminLTE1.Controllers
{
    public class RoleController : Controller
    {
        // GET: Role
        public ActionResult Index()
        {
            ViewBag.success = TempData["success"];
            return View();
        }

        [HttpPost]
        public ActionResult save_role(string roleId, string roleName, string roleDesc)
        {
            using (var db = new dbsmsEntities())
            {
                if (String.IsNullOrEmpty(roleId))
                {
                    role data = new role();
                    data.name = roleName;
                    data.description = roleDesc;
                    db.roles.Add(data);
                }
                else
                {
                    role data = db.roles.Find(Convert.ToInt64(roleId));
                    data.name = roleName;
                    data.description = roleDesc;
                }
                db.SaveChanges();
            }
            TempData["success"] = "Your data has been saved.";
            return RedirectToAction("Index", "Role");
        }

        [HttpGet]
        public ActionResult delete_role(string roleId)
        {
            using(var db = new dbsmsEntities())
            {
                role data = db.roles.Find(Convert.ToInt64(roleId));
                db.users.ToList().ForEach(x => x.roles.Remove(data));
                db.privileges.ToList().ForEach(x => x.roles.Remove(data));
                db.roles.Remove(data);
                db.SaveChanges();
            }
            TempData["success"] = "Your data has been deleted.";
            return RedirectToAction("Index", "Role");
        }
        public String getPrivileges(String roleId)
        {
            try
            {
                using (var db = new dbsmsEntities())
                {
                    role thisRole = db.roles.Find(Convert.ToInt64(roleId));
                    String privileges = "";
                    foreach (var item in thisRole.privileges)
                    {
                        privileges = privileges + item.action + item.tablename + "-";
                    }
                    return privileges;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
﻿using AdminLTE1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLTE1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            Session.Timeout = 60;
            Session["user"] = "";
            ViewBag.Title = "Login";
            ViewBag.message = TempData["message"];
            return View();
        }
        public ActionResult Login(String username,String password)
        {
            using(var db = new dbsmsEntities())
            {
                password = MD5.Hash(password);
                try
                {
                    user usr = (from u in db.users
                                where u.username == username && u.password == password
                                select u).First();
                    Session["user"] = usr.username;
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception e)
                {
                    TempData["message"] = "Invalid Username or Password";
                }
                return RedirectToAction("Index", "Login");
            }
        }
    }
}
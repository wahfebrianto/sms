using System.Web.Mvc;
using System.Linq;
using AdminLTE1.Helpers;
using System;

namespace AdminLTE1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult History()
        {
            return View("History");
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
                    Console.WriteLine("WOIIIIIIIIII : "+e.Message);
                    return "0";
                }
            }
            
        }
    }
}
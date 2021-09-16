using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UMSDemo.Models;

namespace UMSDemo.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Authorise(Admin admin)
        {
            using (UMSDbContext context = new UMSDbContext())
            {
                var userDetail = context.Admins.Where(x => x.UserName == admin.UserName && x.Password == admin.Password).FirstOrDefault();
                if (userDetail == null)
                {
                    admin.LoginErrorMsg = "Invalid UserName or Password";
                    return View("Index", admin);
                }
                else
                {
                    Session["userID"] = admin.UID;
                    
                    return RedirectToAction("Index", "Home");
                }

            }

        }
        public ActionResult LogOut()
        {
            
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }

    }
}
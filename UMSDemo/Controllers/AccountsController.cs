using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UMSDemo.Models;

namespace UMSDemo.Controllers
{
    public class AccountsController : Controller
    {
        public ActionResult Index()
        {
            UMSDbContext context = new UMSDbContext();
            List<Account> li = context.Accounts.ToList();
            return View(li);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Account account)
        {
            if (!ModelState.IsValid)
            {
                return View("Create");
            }
            UMSDbContext context = new UMSDbContext();
            context.Accounts.Add(account);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            UMSDbContext context = new UMSDbContext();
            Account accounts  = context.Accounts.Find(id);

            return View(accounts);

        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            UMSDbContext context = new UMSDbContext();
            Account accounts = context.Accounts.Find(id);
            context.Accounts.Remove(accounts);
            context.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}
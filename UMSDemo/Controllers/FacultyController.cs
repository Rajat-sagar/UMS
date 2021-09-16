using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UMSDemo.Models;

namespace UMSDemo.Controllers
{
    public class FacultyController : Controller
    {
        public ActionResult Index()
        {
            UMSDbContext context = new UMSDbContext();
            List<Faculty> li = context.Faculties.OrderBy(p => p.RegistrationNumber).ToList();
            return View(li);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Faculty faculty)
        {
            if(!ModelState.IsValid)
            {
                return View("Create");
            }
            UMSDbContext context = new UMSDbContext();
            context.Faculties.Add(faculty);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(string registrationNumber)
        {
            UMSDbContext context = new UMSDbContext();
            Faculty faculty = context.Faculties.Find(registrationNumber);

            return View(faculty);

        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(String registrationNumber)
        {
            UMSDbContext context = new UMSDbContext();
            Faculty faculty = context.Faculties.Find(registrationNumber);
            context.Faculties.Remove(faculty);
            context.SaveChanges();

            return RedirectToAction("Index");

        }


    }
}
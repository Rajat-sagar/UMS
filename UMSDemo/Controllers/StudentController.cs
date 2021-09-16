using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UMSDemo.Models;

namespace UMSDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            UMSDbContext context = new UMSDbContext();
            List<Student> li = context.Students.OrderBy(p => p.RegistrationNumber).ToList();
            return View(li);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View("Create");
            }
            UMSDbContext context = new UMSDbContext();
            context.Students.Add(student);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(string registrationNumber)
        {
           UMSDbContext context = new UMSDbContext();
            Student student = context.Students.Find(registrationNumber);

            return View(student);
            
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(String registrationNumber)
        {
            UMSDbContext context = new UMSDbContext();
            Student student = context.Students.Find(registrationNumber);
            context.Students.Remove(student);
            context.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}
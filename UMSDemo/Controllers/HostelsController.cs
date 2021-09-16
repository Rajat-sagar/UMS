using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UMSDemo.Models;

namespace UMSDemo.Controllers
{
    public class HostelsController : Controller
    {
        // GET: Hostels
        public ActionResult Index()
        {
            UMSDbContext context = new UMSDbContext();
            var list = context.Students.Include("Hostel1").ToList();
            return View(list);
            
        }
    }
}
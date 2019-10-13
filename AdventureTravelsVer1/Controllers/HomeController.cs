using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using AdventureTravelsVer1.Models;
using System.Net;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace AdventureTravelsVer1.Controllers
{
    public class HomeController : Controller
    {
        private AdventureTravelEntities db = new AdventureTravelEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult QuickNotes()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
} 

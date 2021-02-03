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

//this is the latest project
namespace AdventureTravelsVer1.Controllers
{
    [Authorize]
    [RequireHttps]
    public class HomeController : Controller
    {
        private AdventureTravelEntities db = new AdventureTravelEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us!";

            return View();
        }

        public ActionResult MyChart()
        {
            return View(db.Flights.ToList());
        }
        public ActionResult LocationMap()
        {
            ViewBag.Message = "Find your desination!";
            return View();
        }
    }
}


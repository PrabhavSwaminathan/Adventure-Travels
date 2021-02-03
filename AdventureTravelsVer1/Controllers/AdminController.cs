using AdventureTravelsVer1.Models;
using AdventureTravelsVer1.Utils;
using Microsoft.AspNet.Identity;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace AdventureTravelsVer1.Controllers
{
    [Authorize(Roles = "Admin")]
    [RequireHttps]
    public class AdminController : Controller
    {
        private AdventureTravelEntities db = new AdventureTravelEntities();
        // GET: Admin
        public ActionResult Index()
        {
            ViewBag.Message = "Admin page.";
            return View();
        }
        public ActionResult Send_Email()
        {
            return View(new SendEmailViewModel());
        }

        [HttpPost]
        public ActionResult Send_Email(SendEmailViewModel model)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    var message = new SendGridMessage();
                    String toEmail = model.ToEmail;
                    String subject = model.Subject;
                    String contents = model.Contents;


                    EmailSender es = new EmailSender();                                                                                                        

                    es.Send(toEmail, subject, contents);

                    ViewBag.Result = "Email has been sent!";

                    ModelState.Clear();

                    return View(new SendEmailViewModel());
                }
                catch
                {
                    return View();
                }
            }

            return View();
        }

        public ActionResult Bulk_Email()
        {
            return View(new BulkEmail());
        }

        [HttpPost]
        public ActionResult Bulk_Email(BulkEmail model)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    var message = new SendGridMessage();
                    String subject = model.Subject;
                    String contents = model.Contents;

                    EmailSender es = new EmailSender();
                    var users = db.AspNetUsers.ToList();
                    for (var i = 0; i < users.Count; i++)
                    {
                        es.Send(users[i].Email, subject, contents);
                    }
                    

                    ViewBag.Result = "Email has been sent!";

                    ModelState.Clear();

                    return View(new BulkEmail());
                }
                catch
                {
                    return View();
                }
            }

            return View();
        }
    }
}
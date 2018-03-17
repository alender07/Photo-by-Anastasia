using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhotoSiteByAnastasia.Models;
using ActionMailer.Net.Mvc;

namespace PhotoSiteByAnastasia.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult Service()
        {
            return View();
        }
        public ActionResult GalleryPartical1()
        {
            return PartialView();
        }

        public ActionResult Entry()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Entry(EmailModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    new EmailController().SendEmail(model).Deliver();

                    return RedirectToAction("Index");
                }
                catch (Exception)
                {
                    return RedirectToAction("Error");
                }
            }
            return View(model);
        }

        public ActionResult Success()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}
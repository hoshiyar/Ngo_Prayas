using Ngo.Prayas.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ngo.Prayas.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Home()
        {
            return View();
        }


        [HttpPost]

        public ActionResult PostVolunteerData(VolunteerApplicationVM volunteerApplication)
        {
            if(ModelState.IsValid)
            {
                return Json("success", JsonRequestBehavior.AllowGet);
            }
            return View("Home");
        }

        public ActionResult AboutUs()
        {
            return View();
        }
    }
}
using Ngo.Prayas.Repositories;
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
        private IAccountRepository _accountRepo;
        public DefaultController(AccountRepository accountRepo)
        {
            _accountRepo = accountRepo;
        }
        // GET: Default
        public ActionResult Home()
        {
            VolunteerApplicationVM volunteerApplication = new VolunteerApplicationVM();
            ViewBag.GenderList = LoadGenderDDl();
            return View(volunteerApplication);
        }


        [HttpPost]

        public ActionResult PostVolunteerData(VolunteerApplicationVM volunteerApplication)
        {
            if(ModelState.IsValid)
            {
                _accountRepo.AddVolunteer(volunteerApplication);
            }
            return View("Home");
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        private List<string> LoadGenderDDl()
        {
            List<string> categories = new List<string>();
            categories.Insert(0, "Male");
            categories.Insert(1, "Female");
            return categories;
        }
    }
}
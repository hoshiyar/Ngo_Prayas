using Ngo.Prayas.Repositories;
using Ngo.Prayas.ViewModels;
using Nog.Prayas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ngo.Prayas.Controllers
{
    public class ContactUsController : Controller
    {
        private IContactUsRepository _contactRepo;
        public ContactUsController(IContactUsRepository contactRepo)
        {
            _contactRepo = contactRepo;
        }
        // GET: ContactUs
        [HttpGet]
        public ActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ContactUs(ContactViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                ContactU contact = new ContactU()
                {
                    EmailId = model.EmailId,
                    Description = model.Description,
                    MobileNumber = model.MobileNumber,
                    Name = model.Name,
                    CreatedDate = DateTime.Now,
                    IsActive = true

                };
                _contactRepo.Create(contact);
            }
            catch(Exception ex)
            {

            }
            return View();
        }


        public ActionResult Contacts()
        {
            List<ContactViewModel> model = _contactRepo.GetAll().ToList();
            return View(model);
        }
    }
}
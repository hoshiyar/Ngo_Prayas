using Ngo.Prayas.Repositories;
using Ngo.Prayas.ViewModels;
using Nog.Prayas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Ngo.Prayas.Controllers
{
    public class AccountController : Controller
    {
        public AccountController()
        {

        }
        private IAccountRepository _accountRepo;
        public AccountController(IAccountRepository accountRepo)
        {
            _accountRepo = accountRepo;
        }

        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            User user = new User() { EmailId = model.EmailId, Password = model.Password };

            user = _accountRepo.ValidateLogin(user);

            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(model.EmailId, false);

                var authTicket = new FormsAuthenticationTicket(1, user.EmailId, DateTime.Now, DateTime.Now.AddMinutes(20), false, user.Role.RoleName);
                string encryptedTicket = FormsAuthentication.Encrypt(authTicket);
                var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                HttpContext.Response.Cookies.Add(authCookie);
                return RedirectToAction("Index", "Home");
            }

            else
            {
                ModelState.AddModelError("", "Invalid login attempt.");
                return View(model);
            }
        }


        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult Registration(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User() { EmailId = model.EmailId, Password = model.Password };

                if (_accountRepo.CreateUser(user))
                {
                    RedirectToAction("Login");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login attempt.");
                    return View(model);
                }

            }

            return View(model);

        }
    }
}
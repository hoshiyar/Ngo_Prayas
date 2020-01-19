using Ngo.Prayas.Models;
using Ngo.Prayas.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ngo.Prayas.Data;
using Ngo.Prayas.Repositories;

namespace Ngo.Prayas.Controllers
{
    public class EventsController : Controller
    {
        private IEventsRepository _eventRepo;

        public EventsController(IEventsRepository eventRepo)
        {
            _eventRepo = eventRepo;
        }
        // GET: Events
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Categories = GetCategories();
            return View();
        }

        [HttpPost]
        public ActionResult Create(EventViewModel model)
        {
            return View();
        }


        private List<EventCategory> GetCategories()
        {
            List<EventCategory> categories = new List<EventCategory>();
            //categories = _eventRepo.GetCategories().ToList();
            //categories.Insert(0, new EventCategory { CategoryId = 0, CategoryName = "Select" });
            return categories;
        }
    }
}
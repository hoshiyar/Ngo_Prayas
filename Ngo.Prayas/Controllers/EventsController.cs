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
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            string fileName = string.Empty;
            if (model.FileAttach.ContentLength > 0)
            {

                fileName = Guid.NewGuid() + "_" + System.IO.Path.GetFileName(model.FileAttach.FileName);
                string _path = System.IO.Path.Combine(Server.MapPath("~/UploadedFiles"), fileName);
                model.FileAttach.SaveAs(_path);
            }


            Nog.Prayas.Data.Event events = new Nog.Prayas.Data.Event
            {
                EventName = model.EventName,
                EventStartTime = model.EventStartTime,
                EventEndTime = model.EventEndTime,
                EventLocation = model.EventLocation,
                EventDescription = model.EventDescription,
                EventDate = model.EventDate,
                CategoryId = model.CategoryId
            };

            Nog.Prayas.Data.Event eventAdded = _eventRepo.Create(events);
            _eventRepo.SaveChanges();

            Nog.Prayas.Data.Event_Gallery eventGallery = new Nog.Prayas.Data.Event_Gallery
            {
                EventId = eventAdded.Id,
                ImageName = fileName,
                IsActive = true,
                IsBaseImage = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            _eventRepo.AddEventImages(eventGallery);
            _eventRepo.SaveChanges();

            return View();
        }


        private List<EventCategory> GetCategories()
        {
            List<EventCategory> categories = new List<EventCategory>();
            categories = _eventRepo.GetCategories().ToList();
            categories.Insert(0, new EventCategory { CategoryId = 0, CategoryName = "Select" });
            return categories;
        }
    }
}
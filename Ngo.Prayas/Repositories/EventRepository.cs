using Ngo.Prayas.Models;
using Nog.Prayas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ngo.Prayas.Repositories
{
    public class EventRepository : IEventsRepository
    {
        private Ngo_Prayas_DBEntities _dbContext;

        public EventRepository(Ngo_Prayas_DBEntities dbContext)
        {
            _dbContext = dbContext;
        }

        //IEnumerable<EventCategory> IEventsRepository.Categories { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IEnumerable<Event> GetCategories()
        {
            return _dbContext.Events.ToList();
        }

        public Event Create(Event eventModel)
        {
            eventModel.CreatedDate = DateTime.Now;
            var upcomingEvents = _dbContext.Events.Add(eventModel);

            return upcomingEvents;
        }

        public IEnumerable<Event> GetAllEvents()
        {
            return _dbContext.Events.ToList();
        }

        public Event GetEvents(int id)
        {
            Event eventModel = _dbContext.Events.Find(id);

            return eventModel;
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public void AddEventImages(Event_Gallery eventGallery)
        {
            _dbContext.Event_Gallery.Add(eventGallery);
        }
    }
}
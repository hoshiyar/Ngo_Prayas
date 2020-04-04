using Ngo.Prayas.Models;
using Ngo.Prayas.ViewModels;
using Nog.Prayas.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
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

        public IEnumerable<Models.EventCategory> GetCategories()
        {
            return _dbContext.EventCategories.Select(category => new Models.EventCategory()
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName
            }).ToList();
        }

        public Event Create(Event eventModel)
        {
            eventModel.CreatedDate = DateTime.Now;
            var upcomingEvents = _dbContext.Events.Add(eventModel);

            return upcomingEvents;
        }

        public IEnumerable<EventViewModel> GetAllEvents()
        {
            try
            {
                return _dbContext.Events.Select(m => new EventViewModel()
                {
                    CategoryId = m.CategoryId.Value,
                    EventDate = m.EventDate.ToString(),
                    EventDescription = m.EventDescription,
                    EventEndTime = m.EventEndTime,
                    EventLocation = m.EventLocation,
                    EventName = m.EventName,
                    EventStartTime = m.EventStartTime,
                    Id = m.Id,
                    ImageUrl = _dbContext.Event_Gallery.FirstOrDefault(e => e.IsActive == true && e.IsBaseImage.Value == true).ImageName.ToString(),
                    //EventCategories = _dbContext.EventCategories.Select(cat => new Models.EventCategory() {
                    //    CategoryName = cat.CategoryName
                    //    }).ToList(),

                
                }).ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
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

        public int InsertEventGallery(EventGalleryVM eventGalleryVM)
        {
            if(eventGalleryVM != null)
            {
                Event_GalleryDetail galleryDetail = new Event_GalleryDetail();
                galleryDetail.EventMessage = eventGalleryVM.GalleryDescription;
                galleryDetail.EventTitle = eventGalleryVM.GalleryName;
                galleryDetail.GalleryName = eventGalleryVM.GalleryName;
                galleryDetail.CreatedDate = DateTime.Now;
                Event_GalleryDetail addedGallery = _dbContext.Event_GalleryDetail.Add(galleryDetail);

                _dbContext.SaveChanges();
                return addedGallery.Id;
            }
            return 0;
        }

        public void InsertGalleryImages(EventGalleryVM eventGallery)
        {
            if(eventGallery != null)
            {
                Event_Gallery_Images event_Gallery = new Event_Gallery_Images();
                event_Gallery.GalleryImage = eventGallery.ImageName;
                event_Gallery.DetailGalleryId = eventGallery.Id;
                event_Gallery.CreatedDate = DateTime.Now;
                event_Gallery.IsThumbnail = true;

                _dbContext.Event_Gallery_Images.Add(event_Gallery);
            }
        }

        public IEnumerable<GalleryImageVM> GalleryList()
        {
            return _dbContext.Event_GalleryDetail.Select(m=> new GalleryImageVM()
            {
                Id = m.Id,
                Description = m.EventMessage,
                Title = m.EventTitle,
                ImageName = _dbContext.Event_Gallery_Images.FirstOrDefault().GalleryImage
            }).ToList();
        }
    }
}
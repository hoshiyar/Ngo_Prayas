using Ngo.Prayas.Models;
using Ngo.Prayas.ViewModels;
using Nog.Prayas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngo.Prayas.Repositories
{
    public interface IEventsRepository
    {
        Event Create(Event events);

        IEnumerable<EventViewModel> GetAllEvents();

        Event GetEvents(int id);

        void SaveChanges();

        IEnumerable<Models.EventCategory> GetCategories();

        void AddEventImages(Event_Gallery eventGallery);

        void InsertGalleryImages(EventGalleryVM eventGallery);

        int InsertEventGallery(EventGalleryVM eventGalleryVM);
    }
}

using Ngo.Prayas.Models;
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

        IEnumerable<Event> GetAllEvents();

        Event GetEvents(int id);

        void SaveChanges();

        IEnumerable<Models.EventCategory> GetCategories();

        void AddEventImages(Event_Gallery eventGallery);
    }
}

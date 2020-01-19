using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ngo.Prayas.Models;
using Ngo.Prayas.ViewModels;
using Nog.Prayas.Data;

namespace Ngo.Prayas.Repositories
{
    public class ContactUsRepository : IContactUsRepository
    {
        private Ngo_Prayas_DBEntities _dBEntities;

        public ContactUsRepository(Ngo_Prayas_DBEntities dBEntities)
        {
            _dBEntities = dBEntities;
        }
        public void Create(ContactU contactUs)
        {
            contactUs.CreatedDate = DateTime.Now;
            _dBEntities.ContactUs.Add(contactUs);
        }

        
        public IEnumerable<ContactViewModel> GetAll()
        {
            return _dBEntities.ContactUs.Select(x => new ContactViewModel()
            {
                Name = x.Name,
                Description = x.Description,
                EmailId = x.EmailId,
                MobileNumber = x.MobileNumber,
                IsActive = x.IsActive,
                Id = x.Id
            }).ToList();
        }

        public void GetContact(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _dBEntities.SaveChanges();
        }
    }
}
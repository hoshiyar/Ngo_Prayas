using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ngo.Prayas.Models;
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

        public IEnumerable<ContactU> GetAll()
        {
            return _dBEntities.ContactUs.ToList();
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
using Ngo.Prayas.ViewModels;
using Nog.Prayas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngo.Prayas.Repositories
{
    public interface IContactUsRepository
    {
        void Create(ContactU contactUs);

        IEnumerable<ContactViewModel> GetAll();

        void GetContact(int id);

        void SaveChanges();
    }
}

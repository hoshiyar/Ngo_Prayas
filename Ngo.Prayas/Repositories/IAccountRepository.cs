using Nog.Prayas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngo.Prayas.Repositories
{
    public interface IAccountRepository
    {
        User ValidateLogin(User user);

        bool CreateUser(User user);

        bool CheckDuplicateUser(string emailId);
    }
}

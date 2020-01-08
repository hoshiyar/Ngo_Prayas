﻿using Nog.Prayas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ngo.Prayas.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private Ngo_Prayas_DBEntities _dbContext;
        public AccountRepository(Ngo_Prayas_DBEntities dbContext)
        {
            _dbContext = dbContext;
        }
        public bool CheckDuplicateUser(string emailId)
        {
            if (!string.IsNullOrWhiteSpace(emailId))
            {
                return _dbContext.Users.Any(m => m.EmailId == emailId);
            }

            return false;
        }

        public bool CreateUser(User userModel)
        {
            Role role = _dbContext.Roles.FirstOrDefault(m => m.RoleName == "SubAdmin");
            bool isSuccess = true;
            try
            {
                userModel.CreatedDate = DateTime.Now;
                userModel.IsActive = false;
                userModel.Role = role;
                _dbContext.Users.Add(userModel);
                _dbContext.SaveChanges();
                return isSuccess ;
            }
            catch(Exception ex)
            {
                isSuccess = false;
            }
            return isSuccess;
        }

        public User ValidateLogin(User userModel)
        {
            User loginUser = _dbContext.Users.FirstOrDefault(m => m.EmailId == userModel.EmailId && m.Password == userModel.Password);

            if (loginUser != null)
            {
                return loginUser;
            }

            return null;
        }
    }
}
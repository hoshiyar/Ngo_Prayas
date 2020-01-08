using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ngo.Prayas.Models
{
    public class User
    {
        public int Id { get; set; }

        public string EmailId { get; set; }
        public string Password { get; set; }

        public bool IsActive { get; set; }

        public int CreatedDate { get; set; }
    }
}
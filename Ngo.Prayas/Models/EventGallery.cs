using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ngo.Prayas.Models
{
    public class EventGallery
    {
        public int Id { get; set; }

        public string ImageName { get; set; }

        public int EventId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set;
        }
    }
}
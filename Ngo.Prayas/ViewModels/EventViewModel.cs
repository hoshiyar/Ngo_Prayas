using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ngo.Prayas.ViewModels
{
    public class EventViewModel
    {
        public int Id { get; set; }
        public string EventName { get; set; }

        public string EventDescription { get; set; }

        public DateTime EventDate { get; set; }

        public string EventStartTime { get; set; }

        public string EventEndTime { get; set; }


        public string EventLocation { get; set; }

        // public IFormFile Photo { get; set; }

        [Required]
        [Display(Name = "Upload File")]
        public HttpPostedFileBase FileAttach { get; set; }

        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }

        //    public List<EventCategory> Categories { get; set; }


        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool IsActive { get; set; }
    }
}
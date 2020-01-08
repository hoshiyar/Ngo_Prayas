using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ngo.Prayas.Models
{
    public class UpcomingEvents
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string EventName { get; set; }
        [Required]
        public string EventDescription { get; set; }

        [Required]
        public DateTime EventDate { get; set; }
        [Required]
        public string EventStartTime { get; set; }

        [Required]
        public string EventEndTime { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        [Required]
        public bool IsActive { get; set; }

        public int NoOfClicks { get; set; }

        [Required]
        public string EventLocation { get; set; }

        [Required]
        public string ImagePath { get; set; }

        public int CategoryId { get; set; }

        public EventCategory Category { get; set; }
    }
}
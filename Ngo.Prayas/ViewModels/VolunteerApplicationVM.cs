using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ngo.Prayas.ViewModels
{
    public class VolunteerApplicationVM
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string MessageDescription { get; set; }
    }
}
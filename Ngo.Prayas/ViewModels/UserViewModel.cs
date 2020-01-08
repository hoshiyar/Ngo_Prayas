﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ngo.Prayas.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        [Required]
        public string EmailId { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string ConfirmPassword { get; set; }
    }
}
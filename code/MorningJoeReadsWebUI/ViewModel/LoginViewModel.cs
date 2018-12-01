﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MorningJoeReadsWebUI.Models;

namespace MorningJoeReadsWebUI.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20)]
        public string LastName { get; set; }
        [EmailAddress]
        [Required]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            ErrorMessage = "Must be a valid Email Address")]
        public string EmailAddress { get; set; }
        [Required]
        public string PassWord { get; set; }
    }
    
}
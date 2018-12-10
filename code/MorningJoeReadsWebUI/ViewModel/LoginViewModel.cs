﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MorningJoeReadsWebUI.ViewModel
{
    public class LoginViewModel 
    {
        
        [Required(ErrorMessage = "Email Address is required")]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string PassWord { get; set; }

        public string LoginErrorMessage { get; set; }
    } 
}
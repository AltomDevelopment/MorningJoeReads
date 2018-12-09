using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace MorningJoeReadsWebUI.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Please enter your first name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Please enter your last name")]
        public string LastName { get; set; }
        [EmailAddress]
        [Required]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", 
        ErrorMessage = "Must be a valid Email Address")]
        public string EmailAddress { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string PassWord { get; set; }
        
       
    }
}
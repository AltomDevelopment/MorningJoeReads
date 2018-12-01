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

        public Search Searches { get; set; }
       
    }
}
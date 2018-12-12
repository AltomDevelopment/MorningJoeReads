using MorningJoeReadsWebUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MorningJoeReadsWebUI.ViewModel
{
    public class NewSearchViewModel
    {
        [Required(ErrorMessage = "You must enter the Search Description")]
        [Display(Name = "Search Description")]
        public string SearchDescription { get; set; }

        [Required(ErrorMessage = "You must give your search a name")]
        [Display(Name = "Search Name")]
        public string SearchName { get; set; }

        public string SearchErrorMessage { get; set; }
    }
}
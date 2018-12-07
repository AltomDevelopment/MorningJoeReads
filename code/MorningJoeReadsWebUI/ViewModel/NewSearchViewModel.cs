using MorningJoeReadsWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MorningJoeReadsWebUI.ViewModel
{
    public class NewSearchViewModel
    {
        public string SearchDescription { get; set; }
        public string SearchName { get; set; }
        public List<Search> Searches = new List<Search>();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace MorningJoeReadsWebUI.Models
{
    public class Search
    {
        public int Id { get; set; }
        public string SearchDescription { get; set; }
        public string SearchName { get; set; }
        public DateTime DateCreated { get; set; }
        public int TimesViewed { get; set; }
        public User Users { get; set; }
        
    }
}
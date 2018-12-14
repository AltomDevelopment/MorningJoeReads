using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MorningJoeReadsWebUI.Models
{
    public class Buttons
    {
        public int ID { get; set; }
        public List<Search> Searches { get; set; }
        public User User { get; set; }
    }
}
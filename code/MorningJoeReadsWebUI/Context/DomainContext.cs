using MorningJoeReadsWebUI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MorningJoeReadsWebUI.Context
{
    public class DomainContext : DbContext
    {
        public DomainContext() : base("MorningJoeDb")
        {

        } 

        public DbSet<User> Users { get; set; }
        public DbSet<Search> Searches { get; set; }
    }
}
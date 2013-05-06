using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DemoNinjectWebAPI.Contracts;

namespace DemoNinjectWebAPI.Models
{
    public class MainContext : DbContext
    {
        public MainContext()
            : base("name=DefaultConnection")
        {
            
        }

        public DbSet<Pais> Paises { get; set; }
    }
}
using App_master.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_master.Data
{
   public class DataContext:DbContext
    {
        public DataContext():base("db")
        {}

        public DbSet<WhatsNew> WhatsNews  { get; set; }
        public DbSet<Geared> Geareds { get; set; }
        public DbSet<Structured> Structureds { get; set; }

        public DbSet<Banner> Banners { get; set; }
    }
}

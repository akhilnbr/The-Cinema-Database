using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using The_Cinema_Bucket.Models;

namespace The_Cinema_Bucket
{
    public class DbModel : DbContext
    {
        public DbModel() : base("DefaultConnection")
        {

        }

        public DbSet<Actors> actor { get; set; }
        public DbSet<Producers> producer { get; set; }
        public DbSet<movie> movies { get; set; }

    }
}
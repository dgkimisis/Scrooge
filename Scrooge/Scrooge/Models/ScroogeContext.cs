using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Scrooge.Models
{
    public partial class ScroogeContext : DbContext
    {
        public ScroogeContext() : base("name=ScroogeContext") { }

        public virtual DbSet <Categories> Categories { get; set; }
        public virtual DbSet <Prices> Prices { get; set; }
        public virtual DbSet <Products> Products { get; set; }
        public virtual DbSet <Sellers> Sellers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirstWebApp.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FirstWebApp.Data
{
    public class ContextApp : DbContext
    {
        public ContextApp()
            : base("DefaultConnection")
        {

        }

        public virtual DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder); 
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties()
                .Where(p => p.Name == "Id")
                .Configure(p => p.IsKey());

        }

    }
}

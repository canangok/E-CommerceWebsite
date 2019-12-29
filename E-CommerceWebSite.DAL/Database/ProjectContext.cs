using E_CommerceWebSite.DAL.Mapping;
using E_CommerceWebSite.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceWebSite.DAL.Database
{
    public class ProjectContext : DbContext
    {
        public ProjectContext() : base("defaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMappings());
            modelBuilder.Configurations.Add(new ProductMappings());


            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}

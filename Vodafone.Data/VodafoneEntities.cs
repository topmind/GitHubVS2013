using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vodafone.Data.Configuration;
using Vodafone.Model.Models;

namespace Vodafone.Data
{
    public class VodafoneEntities : DbContext
    {
        public VodafoneEntities() : base("VodafoneEntities") { }

        public DbSet<Category> Categories { get; set; }

        public DbSet<SubCategory> SubCategories { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SubCategoryConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vodafone.Model.Models;

namespace Vodafone.Data.Configuration
{
    public class SubCategoryConfiguration : EntityTypeConfiguration<SubCategory>
    {
        public SubCategoryConfiguration()
        {
            ToTable("SubCategories");
            Property(s => s.Name).IsRequired().HasMaxLength(50);
            Property(s => s.CategoryID).IsRequired();
        }
    }
}

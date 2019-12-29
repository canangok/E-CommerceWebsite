using E_CommerceWebSite.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceWebSite.DAL.Mapping
{
    public class CategoryMappings : EntityTypeConfiguration<Category>
    {
        public CategoryMappings()
        {
            ToTable("Categories","eCommerce");
        }
    }
}

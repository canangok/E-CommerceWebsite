using E_CommerceWebSite.Entities;
using System.Data.Entity.ModelConfiguration;

namespace E_CommerceWebSite.DAL.Mapping
{
    public class ProductMappings : EntityTypeConfiguration<Product>
    {
        public ProductMappings()
        {
            ToTable("Products", "eCommerce");
        }
    }
}

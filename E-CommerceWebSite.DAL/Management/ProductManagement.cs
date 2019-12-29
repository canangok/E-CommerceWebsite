using E_CommerceWebSite.DAL.Database;
using E_CommerceWebSite.Entities;
using System.Collections.Generic;
using System.Linq;

namespace E_CommerceWebSite.DAL.Management
{
    public class ProductManagement
    {
        private ProjectContext database;

        public ProductManagement()
        {
            database = new ProjectContext();
        }

        public List<Product> GetAllProducts()
        {
            var products = database.Product.Include("Category").ToList(); 

            return products;
        }
    }
}

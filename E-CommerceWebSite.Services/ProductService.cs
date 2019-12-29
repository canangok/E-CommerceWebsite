using E_CommerceWebSite.DAL.Management;
using E_CommerceWebSite.Entities;
using System.Collections.Generic;

namespace E_CommerceWebSite.Services
{
    public class ProductService
    {
        private ProductManagement productManagement;

        public ProductService()
        {
            productManagement = new ProductManagement();
        }

        public List<Product> GetProducts() => productManagement.GetAllProducts();

    }
}

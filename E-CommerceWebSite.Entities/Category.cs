using System.Collections.Generic;

namespace E_CommerceWebSite.Entities
{
    public class Category
    {
        public Category()
        {
            Products = new List<Product>(); //POCO 
        }
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}

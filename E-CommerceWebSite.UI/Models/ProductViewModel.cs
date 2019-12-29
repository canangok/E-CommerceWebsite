using E_CommerceWebSite.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_CommerceWebSite.UI.Models
{
    public class ProductViewModel
    {
        public string ProductName { get; set; }
        public string ProductDescriptin { get; set; }
        public double ProductPrice { get; set; }
        public string ProductImage { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
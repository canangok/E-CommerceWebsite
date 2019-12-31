using E_CommerceWebSite.DAL.Management;
using E_CommerceWebSite.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceWebSite.Services
{
    public class CategoryService
    {
        private CategoryManagement categoryManagement;

        public CategoryService()
        {
            categoryManagement = new CategoryManagement();
        }

        //public List<Category> GetCategories()
        //{
        //    var categories = categoryManagement.GetAllCategories();
        //    return categories;
        //}

        public List<Category> GetCategories() => categoryManagement.GetAllCategories();
        public List<Category> GetTopCategories() => categoryManagement.GetAllCategories().Take(4).ToList();

        public Category Add(Category category) => categoryManagement.AddCategory(category);

    }
}

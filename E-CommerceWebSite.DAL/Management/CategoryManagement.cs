using E_CommerceWebSite.DAL.Database;
using E_CommerceWebSite.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceWebSite.DAL.Management
{
    public class CategoryManagement
    {
        private ProjectContext database;

        public CategoryManagement()
        {
            database = new ProjectContext();

        }

        public List<Category> GetAllCategories()
        {
            var categories = database.Category.ToList();

            return categories;
        }

        public Category AddCategory(Category category)
        {
            category = database.Category.Add(category);
            database.SaveChanges();
            return category;
        }

    }
}

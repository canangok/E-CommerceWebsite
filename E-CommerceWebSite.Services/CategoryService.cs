using E_CommerceWebSite.DAL.Management;
using E_CommerceWebSite.Entities;
using E_CommerceWebSite.Entities.DTO;
using E_CommerceWebSite.Helper.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;


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

        //public List<Category> GetCategories() => categoryManagement.GetAllCategories();
            
        public List<CategoryDTO> GetCategoryDTOs()
        {
            var categories = categoryManagement.GetAllCategories();
            var categoriesDTO = categories.GetCategoryDtos();

            return categoriesDTO;
        }



        public List<Category> GetTopCategories() => categoryManagement.GetAllCategories().Take(4).ToList();

        public Category Add(Category category) => categoryManagement.AddCategory(category);

        //public Category GetCategoryDTO(int id) => categoryManagement.FirstCategory(id);

        public CategoryDTO GetCategoryDto(int id)
        {
            var category = categoryManagement.FirstCategory(id);
            var categoryDTO = category.GetCategryDto(); //extensiondan geliyor
            return categoryDTO;
        }
    }
}

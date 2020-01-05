using E_CommerceWebSite.Entities;
using E_CommerceWebSite.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceWebSite.Helper.Extensions
{
    public static class CategoryExtension
    {
        public static CategoryDTO GetCategryDto(this Category category)
        {
            var categoryDTO = new CategoryDTO();
            categoryDTO.Name = category.CategoryName;
            return categoryDTO;
        }

        public static List<CategoryDTO> GetCategoryDtos(this List<Category> categories)
        {
            var categoryDtos = categories.Select(i => new CategoryDTO
            {
                Name = i.CategoryName
            }).ToList();

            return categoryDtos;
        }
    }

    
}

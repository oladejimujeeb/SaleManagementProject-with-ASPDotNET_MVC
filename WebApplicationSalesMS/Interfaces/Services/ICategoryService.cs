using WebApplicationSalesMS.DTOs.CategoryDto;
using WebApplicationSalesMS.Entities;

namespace WebApplicationSalesMS.Interfaces.Services
{
    public interface ICategoryService
    {
        CategoryResponseModel AddCategory(CreateCategoryRequest request);
        
        CategoriesResponseModel GetAllCategories();
        CategoryResponseModel GetCategory(int id);
        bool DeleteCategory(int id);
        CategoryResponseModel UpdateCategory(CategoryDto updateCategoryRequest, int id);
    }
}
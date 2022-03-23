using System.Collections;
using System.Collections.Generic;
using WebApplicationSalesMS.Entities;

namespace WebApplicationSalesMS.Interfaces.Repositories
{
    public interface ICategoryRepository
    {
        Category CreateCategory(Category category);
        bool DeleteCategory(Category category);
        Category EditCategory(Category category);
        Category GetCategory(int id);
        IList<Category> GetCategoriesByIds(IList<int> ids);
       IList<Category>GetAllCategories();
       bool CategoryExit(string name);
    }
}
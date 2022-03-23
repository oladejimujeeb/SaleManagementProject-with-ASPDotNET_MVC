using System.Collections.Generic;
using System.Linq;
using WebApplicationSalesMS.Entities;
using WebApplicationSalesMS.Interfaces.Repositories;
using WebApplicationSalesMS.Context;
using WebApplicationSalesMS.DTOs.CategoryDto;

namespace WebApplicationSalesMS.Implementations.Repositories
{
   
    public class CategoryRepository:ICategoryRepository
    {
        private readonly ApplicationContext _context;

        public CategoryRepository(ApplicationContext context)
        {
            _context = context;
        }
        public Category CreateCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }

        public bool DeleteCategory(Category category)
        {
           //var category =  _context.Categories.Find(id);
           _context.Remove(category);
           _context.SaveChanges();
           return true;
        }

        public Category EditCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return category;
        }

        public Category GetCategory(int id)
        {
            var category = _context.Categories.Find(id);
            return category;

        }
        public IList<Category> GetAllCategories()
        {
           return _context.Categories.ToList();
        }

        public bool CategoryExit(string name)
        {
            return _context.Categories.Any(x => x.Name == name);
        }

        public IList<Category> GetCategoriesByIds(IList<int> ids)
        {
            var item = _context.Categories.Where(x=> ids.Contains(x.Id) ).ToList();
            return item;
        }
    }
}
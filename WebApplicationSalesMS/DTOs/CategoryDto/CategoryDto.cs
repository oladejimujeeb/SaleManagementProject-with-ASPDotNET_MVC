using System.Collections.Generic;
using WebApplicationSalesMS.Entities;

namespace WebApplicationSalesMS.DTOs.CategoryDto
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<CategoryItem> CategoryItems { get; set; } = new List<CategoryItem>();
    }
}
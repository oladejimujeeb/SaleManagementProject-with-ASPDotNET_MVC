using System.Collections.Generic;
using WebApplicationSalesMS.Entities;

namespace WebApplicationSalesMS.DTOs.CategoryDto
{
    public class CreateCategoryRequest
    {
        public string Name { get; set; }
        public  string Description { get; set; }
    }
}
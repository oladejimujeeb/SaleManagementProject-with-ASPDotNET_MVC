using System.Collections.Generic;
namespace WebApplicationSalesMS.Entities
{
    public class Category
    {
        public  int Id { get; set; }
        public  string Name { get; set; }
        public  string Description { get; set; }
        public IList<CategoryItem> CategoryItems  { get; set; } = new List<CategoryItem>();
    }
}
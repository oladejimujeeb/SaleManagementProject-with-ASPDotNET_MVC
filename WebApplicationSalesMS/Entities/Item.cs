using System.Collections.Generic;

namespace WebApplicationSalesMS.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image{ get; set; }
        public IList<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public IList<CategoryItem> CategoryItems  { get; set; } = new List<CategoryItem>();
    }
}
using System.Collections.Generic;
using WebApplicationSalesMS.Entities;

namespace WebApplicationSalesMS.DTOs.ItemDto
{
    public class ItemDto
    {
        public int  Id{ get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price{ get; set; }
        public  string Image { get; set; }
        //public IList<int> CategInts { get; set; }
        public IList<CategoryItem> CategoryItems { get; set; } = new List<CategoryItem>();
        public IList<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        
    }
}
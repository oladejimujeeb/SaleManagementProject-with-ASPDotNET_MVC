namespace WebApplicationSalesMS.Entities
{
    public class CategoryItem
    {
        public  int Id { get; set; }
        public int CategoryId{ get; set; }
        public int ItemId{ get; set; }
        public Category Category { get; set; }
        public Item Item { get; set; }
    }
}
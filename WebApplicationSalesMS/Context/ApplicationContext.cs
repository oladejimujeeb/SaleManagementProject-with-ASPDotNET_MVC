using Microsoft.EntityFrameworkCore;
using WebApplicationSalesMS.Entities;
namespace WebApplicationSalesMS.Context
{
    public class ApplicationContext:DbContext
    {
        public DbSet<Category>Categories { get; set; }
        public DbSet<Customer>Customers { get; set; }
        public DbSet<Order>Orders { get; set; }
        public DbSet<Item>Items { get; set; }
        public DbSet<CategoryItem>CategoryItems { get; set; }
        public DbSet<OrderItem>OrderItems { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            
        }
    }
}
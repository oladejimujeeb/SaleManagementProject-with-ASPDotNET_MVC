using System.Collections;
using System.Collections.Generic;

namespace WebApplicationSalesMS.Entities
{
    public class Customer
    {
        public  int Id { get; set; }
        public  string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public IList<Order> Orders { get; set; } = new List<Order>();
    }
}
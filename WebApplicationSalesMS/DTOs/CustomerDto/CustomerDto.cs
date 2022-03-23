using System.Collections.Generic;
using WebApplicationSalesMS.Entities;

namespace WebApplicationSalesMS.DTOs.CustomerDto
{
    public class CustomerDto
    {
        public int Id{ get; set; }
        public string FullName{ get; set; }
        public string Phone{ get; set; }
        public string Email{ get; set; }
        public IList<Order> Orders { get; set; } = new List<Order>();
    }
}
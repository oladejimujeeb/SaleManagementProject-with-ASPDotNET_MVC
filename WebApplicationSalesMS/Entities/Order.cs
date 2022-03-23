using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace WebApplicationSalesMS.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId{ get; set; }
        public DateTime Date { get; set; }
        public string Reference { get; set; }
        public Customer Customer { get; set; }
        public IList<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
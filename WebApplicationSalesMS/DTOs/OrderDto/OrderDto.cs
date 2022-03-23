using System;
using System.Collections.Generic;
using WebApplicationSalesMS.Entities;

namespace WebApplicationSalesMS.DTOs.OrderDto
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public string Refernce { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public IList<OrderItem> OrderItems { get; set; } = new List<OrderItem>();


    }
}
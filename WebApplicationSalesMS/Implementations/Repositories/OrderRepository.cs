using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WebApplicationSalesMS.Context;
using WebApplicationSalesMS.Entities;
using WebApplicationSalesMS.Interfaces.Repositories;

namespace WebApplicationSalesMS.Implementations.Repositories
{
    public class OrderRepository:IOrderRepository
    {
        private readonly ApplicationContext _context;

        public OrderRepository(ApplicationContext context)
        {
            _context = context;
        }
        public Order AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
            return order;
        }

        public Order EditOrder(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
            return order;
        }

        public IList<Order> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        public Order GetOrder(int id)
        {
            var order = _context.Orders.Find(id);
            return order;
        }

        public IList<Order> GetOrdersByCustomer(int id)
        {
           var orders =  _context.Orders.Where(x => x.CustomerId == id).ToList();
           return orders;
        }
    }
}
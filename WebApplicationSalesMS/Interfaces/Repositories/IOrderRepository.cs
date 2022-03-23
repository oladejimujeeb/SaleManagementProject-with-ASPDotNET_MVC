using System.Collections.Generic;
using WebApplicationSalesMS.Entities;

namespace WebApplicationSalesMS.Interfaces.Repositories
{
    public interface IOrderRepository
    {
        Order AddOrder(Order order);
        Order EditOrder(Order order);
        IList<Order> GetAllOrders();
        Order GetOrder(int id);
        IList<Order> GetOrdersByCustomer(int id);
    }
}
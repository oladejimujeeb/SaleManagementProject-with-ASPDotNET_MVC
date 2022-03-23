using System.Collections;
using System.Collections.Generic;
using WebApplicationSalesMS.Entities;

namespace WebApplicationSalesMS.Interfaces.Repositories
{
    public interface ICustomerRepository
    {
        Customer AddCustomer (Customer customer);
        bool DeleteCustomer(int id);
        Customer UpdateCustomer(Customer customer);
        IList<Customer> GetAllCustomers();
        Customer GetCustomer(int id);
    }
}
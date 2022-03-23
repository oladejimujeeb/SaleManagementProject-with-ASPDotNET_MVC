using System.Collections.Generic;
using System.Linq;
using WebApplicationSalesMS.Context;
using WebApplicationSalesMS.Entities;
using WebApplicationSalesMS.Interfaces.Repositories;

namespace WebApplicationSalesMS.Implementations.Repositories
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly ApplicationContext _context;

        public CustomerRepository(ApplicationContext context)
        {
            _context = context;
        }
        public Customer AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }

        public bool DeleteCustomer(int id)
        {
           var customer =  _context.Customers.Find(id);
           _context.Customers.Remove(customer);
           _context.SaveChanges();
           return true;
        }

        public Customer UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
            return customer;
        }

        public IList<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public Customer GetCustomer(int id)
        {
            var customer = _context.Customers.Find(id);
            return customer;

        }
    }
}
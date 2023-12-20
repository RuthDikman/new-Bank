using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class CustomersRepository:ICustomerRepositories
    {
        private readonly DataContext _context;

        public CustomersRepository(DataContext context)
        {
            _context = context;
        }
        public Customer AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            return customer;
        }

        public void DeleteCustomer(int id)
        {
            var temp = _context.Customers.Find(x => x.Id ==id);
            _context.Customers.Remove(temp);
        }

        public List<Customer> GetCustomers()
        {
            return _context.Customers;
        }

        public Customer GetByTz(string tz)
        {
            return _context.Customers.Find(x => x.Tz == tz);
        }

        public Customer UpdateCustomer(int id, Customer customer)
        {
            var temp = _context.Customers.Find(u => u.Id == id);
            temp.Id = customer.Id;
            temp.Name = customer.Name;
            temp.Tz = customer.Tz;
            return temp;
        }
    }
}

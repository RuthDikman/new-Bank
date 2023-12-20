﻿using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface ICustomerRepositories
    {
        List<Customer> GetCustomers();

        Customer GetByTz(string tz);

        Customer AddCustomer(Customer cust);

        Customer UpdateCustomer(int id, Customer cust);

        void DeleteCustomer(int id);
    }
}

﻿using PointOfSales.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PointOfSales.Domain.Repositories
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();
        Customer Add(Customer customer);
        IEnumerable<Customer> GetByName(string search);
        Customer GetById(int id);
        bool Update(Customer customer);
    }
}

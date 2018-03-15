using C4u.Library.Interface;
using C4u.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace C4u.Data.Repositories
{
    public class CustomerRepository:IRepository<Customer>
    {
        private readonly C4uDbContext _dbContext;

        public CustomerRepository(C4uDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Customer> GetAll()
        {
            var getallcutomer = _dbContext.CustomerList;
            return getallcutomer;
        }
    }
}

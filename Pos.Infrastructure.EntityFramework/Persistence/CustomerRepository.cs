using System;
using System.Linq;
using System.Collections.Generic;
using Pos.Infrastructure.EntityFramework.Model;

namespace Pos.EntityFramework.Persistence
{
    public class CustomerRepository : IBaseRepository<Customer>
    {
        PosEntities context = new PosEntities();
        public IEnumerable<Customer> GetAll()
        {
            var result = context.Customers.ToList();
            return result;
        }
    }
}

using Pos.Application.Interfaces;
using Pos.EntityFramework.Persistence;
using Pos.Infrastructure.EntityFramework.Model;
using System.Collections.Generic;

namespace Pos.Application.Implementations
{
    public class CustomerQueryService : ICustomerQueryService
    {
        private readonly CustomerRepository repository;
        public CustomerQueryService()
        {
            repository = new CustomerRepository();
        }
        public IEnumerable<Customer> GetCustomers()
        {
            return repository.GetAll();
        }
    }
}

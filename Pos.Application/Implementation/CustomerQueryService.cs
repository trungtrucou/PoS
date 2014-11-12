using Pos.Application.Contract;
using Pos.Application.Dto;
using Pos.Infrastructure.EntityFramework.Persistence;
using System.Collections.Generic;

namespace Pos.Application.Implementation
{
    class CustomerQueryService : ICustomerQueryService
    {   
        public IEnumerable<Customer> GetCustomers()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                var result = unitOfWork.CustomerRepository.GetAll();
                return result;
            }
        }

        public Customer GetCustomerById(int customerId)
        {
            throw new System.NotImplementedException();
        }
    }
}

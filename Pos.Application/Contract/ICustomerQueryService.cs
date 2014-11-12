using Pos.Application.Dto;
using System.Collections.Generic;

namespace Pos.Application.Contract
{
    public interface ICustomerQueryService
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomerById(int customerId);
    }
}

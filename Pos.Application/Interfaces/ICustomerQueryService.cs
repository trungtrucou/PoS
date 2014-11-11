using Pos.Infrastructure.EntityFramework.Model;
using System.Collections.Generic;

namespace Pos.Application.Interfaces
{
    public interface ICustomerQueryService
    {
        IEnumerable<Customer> GetCustomers();
    }
}

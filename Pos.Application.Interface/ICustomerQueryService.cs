using Pos.EntityFramework.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Application.Interface
{
    public interface ICustomerQueryService
    {
        IEnumerable<Customer> GetCustomers();
    }
}

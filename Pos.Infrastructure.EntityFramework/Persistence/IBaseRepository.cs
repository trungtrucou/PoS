using System.Collections.Generic;

namespace Pos.EntityFramework.Persistence
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> GetAll();

    }
}

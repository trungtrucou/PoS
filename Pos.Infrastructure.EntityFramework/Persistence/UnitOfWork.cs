using Pos.Infrastructure.EntityFramework.Model;
using System;

namespace Pos.Infrastructure.EntityFramework.Persistence
{
    public class UnitOfWork : IDisposable
    {
        // Declare concrete repository
        private GenericRepository<Customers> _customerRepository;
        public GenericRepository<Customers> CustomerRepository
        {
            get
            {
                if (_customerRepository == null) 
                    _customerRepository = new GenericRepository<Customers>(Context);
                return _customerRepository;
            }
        }


        #region Unit of work infrastructure
        private readonly POS_Context Context;

        public UnitOfWork()
        {
            Context = new POS_Context();
        }

        public void Commit()
        {
            Context.SaveChanges();
        }


        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}

using Pos.Infrastructure.EntityFramework.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Pos.Infrastructure.EntityFramework.Persistence
{
    public class GenericRepository<T> where T : class
    {
        private POS_Context context;
        private DbSet<T> dbSet;

        public GenericRepository(POS_Context context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        public virtual IEnumerable<T> GetAll()
        {
            IQueryable<T> result = dbSet;
            return result.ToList();
        }

        public virtual T GetById(object id)
        {
            var result = dbSet.Find(id);
            return result;
        }

        public virtual void Insert(T entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Delete(T entity)
        {
            if (context.Entry(entity).State == EntityState.Deleted)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
        }

        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}

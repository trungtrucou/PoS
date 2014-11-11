using Pos.EntityFramework.DataModel;
using System.Data.Entity;

namespace Pos.EntityFramework.DataContext
{
    public class PosDataContext : DbContext
    {
        public PosDataContext()
            : base("PosDbContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer(new DropCreateDatabaseAlways<PosDataContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
    }
}

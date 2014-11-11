namespace Pos.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Pos.EntityFramework.DataContext.PosDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Pos.EntityFramework.DataContext.PosDataContext context)
        {
            context.Employees.Add(new DataModel.Employee()
            {
                FirstName = "Nguyễn",
                LastName = "Thiện Nhân",
                HireDate = DateTime.Now,
                Address = "Bình Định",
                City = "Bình Định",
                Phone = "123456"
            });

            context.Employees.Add(new DataModel.Employee()
            {
                FirstName = "Cẩm Thị",
                LastName = "Ly",
                HireDate = DateTime.Now,
                Phone = "123456",
                City = "Ho Chi Minh city"
            });

            context.SaveChanges();

            context.Customers.Add(new DataModel.Customer()
            {
                CustomerCode = Guid.NewGuid().ToString(),
                FirstMidName = "Nguyễn",
                LastName = "Trung Trực",
                Email = "trungtrucou@gmail.com",
                Gender = true,
                CreditNumber = Guid.NewGuid().ToString(),
                Address = "Dương Minh Châu - Tây Ninh",
                TaxId = Guid.NewGuid().ToString(),
                Phone = "113121412"
            });

            context.Customers.Add(new DataModel.Customer()
            {
                CustomerCode = Guid.NewGuid().ToString(),
                FirstMidName = "Nguyễn",
                LastName = "Trung Hoà",
                Email = "hoa_nguyen@gmail.com",
                CreditNumber = Guid.NewGuid().ToString(),
                Address = "Dương Minh Châu - Tây Ninh",
                TaxId = Guid.NewGuid().ToString(),
                Phone = "13141231"
            });

            context.SaveChanges();
        }
    }
}

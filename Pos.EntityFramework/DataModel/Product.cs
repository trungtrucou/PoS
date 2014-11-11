using System;

namespace Pos.EntityFramework.DataModel
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime DistributedDate { get; set; }
        public int ProductTypeId { get; set; }
        public virtual ProductType ProductType { get; set; }
        public int OrderDetailId { get; set; }
        public virtual OrderDetail OrderDetail { get; set; }
    }
}

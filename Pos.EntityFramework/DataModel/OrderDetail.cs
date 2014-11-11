using System.Collections.Generic;
namespace Pos.EntityFramework.DataModel
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}

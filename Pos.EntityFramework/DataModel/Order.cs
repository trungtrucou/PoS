using System;
using System.Collections.Generic;

namespace Pos.EntityFramework.DataModel
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsShipped { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetailItems { get; set; }
    }
}
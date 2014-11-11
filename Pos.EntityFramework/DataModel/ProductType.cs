using System.Collections.Generic;

namespace Pos.EntityFramework.DataModel
{
    public class ProductType
    {
        public int Id { get; set; }
        public string TypeDescription { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}

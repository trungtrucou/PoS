using System.Collections.Generic;

namespace Pos.EntityFramework.DataModel
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerCode { get; set; }
        public string FirstMidName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public string TaxId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CreditNumber { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}

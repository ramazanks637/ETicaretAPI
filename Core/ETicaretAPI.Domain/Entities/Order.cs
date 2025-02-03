using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; } 
        public string Description { get; set; }
        public string Address { get; set; }

        public ICollection<Product> Products { get; set; } // çoka çok bir ilişki olduğu için ICollection olarak tanımladık.
        public Customer Customer { get; set; }  // bir siparişin bir müşterisi olacağı için tek bir müşteri olacağı için Customer olarak tanımladık.
    }
}

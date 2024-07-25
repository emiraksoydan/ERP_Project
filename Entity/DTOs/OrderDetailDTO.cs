using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class OrderDetailDTO : IDTO
    {
        public Guid OrderDetailID { get; set; }
        public Guid ProductID { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public decimal ToplamFiyat { get { return Product.Sale * Amount; } }
        public Guid OrderID { get; set; }
        public Order Order { get; set; }
    }
}

using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Order : IEntity
    {
        public Guid OrderID { get; set; };
        public DateTime OrderDate { get; set; }
        public DateTime? GetOrderDate { get; set; }
        public Guid UserID { get; set; }
        public User User { get; set; }
    }
}

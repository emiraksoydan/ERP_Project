using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Product : IEntity
    {
        public Guid ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal Sale { get; set; }
        public int Stock { get; set; }
    }
}

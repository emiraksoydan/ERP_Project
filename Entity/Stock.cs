using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Stock : IEntity
    {
        public Guid StockID { get; set; }
        public Guid ProdcutID { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}

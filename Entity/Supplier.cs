using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Supplier : IEntity
    {
        public Guid SupplierID { get; set; };
        public string SupplierName { get; set; }
        public string SupplierContact { get; set; }
        
    }
}

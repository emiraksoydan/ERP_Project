using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Category :IEntity
    {
        public Guid CategoryID { get; set; };
        public string Name { get; set; }
    }
}

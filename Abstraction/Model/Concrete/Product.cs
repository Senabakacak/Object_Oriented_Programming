using Abstraction.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Model.Concrete
{
    public  class Product:BaseEntity<int>
    {
        public override int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public short Stock { get; set; }     
    }
}

using Abstraction.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Model.Concrete
{
    public  class Category:BaseEntity<Guid>
    {
        public override Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}

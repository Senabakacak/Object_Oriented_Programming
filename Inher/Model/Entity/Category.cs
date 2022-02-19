using Inher.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inher.Model.Entity
{
     class Category:BaseEntity //BaseEntity sınıfından kalıtım aldı,baseentity özelliklerine sahip.
     {
        public Category()
        {

        }
        public Category(int id,string name)
        {
            this.Id= id;
            this.Name= name;
        }

     }
}

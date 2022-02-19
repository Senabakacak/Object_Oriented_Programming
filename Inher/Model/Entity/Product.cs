using Inher.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inher.Model.Entity
{
     class Product:BaseEntity 
     {
        public decimal price { get; set; }
        public short stock { get; set; }
        public string description { get; set; }

        //sınıfın kendine ait özellikleri ilgili sınıf içine yazılır

    }
}

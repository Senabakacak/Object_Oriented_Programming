using Inheritance2.Model.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2.Model.Entities
{
    public  class Nokia:BasePhone
    {
        public string Anten { get; set; }
        public override string CallSound()
        {
            return "Nokia telefon sesi...";
        }
        public override string ShowInfo()
        {
            return $"Id:{this.Id}\nBrand:{this.Brand}\nModel:{this.Model}\nAnten:{this.Anten}";
        }
    }
}

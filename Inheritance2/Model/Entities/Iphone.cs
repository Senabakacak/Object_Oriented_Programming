using Inheritance2.Model.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2.Model.Entities
{
    public  class Iphone:BasePhone
    {
        public override string CallSound()
        {
            return "Iphone telefon sesi..";
        }
    }
}

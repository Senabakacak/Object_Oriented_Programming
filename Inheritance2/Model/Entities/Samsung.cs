using Inheritance2.Model.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance2.Model.Entities
{
    public  class Samsung:BasePhone
    {
        private int _price;
        public int Price
        {
            get { return _price; }
            set
            { 
                if(value>0)
                { _price = value; }
                else
                { MessageBox.Show("telefonun fiyatı sıfırdan büyük olur"); }
            
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2.Model.BaseEntity
{
    public class BasePhone
    {
        public Guid Id
        {
            get { return Guid.NewGuid(); }
            //set;
        }
        public string Brand { get; set; }
        public string Model { get; set; }

        public virtual string CallSound() //virtual olarak işaretledik çünkü override edilecek yani alt sınıflarda bu methoda yeni yetenekler kazandırılıcak
        {
            return "genel telefon sesi";
        }

        public virtual string  ShowInfo()
        {
            return $"Id:{this.Id}\nBrand:{this.Brand}\nModel:{this.Brand}";
        }

        public string BannerMessage()
        {
            return "WELCOME...";
        }
    }
}

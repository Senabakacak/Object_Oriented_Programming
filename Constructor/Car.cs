using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor
{
    class Car
    {
        public string Brand { get; set; }
        public string EnginSize { get; set; }
        public string Model { get; set; }
        
        public Car () //constructor yapıcı bir methodtur.sınıfı intialize eder.hızlıca değer atarlar
        {
            MessageBox.Show($"Araba prototipinden nesne üretildi.hiçbir özellik kullanılmadan yaratıldı");
        }

        public Car(string marka) //bir kez daha constructor açtığımızda bize kızar fakat parametre yazdığımızda düzelir
        {
            this.Brand = marka; 
            //this=sınıfın üyelerine erişiriz
            //marka değeri alıcak
            MessageBox.Show($"Brand:{this.Brand}");
        }

        public Car (string marka,string model,string motorhacmi)
        {
            this.Brand = marka;
            this.Model = model;
            this.EnginSize = motorhacmi;

            MessageBox.Show($"Brand:{this.Brand}\nModel:{this.Model}\nEnginSize:{this.EnginSize}");
        }

    }
}

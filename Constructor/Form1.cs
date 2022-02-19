using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConstructor1_Click(object sender, EventArgs e)
        {
            Car car1 = new Car();
            car1.Brand = "mercedes ";
            car1.Model = "CLA200";
            car1.EnginSize = "1.3";
            MessageBox.Show($"Brand:{car1.Brand}\nModel:{car1.Model}\nEnginSize:{car1.EnginSize}");
        }

        private void btnConstructor2_Click(object sender, EventArgs e)
        {
            Car car2 = new Car("Volvo");
        }

        private void btnConstructor3_Click(object sender, EventArgs e)
        {
            Car car3 = new Car("BMW", "3.20", "1.5");
        }
    }
}

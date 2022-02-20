using Inheritance2.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
            Iphone iphone = new Iphone();
            iphone.Model = "x10";
            iphone.Brand = "Apple";

            MessageBox.Show(iphone.CallSound());
            MessageBox.Show(iphone.BannerMessage());
            MessageBox.Show(iphone.ShowInfo());

            Nokia nokia = new Nokia();
            nokia.Brand = "nokia";
            nokia.Model = "3310";
            nokia.Anten = "var";

            MessageBox.Show(nokia.ShowInfo());

            Samsung samsung = new Samsung();
            samsung.Price = 1000;

            MessageBox.Show(samsung.Price.ToString());

        }
    }
}

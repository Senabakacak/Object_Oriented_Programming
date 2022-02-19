using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Computer monster = new Computer();
            monster.DisplayScreen = true;
            monster.MemoryCapacity = 64;
            monster.MemoryType = "DDR4";

            MessageBox.Show($"Ekran:{monster.DisplayScreen}\nRAM Kapasitesi:{monster.MemoryCapacity}\nRAM türü:{monster.MemoryType}");

        }
    }
}

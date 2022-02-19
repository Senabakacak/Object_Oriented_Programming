using Inher.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Id = 1;
            category.Name = "Gloves";

            MessageBox.Show($"Id:{category.Id}\nName:{category.Name}\nStatus:{category.Status}\nCreate Date:{category.CreateDate}");

            Category category1=new Category(2,"Bag");

            MessageBox.Show($"Id:{category1.Id}\nName:{category1.Name}\nStatus:{category1.Status}\nCreate Date:{category1.CreateDate}");

            Product product=new Product();
            product.Id = 1;
            product.Name = "everlast gloves";
            product.price = 15.5M;
            product.stock = 200;
            product.Status = Model.Base.Status.Modified;

            MessageBox.Show($"Id:{product.Id}\n Name:{product.Name}\nPrice:{product.price}\n Stock:{product.stock}\n Status:{product.Status}");

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "pink backpack";
            product2.price = 20.25M;
            product2.stock = 1500;
            product2.Status = Model.Base.Status.Active;

            MessageBox.Show($"Id:{product2.Id}\n Name:{product2.Name}\nPrice:{product2.price}\n Stock:{product2.stock}\n Status:{product2.Status}");

        }
    }
}

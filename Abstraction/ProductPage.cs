using Abstraction.Businiess.Repositories.Concrete;
using Abstraction.Model.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstraction
{
    public partial class ProductPage : Form
    {
        public ProductPage()
        {
            InitializeComponent();
        }

        ProductRepository productRepository = new ProductRepository();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Id = 4;
            product.Name = txtCreateName.Text;
            product.Description = txtCreateDescription.Text;
            product.Price = decimal.Parse(txtPrice.Text);
            product.Stock = short.Parse(txtStock.Text);
            productRepository.Create(product);

            //Repository içerisindekil GetAll fonksiyonu yardımıyla veri tabanındaki bütün ürünlerimizi tabloya bastık.
            dataGridView1.DataSource = productRepository.GetAll();
        }
        int id;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
        
            Product product = new Product();
            product.Id = id;
            product.Name = txtupdateName.Text;
            product.Description = txtupdatedescription.Text;
            product.Price = decimal.Parse(txtupdateprice.Text);
            product.Stock = short.Parse(txtupdatestock.Text);

          
            productRepository.Update(product);

            //Datanın son halini tabloya bastık.
            dataGridView1.DataSource = productRepository.GetAll();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //Güncellemek istediğimiz varlığı veri tabında yaptığımız gibi Id'sinden yakalayarak işlem yapmamız gerekmektedir. Bu sebepten ötürü aşağıda kullanıcının güncellemek istediği varlığın id'sini alıyoruz.
            id = int.Parse(txtFindById.Text);
            Product product = productRepository.GetById(id);

            //yukarıda GetById() fonksiyonu ile yakaladığımız product'ın bilgilerini ilgilli textbox'lara basıyoruz. Kullanıcı artık değiştirmek istediği alanları değiştirebilecektir.
            txtupdateName.Text = product.Name;
            txtupdatedescription.Text = product.Description;
            txtupdateprice.Text = product.Price.ToString();
            txtupdatestock.Text = product.Stock.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            int id = int.Parse(txtDeleteproduct.Text);
            Product product = productRepository.GetById(id);
            productRepository.Delete(product);

            dataGridView1.DataSource = productRepository.GetAll();
        }

        private void ProductPage_Load(object sender, EventArgs e)
        {
            //Sayfa yüklenirken fake datayı tabloya doldurduk
            dataGridView1.DataSource = productRepository.GetAll();
        }
    }
}

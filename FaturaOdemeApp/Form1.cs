using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaturaOdemeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnElektrik_Click(object sender, EventArgs e)
        {
            Fatura fatura = new Fatura();
            fatura.Adı = "Elektrik";
            fatura.Tutar = decimal.Parse(txttutar.Text);

            decimal result = Methods.ElektrikFaturası(fatura.Tutar);

            MessageBox.Show($"KDV'li Tutar:{result}");

        }

        private void btnSu_Click(object sender, EventArgs e)
        {
            Fatura fatura = new Fatura();
            fatura.Adı = "Su";
            fatura.Tutar = decimal.Parse(txttutar.Text);

            decimal result= Methods.SuFaturası(fatura.Tutar);

            MessageBox.Show($"KDV'li Tutar:{result}");

        }

        private void btndogalgaz_Click(object sender, EventArgs e)
        {
            Fatura fatura = new Fatura();
            fatura.Adı = "DoğalGaz";
            fatura.Tutar = decimal.Parse(txttutar.Text);

            decimal result = Methods.DogalGazFaturasi(fatura.Tutar);

            MessageBox.Show($"Fatura Adı:{fatura.Adı}\nKDV Bedeli:{Methods.KDV}\nKDV'li Tutar:{result}");
        }
    }
}

using Abstraction.Businiess;
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
    public partial class CategoryPage : Form
    {
        public CategoryPage()
        {
            InitializeComponent();
        }

        CategoryRepository categoryRepository = new CategoryRepository();

        private void CategoryPage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= categoryRepository.GetAll();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Id=Guid.NewGuid();
            category.Name = txtCreateName.Text;
            category.Description = txtCreateDescription.Text;
            categoryRepository.Create(category);
            dataGridView1.DataSource = categoryRepository.GetAll();
            Utilities.EraseArea(GrpCreateCategory);

        }
        Guid id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Guid.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            txtUpdateName.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            txtUpdateDescription.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
            txtdelete.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
        }


        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Id = id;
            category.Name = txtUpdateName.Text;
            category.Description = txtUpdateDescription.Text;
            categoryRepository.Update(category);

            dataGridView1.DataSource = categoryRepository.GetAll();

            Utilities.EraseArea(grpUpdateCategory);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Id = id;
            categoryRepository.Delete(category);

            dataGridView1.DataSource = categoryRepository.GetAll();

            Utilities.EraseArea(grpdeletecategory);
        }

       
    }
}

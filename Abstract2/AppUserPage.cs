using Abstract2.Businiess.Repositories.Concrete;
using Abstract2.Model.Entities.Concrete;
using Abstract2.Model.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract2
{
    public partial class AppUserPage : Form
    {
        public AppUserPage()
        {
            InitializeComponent();
        }
        AppUserRepository appUserRepository = new AppUserRepository();
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            AppUser appUser = new AppUser();
            appUser.Id = 4;
            appUser.FirstName = txtFirstName.Text;
            appUser.LastName = txtLastName.Text;
            appUser.Role = (Role)Enum.Parse(typeof(Role), cmbRole.Text);

            appUserRepository.Create(appUser);

            dataGridView1.DataSource = appUserRepository.GetAll();
        }
        int id;
        private void button2_Click(object sender, EventArgs e)
        {
            AppUser appUser = new AppUser();
            appUser.Id = id;
            appUser.FirstName = txtUpdateFirstName.Text;
            appUser.LastName = txtUpdateLastName.Text;
            appUser.Role = (Role)Enum.Parse(typeof(Role), cmbUpdateRole.Text);

            appUserRepository.Update(appUser);

            dataGridView1.DataSource = appUserRepository.GetAll();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            id = int.Parse(txtId.Text);
            AppUser appUser = appUserRepository.GetById(id);

            txtUpdateFirstName.Text = appUser.FirstName;
            txtUpdateLastName.Text = appUser.LastName;
            cmbUpdateRole.Text = appUser.Role.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDeleteId.Text);
            AppUser appUser = appUserRepository.GetById(id);
            appUserRepository.Delete(appUser);

            dataGridView1.DataSource = appUserRepository.GetAll();
        }

        private void btnGetRole_Click(object sender, EventArgs e)
        {

            Role role = (Role)Enum.Parse(typeof(Role), cmbFindByRole.Text);
            List<AppUser> appUser = appUserRepository.GetByRole(role);
            dataGridView1.DataSource = appUser.ToList();

        }

        private void AppUserPage_Load(object sender, EventArgs e)
        {
            appUserRepository.GetRoles(cmbRole);

            appUserRepository.GetRoles(cmbFindByRole);

            dataGridView1.DataSource = appUserRepository.GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            appUserRepository.GetRoles(cmbUpdateRole);
        }
    }
    

}

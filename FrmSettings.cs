using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            var users = db.Users.ToList();
            dataGridView1.DataSource = users;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUserId.Text);
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            db.SaveChanges();
            MessageBox.Show("Kullanıcı bilgileri güncellendi!");

            var users = db.Users.ToList();
            dataGridView1.DataSource=users;
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.Show();
            this.Hide();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBuilding frmBuilding = new FrmBuilding();
            frmBuilding.Show();
            this.Hide();
        }

        private void btnSpendings_Click(object sender, EventArgs e)
        {
            FrmFaturalar frmFaturalar = new FrmFaturalar();
            frmFaturalar.Show();
            this.Hide();
        }

        private void btnBankProcess_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frmBankProcesses = new FrmBankProcesses();
            frmBankProcesses.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashBoard frmDashBoard = new FrmDashBoard();
            frmDashBoard.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            Users users = new Users();
            users.UserName = userName;
            users.Password = password;

            db.Users.Add(users);
            db.SaveChanges();
            MessageBox.Show("Yeni Kullanıcı Eklendi!!");

            var values = db.Users.ToList();
            dataGridView1.DataSource = values;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUserId.Text);

            var removeValue = db.Users.Find(id);
            db.Users.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Kullanıcı başarıyla silindi !! ");

            var values = db.Users.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin(); 
            frmLogin.Show();
            this.Hide();
        }
    }
}

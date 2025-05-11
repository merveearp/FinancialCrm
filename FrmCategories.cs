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
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            panel.DataSource = values;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text;

            Categories categories = new Categories();
            categories.CategoryName= categoryName;
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Kategori başarıyla eklendi !! ");

            var values = db.Categories.ToList();
            panel.DataSource = values;

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var removeValue = db.Categories.Find(id);
            db.Categories.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Kategori başarıyla silindi !! ");

            var values = db.Categories.ToList();
            panel.DataSource = values;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text;
            int id = int.Parse(txtCategoryId.Text);

            var updatedValue = db.Categories.Find(id);

            updatedValue.CategoryName = categoryName;
 
            db.SaveChanges();
            MessageBox.Show("Ödeme başarıyla güncellendi !! ");

            var values = db.Categories.ToList();
            panel.DataSource = values;
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var category =db.Categories.Find(id);

            txtCategoryName.Text = category.CategoryName;
            panel.DataSource = new List<Categories> { category };
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBuilding frmBuilding = new FrmBuilding();
            frmBuilding.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmDashBoard frmDashBoard = new FrmDashBoard();
            frmDashBoard.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frmBankProcesses = new FrmBankProcesses();
            frmBankProcesses.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmFaturalar frm = new FrmFaturalar();
            frm.Show();
            this.Hide();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();    
            frmSettings.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}

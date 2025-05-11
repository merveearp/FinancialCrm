using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            var values = db.Spendings.Select(
                x=> new
                {
                    x.SpendingId,
                    x.SpendingDate,
                    x.SpendingTitle,
                    x.Categories.CategoryId,
                    x.Categories.CategoryName,
                    x.SpendingAmount
                }).ToList();
            dataGridView1.DataSource = values;
            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.ValueMember = "CategoryId";
            comboBoxCategory.DataSource = db.Categories.ToList();

            //Chart1 kodları
            var spendingsData = db.Spendings.Select(x => new
            {
                x.SpendingAmount,
                x.Categories.CategoryName

            }).ToList();
            chart1.Series.Clear();
            var series1 = chart1.Series.Add("Faturalar");
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;

            foreach (var item in spendingsData)
            {
                series1.Points.AddXY(item.CategoryName, item.SpendingAmount);
            }
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Spendings.Select(
                x => new
                {
                    x.SpendingId,
                    x.SpendingDate,
                    x.SpendingTitle,
                    x.Categories.CategoryId,
                    x.Categories.CategoryName,
                    x.SpendingAmount
                }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            decimal amount = decimal.Parse(txtAmount.Text);
            int categoryId =Convert.ToInt32(comboBoxCategory.SelectedValue);
            DateTime spendingDate = dateTimePicker1.Value;
            
            Spendings spendings = new Spendings();
            spendings.SpendingTitle = title;
            spendings.SpendingAmount = amount;
            spendings.CategoryId = categoryId;
            spendings.SpendingDate = spendingDate;
            
            db.Spendings.Add(spendings);
            db.SaveChanges();
            MessageBox.Show("Harcama işlemi başarıyla eklendi !! ", "Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Gridi güncelle
            var values = db.Spendings.Select(
                 x => new
                 {
                     x.SpendingId,
                     x.SpendingDate,
                     x.SpendingTitle,
                     x.Categories.CategoryId,
                     x.Categories.CategoryName,
                     x.SpendingAmount
                 }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var removeValue = db.Spendings.Find(id);
            db.Spendings.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Harcama başarıyla silindi !! ", "Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //Gridi güncelle
            var values = db.Spendings.Select(
                 x => new
                 {
                     x.SpendingId,
                     x.SpendingDate,
                     x.SpendingTitle,
                     x.Categories.CategoryId,
                     x.Categories.CategoryName,
                     x.SpendingAmount
                 }).ToList();
            dataGridView1.DataSource = values;
        }

        private void Kategoriler_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.Show();
            this.Hide();
        }

        private void Bankalar_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void Faturalar_Click(object sender, EventArgs e)
        {
            FrmFaturalar frmFaturalar = new FrmFaturalar();
            frmFaturalar.Show();
            this.Hide();

        }

        private void Giderler_Click(object sender, EventArgs e)
        {

            FrmBuilding frmBuilding = new FrmBuilding();
            frmBuilding.Show();
            this.Hide();
        }

        private void BankaHareketleri_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frmBankProcesses = new FrmBankProcesses();
            frmBankProcesses.Show();
            this.Hide();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            FrmDashBoard frmDashBoard = new FrmDashBoard();
            frmDashBoard.Show();
            this.Hide();
        }

        private void Ayarlar_Click(object sender, EventArgs e)
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

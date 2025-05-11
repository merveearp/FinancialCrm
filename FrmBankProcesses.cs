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
    public partial class FrmBankProcesses : Form
    {
        public FrmBankProcesses()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmBankProcesses_Load(object sender, EventArgs e)
        {
            
            //Chart1 kodları
            var processData = db.BankProcesses.Select(x => new
            {
                x.SenderFullName,
                x.Amount,
            }).ToList();
            chart1.Series.Clear();
            var series1 = chart1.Series.Add("Havale İşlemleri");
            foreach (var item in processData)
            {
                series1.Points.AddXY(item.SenderFullName, item.Amount);
            }

            var values = db.BankProcesses.Select(x => new
            {
                x.ProcessDate,
                x.Amount,
                x.SenderFullName
            }).ToList();
            dataGridView.DataSource = values;

            var totalAmount = db.BankProcesses.Sum(x => x.Amount);
            lblAmount.Text = totalAmount.ToString() + "₺";
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

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
    public partial class FrmDashBoard : Form
    {
        public FrmDashBoard()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        int count = 0;
        private void FrmDashBoard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString()+"₺";

            var lastBankProcess = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select
                (y => y.Amount).FirstOrDefault();
            lblLastBankProcessAmount.Text = lastBankProcess.ToString()+"₺";

            //Chart1 kodları
            var bankData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance

            }).ToList();
            chart1.Series.Clear();
            var series1 = chart1.Series.Add("Series1");
            foreach(var item in bankData)
            {
                series1.Points.AddXY(item.BankTitle,item.BankBalance);
            }
            
            //Chart2 kodları
            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            foreach (var item in billData)
            {
                series2.Points.AddXY(item.BillTitle, item.BillAmount);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if(count%4 ==1)
            {
                var elektrik = db.Bills.Where(x=>x.BillTitle=="Elektrik").Select
                    (x=>x.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Elektrik";
                lblBillAmount.Text = elektrik.ToString()+"₺";
            }
            if (count % 4 == 2)
            {
                var dogalgaz = db.Bills.Where(x => x.BillTitle == "Doğalgaz").Select
                    (x => x.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Doğalgaz";
                lblBillAmount.Text = dogalgaz.ToString() + "₺";
            }
            if (count % 4 == 3)
            {
                var su = db.Bills.Where(x => x.BillTitle == "Su").Select
                    (x => x.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Su";
                lblBillAmount.Text = su.ToString() + "₺";
            }
            if (count % 4 == 0)
            {
                var internet = db.Bills.Where(x => x.BillTitle == "İnternet").Select
                    (x => x.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "İnternet";
                lblBillAmount.Text = internet.ToString() + "₺";
            }
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

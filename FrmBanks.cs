﻿using FinancialCrm.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBanks_Load(object sender, EventArgs e)
        {
            //Banka Bakiyeleri
            var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select
                (y => y.BankBalance).FirstOrDefault();
            var vakifBankBalance = db.Banks.Where(x => x.BankTitle == "VakıfBank").Select
                (y => y.BankBalance).FirstOrDefault();
            var isBankasiBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select
                (y => y.BankBalance).FirstOrDefault();
            lblIsBankasiBalance.Text = isBankasiBalance.ToString() + "₺";
            lblVakifBankBalance.Text = vakifBankBalance.ToString() + "₺";
            lblZiraatBankBalance.Text = ziraatBankBalance.ToString() + "₺";

            //Banka Harekeleri
            var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description + " " + bankProcess1.Amount + " " + bankProcess1.ProcessDate;

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + " " + bankProcess1.Amount + " " + bankProcess2.ProcessDate;

            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + " " + bankProcess1.Amount + " " + bankProcess3.ProcessDate;

            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + " " + bankProcess1.Amount + " " + bankProcess4.ProcessDate;

            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + " " + bankProcess1.Amount + " " + bankProcess5.ProcessDate;


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
            FrmDashBoard frmDashBoard = new FrmDashBoard();
            frmDashBoard.Show();
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

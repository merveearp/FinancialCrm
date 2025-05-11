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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            txtPassword.PasswordChar = '*';

            var user = db.Users.FirstOrDefault(x => x.UserName == userName && x.Password == password);
            if (user != null)
            {
                MessageBox.Show("Giriş Başarılı!");
                FrmDashBoard frm = new FrmDashBoard();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı adı veya şifre");
                FrmLogin frm = new FrmLogin();
                frm.Show();
                this.Hide();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void chkSifreGöster_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSifreGöster.Checked)
            {
                txtPassword.PasswordChar = '\0'; //ŞİFREYİ AÇIK GÖSTER

            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}

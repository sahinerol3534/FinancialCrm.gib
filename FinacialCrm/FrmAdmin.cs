using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinacialCrm.Models;


namespace FinacialCrm
{
    
    public partial class FrmAdmin : Form
    {
       
        public FrmAdmin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }
        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();



        private void btnEnter_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            var user = db.Users.FirstOrDefault(x => x.UserName == userName && x.UserPassword == password);


            if (user == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                FrmDashboard frmDashboard = new FrmDashboard();
                frmDashboard.Show();
                this.Hide();
            }


        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "admin";
            txtPassword.Text = "1234";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çıkmak istediğinize emin misiniz?",
                                       "Çıkış Onayı",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Çıkış Yapıldı", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit(); ;
            }
        }
    }
}

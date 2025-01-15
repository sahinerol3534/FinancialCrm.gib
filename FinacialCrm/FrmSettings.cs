using FinacialCrm.Models;
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

namespace FinacialCrm
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            txtrePassword.UseSystemPasswordChar = true;
        }
        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();



        private void btnEnter_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string repassword = txtrePassword.Text;
            var user = db.Users.FirstOrDefault(x => x.UserName == userName);


            if (user != null)
            {
                MessageBox.Show("Kullanıcı kullanılıyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("Kullanıcı adı boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(repassword)) 
            {
                MessageBox.Show("Girdiğiniz Parolalar Farklı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != repassword)
            {
                MessageBox.Show("Girdiğiniz Parolalar Farklı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                Users users = new Users();
                users.UserName = userName;
                users.UserPassword = password;
                db.Users.Add(users);
                db.SaveChanges();
                MessageBox.Show("Kullanıcı Eklendi", "user", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnUpdateUsers_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            int id = int.Parse((string)txtUsersId.Text);

            Users user = new Users();
            user.UserName = username;
            user.UserPassword = password;

            var updatedValue = db.Users.Find(id);
            updatedValue.UserName = username;
            //db.Categories.Add(categories);
            db.SaveChanges();

            MessageBox.Show("Kategory Güncellendi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemoveUsers_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUsersId.Text);
            var removeValue = db.Users.Find(id);
            db.Users.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Kullanıcı Silindi", "Users", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCatagoriesForm_Click(object sender, EventArgs e)
        {
            FrmCatagories frm = new FrmCatagories();
            frm.Show();
            this.Close();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Close();
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();  
            frm.Show();
            this.Close();
        }

        private void btnExpensesForm_Click(object sender, EventArgs e)
        {
            FrmExpenses frm = new FrmExpenses();
            frm.Show();
            this.Close();
        }

        private void btnBankProcessForm_Click(object sender, EventArgs e)
        {
            FrmBankProcess frm = new FrmBankProcess();
            frm.Show();
            this.Close();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Close();
        }

        private void btnBankExit_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çıkmak istediğinize emin misiniz?",
                                       "Çıkış Onayı",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Çıkış Yapıldı", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmDashboard frm = new FrmDashboard();
                frm.Show();
                this.Close();
            }
        }

        
    }
}

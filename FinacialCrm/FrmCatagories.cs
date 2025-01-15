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

namespace FinacialCrm
{
    public partial class FrmCatagories : Form
    {
        public FrmCatagories()
        {
            InitializeComponent();
        }
        private void TextboxClear()
        {
            txtCatagoriesId.Text = "";
            txtCatagoriesName.Text = "";
            
        }

        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.ShowDialog();
            this.Close();
        }

        private void btnBillsForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.ShowDialog();
            this.Close();
        }

        private void btnExpensesForm_Click(object sender, EventArgs e)
        {
            FrmExpenses frm = new FrmExpenses();
            frm.ShowDialog();
            this.Close();
        }

        private void btnBankProcessForm_Click(object sender, EventArgs e)
        {
            FrmBankProcess frm = new FrmBankProcess();
            frm.ShowDialog();
            this.Close();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.ShowDialog();
            this.Close();
        }

        private void btnSettingForm_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmDashboard frm= new FrmDashboard();
            frm.ShowDialog();
            this.Close();
        }

        private void btnListCatagories_Click(object sender, EventArgs e)
        {

            var values = db.Categories.
                Select(x => new
                {
                    x.CategoryId,
                    x.CategoryName

                }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateCatagories_Click(object sender, EventArgs e)
        {
            string title = txtCatagoriesName.Text;
            

            Categories categories = new Categories();
            categories.CategoryName = title;
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi","Katagoriler", MessageBoxButtons.OK,MessageBoxIcon.Information);

            var values = db.Categories.
                Select(x => new
                {
                    x.CategoryId,
                    x.CategoryName

                }).ToList();
            dataGridView1.DataSource = values;

            TextboxClear();
        }

        private void btnRemoveCatagories_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCatagoriesId.Text);
            var removeValue = db.Categories.Find(id);
            db.Categories.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Categories.
                Select(x => new
                {
                    x.CategoryId,
                    x.CategoryName

                }).ToList();
            dataGridView1.DataSource = values;

            TextboxClear();
        }

       

        private void FrmCatagories_Load(object sender, EventArgs e)
        {
            var values = db.Categories.
                Select(x => new
                {
                    x.CategoryId,
                    x.CategoryName

                }). ToList();
            dataGridView1.DataSource = values;

        }

        private void btnUpdateCatagories_Click_1(object sender, EventArgs e)
        {

            string title = txtCatagoriesName.Text;
            int id = int.Parse((string)txtCatagoriesId.Text);

            Categories categories = new Categories();
            categories.CategoryName = title;
            var updatedValue = db.Categories.Find(id);
            updatedValue.CategoryName = title;
            //db.Categories.Add(categories);
            db.SaveChanges();

            MessageBox.Show("Kategory Güncellendi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            var values = db.Categories.
                 Select(x => new
                 {
                     x.CategoryId,
                     x.CategoryName

                 }).ToList();
            dataGridView1.DataSource = values;

            TextboxClear();
        }
    }
}

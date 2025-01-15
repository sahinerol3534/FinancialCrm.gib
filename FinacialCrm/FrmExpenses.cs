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
    public partial class FrmExpenses : Form
    {
        public FrmExpenses()
        {
            InitializeComponent();
        }
        private void TextboxClear()
        {
            txtexpensesId.Text = "";
            txtexpensesTitle.Text = "";
            txtexpensesAmount.Text = "";
            txtexpensesDate.Text = "";
        }

        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();

        private void FrmExpenses_Load(object sender, EventArgs e)
        {
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
            var categories = db.Categories
                .Where(x => x.CategoryName != null)
                .Select(x => new
                {
                    x.CategoryId,
                    x.CategoryName,
                }).ToList();
            cmbCatagories.DataSource = categories;
            cmbCatagories.DisplayMember = "CategoryName";
            cmbCatagories.ValueMember = "CategoryId";
            cmbCatagories.SelectedIndex = -1;

            var totalBalance = db.Spendings.Sum(x => x.SpendingAmount);
            lblTotalExpenses.Text = totalBalance.ToString();

            //Chart2 Kodları
            var billData = db.Spendings.Select(x => new
            {
                x.SpendingTitle,
                x.SpendingAmount,
                x.SpendingDate
            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Genel Giderler");
            series2.ChartType = SeriesChartType.Pie;
            foreach (var item in billData)
            {
                var pointIndex = series2.Points.AddXY(item.SpendingTitle, item.SpendingAmount);
                series2.Points[pointIndex].Label = item.SpendingAmount.ToString();
                series2.Points[pointIndex].Font = new Font("Verdana", 7, FontStyle.Regular);
                series2.Points[pointIndex].LegendText = $"{item.SpendingTitle}";
            }

            TextboxClear();
        }

        private void btnListExpenses_Click(object sender, EventArgs e)
        {
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateExpenses_Click(object sender, EventArgs e)
        {
            string title = txtexpensesTitle.Text;
            decimal amount = decimal.Parse(txtexpensesAmount.Text);
            DateTime period = DateTime.Parse(txtexpensesDate.Text);
            int categoryId = (int)cmbCatagories.SelectedValue;

            Spendings spendings = new Spendings();
            spendings.SpendingTitle = title;
            spendings.SpendingAmount = amount;
            spendings.SpendingDate = period;
            spendings.CategoryId = categoryId;
            db.Spendings.Add(spendings);
            db.SaveChanges();
            MessageBox.Show("Gider Eklendi", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;

            TextboxClear();
        }

        private void btnRemoveExpenses_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtexpensesId.Text);
            var removeValue = db.Spendings.Find(id);
            db.Spendings.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Gider Silindi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;

            TextboxClear();
        }

        private void btnUpdateExpenses_Click(object sender, EventArgs e)
        {
            string title = txtexpensesTitle.Text;
            decimal amount = Decimal.Parse(txtexpensesAmount.Text);
            DateTime priod = DateTime.Parse( txtexpensesDate.Text);
            int id = int.Parse((string)txtexpensesId.Text);
            int categoryId = (int)cmbCatagories.SelectedValue;
            var updatedValue = db.Spendings.Find(id);
            Spendings spendings = new Spendings();
            updatedValue.SpendingTitle = title;
            updatedValue.SpendingAmount = amount;
            updatedValue.SpendingDate = priod;
            updatedValue.CategoryId = categoryId;
            db.SaveChanges();


            MessageBox.Show("Gider Güncellendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);


            var value = db.Spendings.ToList();
            dataGridView1.DataSource = value;

            TextboxClear();


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

        private void btnSettingForm_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Close();
        }

       

        
    }
}

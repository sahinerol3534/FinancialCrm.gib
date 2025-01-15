using FinacialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinacialCrm
{
    public partial class FrmBankProcess : Form
    {
        public FrmBankProcess()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();
        int count = 0;

        private void btnCatagoriesForm_Click(object sender, EventArgs e)
        {
            FrmCatagories frm = new FrmCatagories();
            frm.Show();
            this.Close();
        }

        private void btnBillsForm_Click(object sender, EventArgs e)
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



        private void FrmBankProcess_Load(object sender, EventArgs e)
        {

            var totalBalance = db.BankProcesses.Where(y => y.BankId == 1).Sum(x => x.Amount);
            lblZiraatBalance.Text = totalBalance.ToString() + " ₺";

            var totalvakifBalance = db.BankProcesses.Where(y => y.BankId == 2).Sum(x => x.Amount);
            lblVakifBalance.Text = totalvakifBalance.ToString() + " ₺";

            var totalisBalance = db.BankProcesses.Where(y => y.BankId == 3).Sum(x => x.Amount);
            lblisBalance.Text = totalisBalance.ToString() + " ₺";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count % 4 == 1)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                //****
                var values = db.BankProcesses
                .Where(x => x.BankId == 1)
                .Select(x => new
                {
                     BankName = "Ziraat Bankası", // BankId yerine sabit BankName
                    x.Amount,
                     x.ProcessDate,
                    x.Description
                })
                .ToList();

                dataGridView1.DataSource = values;
                dataGridView1.Columns["Description"].Width = 200;

                //****
            }
            if (count % 4 == 2)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                var vakifBankProcess = db.BankProcesses.Where(x => x.BankId == 2).Select(x => new
                {
                    BankName = "Vakıf Bank", // BankId yerine sabit BankName
                    x.Amount,
                    x.ProcessDate,
                    x.Description
                }).ToList();
                dataGridView1.DataSource = vakifBankProcess;
                dataGridView1.Columns["Description"].Width = 200;
            }
        
            if (count % 4 == 3)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                var isBankProcess = db.BankProcesses.Where(x => x.BankId == 3).Select(x => new
                {
                    BankName = "İş Bankası", // BankId yerine sabit BankName
                    x.Amount,
                    x.ProcessDate,
                    x.Description
                }).ToList();
                dataGridView1.DataSource = isBankProcess;
                dataGridView1.Columns["Description"].Width = 200;
            }
        }
        
    }
}

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
using FinacialCrm.Models;

namespace FinacialCrm
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();
        int count = 0;
        private void FrmDashboard_Load(object sender, EventArgs e)
        {

           
            var totalziraatBalance = db.BankProcesses.Where(y => y.BankId == 1).Sum(x => x.Amount);
            lblZiraatBalance.Text = totalziraatBalance.ToString() + " ₺";

            var totalvakifBalance = db.BankProcesses.Where(y => y.BankId == 2).Sum(x => x.Amount);
            lblVakifBalance.Text = totalvakifBalance.ToString() + " ₺";

            var totalisBalance = db.BankProcesses.Where(y => y.BankId == 3).Sum(x => x.Amount);
            lblisBalance.Text = totalisBalance.ToString() + " ₺";

            

            var totalBalance = db.BankProcesses.Sum(x => x.Amount);
            lblTotalBalance.Text = totalBalance.ToString();

            lblBillTitle.Text = "Faturalar Toplamı";
            var totalAmount = db.Bills.Sum(x => x.BillAmount);
            lblBillAmount.Text = totalAmount.ToString();

            var lastBankProcessAmount =db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault();
            lblLastBankProcessAmount.Text = lastBankProcessAmount.ToString() + " ₺";

            var lastBankProcessBankId = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.BankId).FirstOrDefault();
            var lastBankProcessBankName = db.Banks.Where(x => x.BankId == lastBankProcessBankId).Select(y =>y.BankTitle).FirstOrDefault();
           // lblLastBankProcessBankName.Text = lastBankProcessBankName.ToString();

            //chart1 Kodları
            var bankData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance
            }
            ).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Series1");
            foreach (var item in bankData)
            {
                series.Points.AddXY(item.BankTitle, item.BankBalance);
            }

            //Chart2 Kodları
            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType = SeriesChartType.Pie;
            foreach (var item in billData)
            {
                var pointIndex = series2.Points.AddXY(item.BillTitle, item.BillAmount);
                series2.Points[pointIndex].Label = item.BillAmount.ToString();
                series2.Points[pointIndex].Font = new Font("Verdana", 7, FontStyle.Regular);
                series2.Points[pointIndex].LegendText = item.BillTitle;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count % 5 == 0)
            {
                lblBillTitle.Text = "Faturalar Toplamı";
                var totalAmount = db.Bills.Sum(x => x.BillAmount);
                lblBillAmount.Text = totalAmount.ToString();


            }
            if (count % 5 == 1)
            {
                var elektrikFaturasi = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Elektrik Faturası";
                lblBillAmount.Text = elektrikFaturasi.ToString() + " ₺";
            }
            if (count % 5 == 2)
            {
                var dogalgazFaturasi = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Doğalgaz Faturası";
                lblBillAmount.Text = dogalgazFaturasi.ToString() + " ₺";
            }
            if (count % 5 == 3)
            {
                var suFaturasi = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Su Faturası";
                lblBillAmount.Text = suFaturasi.ToString() + " ₺";
            }
            if (count % 5 == 4)
            {
                var internet = db.Bills.Where(x => x.BillTitle == "İnternet").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "İnternet";
                lblBillAmount.Text = internet.ToString() + " ₺";
            }

        }

     

        private void btnCatagoriesForm_Click(object sender, EventArgs e)
        {
            FrmCatagories frm = new FrmCatagories();
            frm.Show();
            this.Close();
        }

        private void btnSetting_Click_1(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Close();
        }

        private void btnBankForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Close();
        }

        private void btnExpensesForm_Click(object sender, EventArgs e)
        {
            FrmExpenses frm = new FrmExpenses();
            frm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBankProcess frm = new FrmBankProcess();
            frm.Show();
            this.Close();
        }
    }
}

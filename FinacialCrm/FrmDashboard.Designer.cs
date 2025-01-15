namespace FinacialCrm
{
    partial class FrmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.lblBillTitle = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblLastBankProcessAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblZiraat = new System.Windows.Forms.Label();
            this.lblisBalance = new System.Windows.Forms.Label();
            this.lblVakifBalance = new System.Windows.Forms.Label();
            this.lblZiraatBalance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnExpensesForm = new System.Windows.Forms.Button();
            this.btnBillForm = new System.Windows.Forms.Button();
            this.btnCatagoriesForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnBankForm = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBillAmount
            // 
            this.lblBillAmount.AutoSize = true;
            this.lblBillAmount.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblBillAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBillAmount.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillAmount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBillAmount.Location = new System.Drawing.Point(44, 139);
            this.lblBillAmount.Name = "lblBillAmount";
            this.lblBillAmount.Size = new System.Drawing.Size(203, 42);
            this.lblBillAmount.TabIndex = 1;
            this.lblBillAmount.Text = "0000,00 ₺";
            this.lblBillAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBillTitle
            // 
            this.lblBillTitle.AutoSize = true;
            this.lblBillTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBillTitle.Font = new System.Drawing.Font("Verdana", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBillTitle.Location = new System.Drawing.Point(3, 9);
            this.lblBillTitle.Name = "lblBillTitle";
            this.lblBillTitle.Size = new System.Drawing.Size(20, 28);
            this.lblBillTitle.TabIndex = 0;
            this.lblBillTitle.Text = " ";
            this.lblBillTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.lblLastBankProcessAmount);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Location = new System.Drawing.Point(1012, 114);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(300, 202);
            this.panel8.TabIndex = 11;
            // 
            // lblLastBankProcessAmount
            // 
            this.lblLastBankProcessAmount.AutoSize = true;
            this.lblLastBankProcessAmount.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblLastBankProcessAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLastBankProcessAmount.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastBankProcessAmount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblLastBankProcessAmount.Location = new System.Drawing.Point(49, 139);
            this.lblLastBankProcessAmount.Name = "lblLastBankProcessAmount";
            this.lblLastBankProcessAmount.Size = new System.Drawing.Size(203, 42);
            this.lblLastBankProcessAmount.TabIndex = 1;
            this.lblLastBankProcessAmount.Text = "0000,00 ₺";
            this.lblLastBankProcessAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Gelen Son Havale";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.chart2);
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(360, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 296);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(494, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(459, 49);
            this.panel5.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(2, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(424, 40);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ödenen ve Ödenmesi gereken Fatura tutarlarına\r\naşağıdaki grafikten ulaşabilirsini" +
    "z.";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(0, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(459, 49);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(2, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bankadaki Para miktarlarına aşağıdaki\r\ngrafikten ulaşabilirsiniz.\r\n";
            // 
            // chart2
            // 
            this.chart2.BorderlineColor = System.Drawing.Color.LemonChiffon;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(494, 71);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(456, 219);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "Faturalar";
            title1.Name = "Faturalar";
            title1.ShadowColor = System.Drawing.SystemColors.HotTrack;
            this.chart2.Titles.Add(title1);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 71);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(456, 219);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.lblBillAmount);
            this.panel6.Controls.Add(this.lblBillTitle);
            this.panel6.Location = new System.Drawing.Point(687, 114);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 202);
            this.panel6.TabIndex = 12;
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.AutoSize = true;
            this.lblTotalBalance.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblTotalBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalBalance.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalBalance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTotalBalance.Location = new System.Drawing.Point(44, 139);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(203, 42);
            this.lblTotalBalance.TabIndex = 1;
            this.lblTotalBalance.Text = "0000,00 ₺";
            this.lblTotalBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(39, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Toplam Bakiye";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblZiraat);
            this.panel3.Controls.Add(this.lblisBalance);
            this.panel3.Controls.Add(this.lblVakifBalance);
            this.panel3.Controls.Add(this.lblZiraatBalance);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lblTotalBalance);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(360, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 202);
            this.panel3.TabIndex = 8;
            // 
            // lblZiraat
            // 
            this.lblZiraat.AutoSize = true;
            this.lblZiraat.BackColor = System.Drawing.Color.Transparent;
            this.lblZiraat.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZiraat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblZiraat.Location = new System.Drawing.Point(-1, 8);
            this.lblZiraat.Name = "lblZiraat";
            this.lblZiraat.Size = new System.Drawing.Size(147, 20);
            this.lblZiraat.TabIndex = 8;
            this.lblZiraat.Text = "Ziraat Bankası :";
            this.lblZiraat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblisBalance
            // 
            this.lblisBalance.AutoSize = true;
            this.lblisBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblisBalance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblisBalance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblisBalance.Location = new System.Drawing.Point(195, 62);
            this.lblisBalance.Name = "lblisBalance";
            this.lblisBalance.Size = new System.Drawing.Size(98, 20);
            this.lblisBalance.TabIndex = 7;
            this.lblisBalance.Text = "0000,00 ₺";
            this.lblisBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVakifBalance
            // 
            this.lblVakifBalance.AutoSize = true;
            this.lblVakifBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblVakifBalance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVakifBalance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblVakifBalance.Location = new System.Drawing.Point(195, 35);
            this.lblVakifBalance.Name = "lblVakifBalance";
            this.lblVakifBalance.Size = new System.Drawing.Size(98, 20);
            this.lblVakifBalance.TabIndex = 6;
            this.lblVakifBalance.Text = "0000,00 ₺";
            this.lblVakifBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblZiraatBalance
            // 
            this.lblZiraatBalance.AutoSize = true;
            this.lblZiraatBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblZiraatBalance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZiraatBalance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblZiraatBalance.Location = new System.Drawing.Point(195, 8);
            this.lblZiraatBalance.Name = "lblZiraatBalance";
            this.lblZiraatBalance.Size = new System.Drawing.Size(98, 20);
            this.lblZiraatBalance.TabIndex = 5;
            this.lblZiraatBalance.Text = "0000,00 ₺";
            this.lblZiraatBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(3, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "İş Bankası      :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(2, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vakıf Bank      :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dashboard /Genel Durum";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1334, 54);
            this.panel2.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnExit.Location = new System.Drawing.Point(40, 458);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(270, 50);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.LemonChiffon;
            this.button5.Location = new System.Drawing.Point(39, 323);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(270, 50);
            this.button5.TabIndex = 4;
            this.button5.Text = "Banka Hareketleri";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnExpensesForm
            // 
            this.btnExpensesForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpensesForm.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExpensesForm.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnExpensesForm.Location = new System.Drawing.Point(39, 258);
            this.btnExpensesForm.Name = "btnExpensesForm";
            this.btnExpensesForm.Size = new System.Drawing.Size(270, 50);
            this.btnExpensesForm.TabIndex = 3;
            this.btnExpensesForm.Text = "Giderler";
            this.btnExpensesForm.UseVisualStyleBackColor = true;
            this.btnExpensesForm.Click += new System.EventHandler(this.btnExpensesForm_Click);
            // 
            // btnBillForm
            // 
            this.btnBillForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillForm.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillForm.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnBillForm.Location = new System.Drawing.Point(39, 193);
            this.btnBillForm.Name = "btnBillForm";
            this.btnBillForm.Size = new System.Drawing.Size(270, 50);
            this.btnBillForm.TabIndex = 2;
            this.btnBillForm.Text = "Faturalar";
            this.btnBillForm.UseVisualStyleBackColor = true;
            // 
            // btnCatagoriesForm
            // 
            this.btnCatagoriesForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatagoriesForm.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCatagoriesForm.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnCatagoriesForm.Location = new System.Drawing.Point(39, 63);
            this.btnCatagoriesForm.Name = "btnCatagoriesForm";
            this.btnCatagoriesForm.Size = new System.Drawing.Size(270, 50);
            this.btnCatagoriesForm.TabIndex = 0;
            this.btnCatagoriesForm.Text = "Kategoriler";
            this.btnCatagoriesForm.UseVisualStyleBackColor = true;
            this.btnCatagoriesForm.Click += new System.EventHandler(this.btnCatagoriesForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnExpensesForm);
            this.panel1.Controls.Add(this.btnBillForm);
            this.panel1.Controls.Add(this.btnBankForm);
            this.panel1.Controls.Add(this.btnCatagoriesForm);
            this.panel1.Location = new System.Drawing.Point(-1, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 610);
            this.panel1.TabIndex = 6;
            // 
            // btnSetting
            // 
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSetting.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnSetting.Location = new System.Drawing.Point(40, 393);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(270, 50);
            this.btnSetting.TabIndex = 6;
            this.btnSetting.Text = "Ayarlar";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click_1);
            // 
            // btnBankForm
            // 
            this.btnBankForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankForm.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankForm.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnBankForm.Location = new System.Drawing.Point(39, 128);
            this.btnBankForm.Name = "btnBankForm";
            this.btnBankForm.Size = new System.Drawing.Size(270, 50);
            this.btnBankForm.TabIndex = 1;
            this.btnBankForm.Text = "Bankalar";
            this.btnBankForm.UseVisualStyleBackColor = true;
            this.btnBankForm.Click += new System.EventHandler(this.btnBankForm_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1332, 653);
            this.ControlBox = false;
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.Label lblBillTitle;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblLastBankProcessAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnExpensesForm;
        private System.Windows.Forms.Button btnBillForm;
        private System.Windows.Forms.Button btnCatagoriesForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBankForm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblisBalance;
        private System.Windows.Forms.Label lblVakifBalance;
        private System.Windows.Forms.Label lblZiraatBalance;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblZiraat;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSetting;
    }
}


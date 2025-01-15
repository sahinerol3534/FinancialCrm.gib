namespace FinacialCrm
{
    partial class FrmExpenses
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTotalExpenses = new System.Windows.Forms.Label();
            this.lblBillTitle = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDashboardForm = new System.Windows.Forms.Button();
            this.btnBankProcessForm = new System.Windows.Forms.Button();
            this.btnBillForm = new System.Windows.Forms.Button();
            this.btnCatagoriesForm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCatagories = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdateExpenses = new System.Windows.Forms.Button();
            this.btnRemoveExpenses = new System.Windows.Forms.Button();
            this.btnCreateExpenses = new System.Windows.Forms.Button();
            this.btnListExpenses = new System.Windows.Forms.Button();
            this.txtexpensesDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtexpensesAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtexpensesTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtexpensesId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSettingForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Controls.Add(this.lblTotalExpenses);
            this.panel6.Controls.Add(this.lblBillTitle);
            this.panel6.Controls.Add(this.chart2);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Location = new System.Drawing.Point(360, 65);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(973, 318);
            this.panel6.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(312, 34);
            this.label7.TabIndex = 24;
            this.label7.Text = "Giderler Toplamı : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(601, 256);
            this.dataGridView1.TabIndex = 11;
            // 
            // lblTotalExpenses
            // 
            this.lblTotalExpenses.AutoSize = true;
            this.lblTotalExpenses.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalExpenses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalExpenses.Font = new System.Drawing.Font("Verdana", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalExpenses.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTotalExpenses.Location = new System.Drawing.Point(331, 9);
            this.lblTotalExpenses.Name = "lblTotalExpenses";
            this.lblTotalExpenses.Size = new System.Drawing.Size(177, 36);
            this.lblTotalExpenses.TabIndex = 1;
            this.lblTotalExpenses.Text = "0000,00 ₺";
            this.lblTotalExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // chart2
            // 
            this.chart2.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(605, 103);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(322, 219);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "Faturalar";
            title1.Name = "Faturalar";
            title1.ShadowColor = System.Drawing.SystemColors.HotTrack;
            this.chart2.Titles.Add(title1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(571, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 49);
            this.panel5.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(95, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Genel Gider Grafiği\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "General Expenses / Genel Giderler";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnExit.Location = new System.Drawing.Point(40, 456);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(270, 50);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDashboardForm
            // 
            this.btnDashboardForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboardForm.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboardForm.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnDashboardForm.Location = new System.Drawing.Point(40, 326);
            this.btnDashboardForm.Name = "btnDashboardForm";
            this.btnDashboardForm.Size = new System.Drawing.Size(270, 50);
            this.btnDashboardForm.TabIndex = 5;
            this.btnDashboardForm.Text = "Dashboard";
            this.btnDashboardForm.UseVisualStyleBackColor = true;
            this.btnDashboardForm.Click += new System.EventHandler(this.btnDashboardForm_Click);
            // 
            // btnBankProcessForm
            // 
            this.btnBankProcessForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankProcessForm.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankProcessForm.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnBankProcessForm.Location = new System.Drawing.Point(40, 261);
            this.btnBankProcessForm.Name = "btnBankProcessForm";
            this.btnBankProcessForm.Size = new System.Drawing.Size(270, 50);
            this.btnBankProcessForm.TabIndex = 4;
            this.btnBankProcessForm.Text = "Banka Hareketleri";
            this.btnBankProcessForm.UseVisualStyleBackColor = true;
            this.btnBankProcessForm.Click += new System.EventHandler(this.btnBankProcessForm_Click);
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
            this.btnBillForm.Click += new System.EventHandler(this.btnBillForm_Click);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbCatagories);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnUpdateExpenses);
            this.groupBox1.Controls.Add(this.btnRemoveExpenses);
            this.groupBox1.Controls.Add(this.btnCreateExpenses);
            this.groupBox1.Controls.Add(this.btnListExpenses);
            this.groupBox1.Controls.Add(this.txtexpensesDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtexpensesAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtexpensesTitle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtexpensesId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(360, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 274);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // cmbCatagories
            // 
            this.cmbCatagories.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cmbCatagories.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCatagories.FormattingEnabled = true;
            this.cmbCatagories.Location = new System.Drawing.Point(159, 221);
            this.cmbCatagories.Name = "cmbCatagories";
            this.cmbCatagories.Size = new System.Drawing.Size(283, 33);
            this.cmbCatagories.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(16, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Katagorisi";
            // 
            // btnUpdateExpenses
            // 
            this.btnUpdateExpenses.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnUpdateExpenses.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateExpenses.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdateExpenses.Location = new System.Drawing.Point(691, 195);
            this.btnUpdateExpenses.Name = "btnUpdateExpenses";
            this.btnUpdateExpenses.Size = new System.Drawing.Size(233, 32);
            this.btnUpdateExpenses.TabIndex = 23;
            this.btnUpdateExpenses.Text = "Gider Güncelle";
            this.btnUpdateExpenses.UseVisualStyleBackColor = false;
            this.btnUpdateExpenses.Click += new System.EventHandler(this.btnUpdateExpenses_Click);
            // 
            // btnRemoveExpenses
            // 
            this.btnRemoveExpenses.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnRemoveExpenses.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveExpenses.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRemoveExpenses.Location = new System.Drawing.Point(692, 147);
            this.btnRemoveExpenses.Name = "btnRemoveExpenses";
            this.btnRemoveExpenses.Size = new System.Drawing.Size(233, 32);
            this.btnRemoveExpenses.TabIndex = 22;
            this.btnRemoveExpenses.Text = "Gider Sil";
            this.btnRemoveExpenses.UseVisualStyleBackColor = false;
            this.btnRemoveExpenses.Click += new System.EventHandler(this.btnRemoveExpenses_Click);
            // 
            // btnCreateExpenses
            // 
            this.btnCreateExpenses.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnCreateExpenses.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateExpenses.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreateExpenses.Location = new System.Drawing.Point(691, 100);
            this.btnCreateExpenses.Name = "btnCreateExpenses";
            this.btnCreateExpenses.Size = new System.Drawing.Size(233, 32);
            this.btnCreateExpenses.TabIndex = 21;
            this.btnCreateExpenses.Text = "Gider Ekle";
            this.btnCreateExpenses.UseVisualStyleBackColor = false;
            this.btnCreateExpenses.Click += new System.EventHandler(this.btnCreateExpenses_Click);
            // 
            // btnListExpenses
            // 
            this.btnListExpenses.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnListExpenses.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListExpenses.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnListExpenses.Location = new System.Drawing.Point(691, 48);
            this.btnListExpenses.Name = "btnListExpenses";
            this.btnListExpenses.Size = new System.Drawing.Size(233, 32);
            this.btnListExpenses.TabIndex = 20;
            this.btnListExpenses.Text = "Gider Listesi";
            this.btnListExpenses.UseVisualStyleBackColor = false;
            this.btnListExpenses.Click += new System.EventHandler(this.btnListExpenses_Click);
            // 
            // txtexpensesDate
            // 
            this.txtexpensesDate.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtexpensesDate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtexpensesDate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtexpensesDate.Location = new System.Drawing.Point(159, 167);
            this.txtexpensesDate.Name = "txtexpensesDate";
            this.txtexpensesDate.Size = new System.Drawing.Size(283, 32);
            this.txtexpensesDate.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(16, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tarih";
            // 
            // txtexpensesAmount
            // 
            this.txtexpensesAmount.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtexpensesAmount.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtexpensesAmount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtexpensesAmount.Location = new System.Drawing.Point(159, 119);
            this.txtexpensesAmount.Name = "txtexpensesAmount";
            this.txtexpensesAmount.Size = new System.Drawing.Size(283, 32);
            this.txtexpensesAmount.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(16, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Miktar";
            // 
            // txtexpensesTitle
            // 
            this.txtexpensesTitle.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtexpensesTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtexpensesTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtexpensesTitle.Location = new System.Drawing.Point(159, 69);
            this.txtexpensesTitle.Name = "txtexpensesTitle";
            this.txtexpensesTitle.Size = new System.Drawing.Size(283, 32);
            this.txtexpensesTitle.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(16, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Gider Çeşidi";
            // 
            // txtexpensesId
            // 
            this.txtexpensesId.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtexpensesId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtexpensesId.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtexpensesId.Location = new System.Drawing.Point(159, 20);
            this.txtexpensesId.Name = "txtexpensesId";
            this.txtexpensesId.Size = new System.Drawing.Size(283, 32);
            this.txtexpensesId.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(16, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Gider ID";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            // 
            // btnSettingForm
            // 
            this.btnSettingForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingForm.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettingForm.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnSettingForm.Location = new System.Drawing.Point(40, 391);
            this.btnSettingForm.Name = "btnSettingForm";
            this.btnSettingForm.Size = new System.Drawing.Size(270, 50);
            this.btnSettingForm.TabIndex = 6;
            this.btnSettingForm.Text = "Ayarlar";
            this.btnSettingForm.UseVisualStyleBackColor = true;
            this.btnSettingForm.Click += new System.EventHandler(this.btnSettingForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSettingForm);
            this.panel1.Controls.Add(this.btnDashboardForm);
            this.panel1.Controls.Add(this.btnBankProcessForm);
            this.panel1.Controls.Add(this.btnBillForm);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.btnCatagoriesForm);
            this.panel1.Location = new System.Drawing.Point(-1, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 605);
            this.panel1.TabIndex = 14;
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnBanksForm.Location = new System.Drawing.Point(39, 128);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(270, 50);
            this.btnBanksForm.TabIndex = 1;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = true;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1334, 53);
            this.panel2.TabIndex = 15;
            // 
            // FrmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1332, 653);
            this.ControlBox = false;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmExpenses_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTotalExpenses;
        private System.Windows.Forms.Label lblBillTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDashboardForm;
        private System.Windows.Forms.Button btnBankProcessForm;
        private System.Windows.Forms.Button btnBillForm;
        private System.Windows.Forms.Button btnCatagoriesForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSettingForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdateExpenses;
        private System.Windows.Forms.Button btnRemoveExpenses;
        private System.Windows.Forms.Button btnCreateExpenses;
        private System.Windows.Forms.Button btnListExpenses;
        private System.Windows.Forms.TextBox txtexpensesTitle;
        private System.Windows.Forms.TextBox txtexpensesDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtexpensesId;
        private System.Windows.Forms.TextBox txtexpensesAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbCatagories;
        private System.Windows.Forms.Label label8;
    }
}
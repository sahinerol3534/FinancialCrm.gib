namespace FinacialCrm
{
    partial class FrmBankProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankProcess));
            this.lblisBalance = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblVakifBalance = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSettingForm = new System.Windows.Forms.Button();
            this.btnDashboardForm = new System.Windows.Forms.Button();
            this.btnExpensesForm = new System.Windows.Forms.Button();
            this.btnBillsForm = new System.Windows.Forms.Button();
            this.btnCatagoriesForm = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblZiraatBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblisBalance
            // 
            this.lblisBalance.AutoSize = true;
            this.lblisBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblisBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblisBalance.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblisBalance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblisBalance.Location = new System.Drawing.Point(49, 139);
            this.lblisBalance.Name = "lblisBalance";
            this.lblisBalance.Size = new System.Drawing.Size(203, 42);
            this.lblisBalance.TabIndex = 1;
            this.lblisBalance.Text = "0000,00 ₺";
            this.lblisBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(85, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "İş Bankası";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Location = new System.Drawing.Point(1127, 117);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(90, 90);
            this.panel7.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Snow;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.lblisBalance);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Location = new System.Drawing.Point(1012, 114);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(300, 202);
            this.panel8.TabIndex = 11;
            // 
            // lblVakifBalance
            // 
            this.lblVakifBalance.AutoSize = true;
            this.lblVakifBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblVakifBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVakifBalance.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVakifBalance.ForeColor = System.Drawing.Color.Gold;
            this.lblVakifBalance.Location = new System.Drawing.Point(44, 139);
            this.lblVakifBalance.Name = "lblVakifBalance";
            this.lblVakifBalance.Size = new System.Drawing.Size(203, 42);
            this.lblVakifBalance.TabIndex = 1;
            this.lblVakifBalance.Text = "0000,00 ₺";
            this.lblVakifBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnExit.Location = new System.Drawing.Point(40, 393);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(270, 50);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSettingForm);
            this.panel1.Controls.Add(this.btnDashboardForm);
            this.panel1.Controls.Add(this.btnExpensesForm);
            this.panel1.Controls.Add(this.btnBillsForm);
            this.panel1.Controls.Add(this.btnCatagoriesForm);
            this.panel1.Location = new System.Drawing.Point(-1, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 610);
            this.panel1.TabIndex = 6;
            // 
            // btnSettingForm
            // 
            this.btnSettingForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingForm.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettingForm.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnSettingForm.Location = new System.Drawing.Point(40, 328);
            this.btnSettingForm.Name = "btnSettingForm";
            this.btnSettingForm.Size = new System.Drawing.Size(270, 50);
            this.btnSettingForm.TabIndex = 6;
            this.btnSettingForm.Text = "Ayarlar";
            this.btnSettingForm.UseVisualStyleBackColor = true;
            this.btnSettingForm.Click += new System.EventHandler(this.btnSettingForm_Click);
            // 
            // btnDashboardForm
            // 
            this.btnDashboardForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboardForm.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboardForm.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnDashboardForm.Location = new System.Drawing.Point(40, 263);
            this.btnDashboardForm.Name = "btnDashboardForm";
            this.btnDashboardForm.Size = new System.Drawing.Size(270, 50);
            this.btnDashboardForm.TabIndex = 5;
            this.btnDashboardForm.Text = "Dashboard";
            this.btnDashboardForm.UseVisualStyleBackColor = true;
            this.btnDashboardForm.Click += new System.EventHandler(this.btnDashboardForm_Click);
            // 
            // btnExpensesForm
            // 
            this.btnExpensesForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpensesForm.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExpensesForm.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnExpensesForm.Location = new System.Drawing.Point(39, 197);
            this.btnExpensesForm.Name = "btnExpensesForm";
            this.btnExpensesForm.Size = new System.Drawing.Size(270, 50);
            this.btnExpensesForm.TabIndex = 3;
            this.btnExpensesForm.Text = "Giderler";
            this.btnExpensesForm.UseVisualStyleBackColor = true;
            this.btnExpensesForm.Click += new System.EventHandler(this.btnExpensesForm_Click);
            // 
            // btnBillsForm
            // 
            this.btnBillsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillsForm.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillsForm.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnBillsForm.Location = new System.Drawing.Point(39, 132);
            this.btnBillsForm.Name = "btnBillsForm";
            this.btnBillsForm.Size = new System.Drawing.Size(270, 50);
            this.btnBillsForm.TabIndex = 2;
            this.btnBillsForm.Text = "Faturalar";
            this.btnBillsForm.UseVisualStyleBackColor = true;
            this.btnBillsForm.Click += new System.EventHandler(this.btnBillsForm_Click);
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
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Snow;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.lblVakifBalance);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(687, 114);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 202);
            this.panel6.TabIndex = 12;
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Location = new System.Drawing.Point(114, 1);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(90, 90);
            this.panel9.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(81, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "VakıfBank";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hesap Hareketleri";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Snow;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblZiraatBalance);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(360, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 202);
            this.panel3.TabIndex = 8;
            // 
            // lblZiraatBalance
            // 
            this.lblZiraatBalance.AutoSize = true;
            this.lblZiraatBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblZiraatBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblZiraatBalance.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZiraatBalance.ForeColor = System.Drawing.Color.Red;
            this.lblZiraatBalance.Location = new System.Drawing.Point(44, 139);
            this.lblZiraatBalance.Name = "lblZiraatBalance";
            this.lblZiraatBalance.Size = new System.Drawing.Size(203, 42);
            this.lblZiraatBalance.TabIndex = 1;
            this.lblZiraatBalance.Text = "0000,00 ₺";
            this.lblZiraatBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(52, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ziraat Bankası";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(88, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 80);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(796, 117);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(90, 90);
            this.panel5.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1334, 55);
            this.panel2.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(360, 334);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(952, 307);
            this.dataGridView1.TabIndex = 13;
            // 
            // FrmBankProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1332, 653);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBankProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmBankProcess_Load);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblisBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblVakifBalance;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSettingForm;
        private System.Windows.Forms.Button btnDashboardForm;
        private System.Windows.Forms.Button btnExpensesForm;
        private System.Windows.Forms.Button btnBillsForm;
        private System.Windows.Forms.Button btnCatagoriesForm;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblZiraatBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
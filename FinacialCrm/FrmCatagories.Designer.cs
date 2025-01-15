namespace FinacialCrm
{
    partial class FrmCatagories
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDashboardForm = new System.Windows.Forms.Button();
            this.btnBankProcessForm = new System.Windows.Forms.Button();
            this.btnExpensesForm = new System.Windows.Forms.Button();
            this.btnBillsForm = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSettingForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCatagoriesId = new System.Windows.Forms.TextBox();
            this.txtCatagoriesName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnListCatagories = new System.Windows.Forms.Button();
            this.btnCreateCatagories = new System.Windows.Forms.Button();
            this.btnRemoveCatagories = new System.Windows.Forms.Button();
            this.btnUpdateCatagories = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategoriler";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnExit.Location = new System.Drawing.Point(40, 446);
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
            this.btnDashboardForm.Location = new System.Drawing.Point(40, 316);
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
            this.btnBankProcessForm.Location = new System.Drawing.Point(40, 251);
            this.btnBankProcessForm.Name = "btnBankProcessForm";
            this.btnBankProcessForm.Size = new System.Drawing.Size(270, 50);
            this.btnBankProcessForm.TabIndex = 4;
            this.btnBankProcessForm.Text = "Banka Hareketleri";
            this.btnBankProcessForm.UseVisualStyleBackColor = true;
            this.btnBankProcessForm.Click += new System.EventHandler(this.btnBankProcessForm_Click);
            // 
            // btnExpensesForm
            // 
            this.btnExpensesForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpensesForm.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExpensesForm.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnExpensesForm.Location = new System.Drawing.Point(40, 186);
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
            this.btnBillsForm.Location = new System.Drawing.Point(40, 121);
            this.btnBillsForm.Name = "btnBillsForm";
            this.btnBillsForm.Size = new System.Drawing.Size(270, 50);
            this.btnBillsForm.TabIndex = 2;
            this.btnBillsForm.Text = "Faturalar";
            this.btnBillsForm.UseVisualStyleBackColor = true;
            this.btnBillsForm.Click += new System.EventHandler(this.btnBillsForm_Click);
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
            this.btnSettingForm.Location = new System.Drawing.Point(40, 381);
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
            this.panel1.Controls.Add(this.btnExpensesForm);
            this.panel1.Controls.Add(this.btnBillsForm);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Location = new System.Drawing.Point(-1, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 600);
            this.panel1.TabIndex = 14;
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnBanksForm.Location = new System.Drawing.Point(40, 56);
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
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1334, 52);
            this.panel2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(414, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kategori Id :";
            // 
            // txtCatagoriesId
            // 
            this.txtCatagoriesId.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtCatagoriesId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCatagoriesId.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtCatagoriesId.Location = new System.Drawing.Point(563, 129);
            this.txtCatagoriesId.Name = "txtCatagoriesId";
            this.txtCatagoriesId.Size = new System.Drawing.Size(239, 32);
            this.txtCatagoriesId.TabIndex = 17;
            // 
            // txtCatagoriesName
            // 
            this.txtCatagoriesName.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtCatagoriesName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCatagoriesName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtCatagoriesName.Location = new System.Drawing.Point(563, 181);
            this.txtCatagoriesName.Name = "txtCatagoriesName";
            this.txtCatagoriesName.Size = new System.Drawing.Size(239, 32);
            this.txtCatagoriesName.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(414, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kategori Adı:";
            // 
            // btnListCatagories
            // 
            this.btnListCatagories.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnListCatagories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListCatagories.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnListCatagories.Location = new System.Drawing.Point(563, 237);
            this.btnListCatagories.Name = "btnListCatagories";
            this.btnListCatagories.Size = new System.Drawing.Size(239, 38);
            this.btnListCatagories.TabIndex = 20;
            this.btnListCatagories.Text = "Kategori Listele";
            this.btnListCatagories.UseVisualStyleBackColor = false;
            this.btnListCatagories.Click += new System.EventHandler(this.btnListCatagories_Click);
            // 
            // btnCreateCatagories
            // 
            this.btnCreateCatagories.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnCreateCatagories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateCatagories.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreateCatagories.Location = new System.Drawing.Point(563, 281);
            this.btnCreateCatagories.Name = "btnCreateCatagories";
            this.btnCreateCatagories.Size = new System.Drawing.Size(239, 38);
            this.btnCreateCatagories.TabIndex = 21;
            this.btnCreateCatagories.Text = "Yeni Kategori Ekle";
            this.btnCreateCatagories.UseVisualStyleBackColor = false;
            this.btnCreateCatagories.Click += new System.EventHandler(this.btnCreateCatagories_Click);
            // 
            // btnRemoveCatagories
            // 
            this.btnRemoveCatagories.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnRemoveCatagories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveCatagories.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRemoveCatagories.Location = new System.Drawing.Point(563, 325);
            this.btnRemoveCatagories.Name = "btnRemoveCatagories";
            this.btnRemoveCatagories.Size = new System.Drawing.Size(239, 38);
            this.btnRemoveCatagories.TabIndex = 22;
            this.btnRemoveCatagories.Text = "Kategori Sil";
            this.btnRemoveCatagories.UseVisualStyleBackColor = false;
            this.btnRemoveCatagories.Click += new System.EventHandler(this.btnRemoveCatagories_Click);
            // 
            // btnUpdateCatagories
            // 
            this.btnUpdateCatagories.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnUpdateCatagories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateCatagories.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdateCatagories.Location = new System.Drawing.Point(563, 368);
            this.btnUpdateCatagories.Name = "btnUpdateCatagories";
            this.btnUpdateCatagories.Size = new System.Drawing.Size(239, 38);
            this.btnUpdateCatagories.TabIndex = 23;
            this.btnUpdateCatagories.Text = "Kategori Güncelle";
            this.btnUpdateCatagories.UseVisualStyleBackColor = false;
            this.btnUpdateCatagories.Click += new System.EventHandler(this.btnUpdateCatagories_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(821, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(485, 279);
            this.dataGridView1.TabIndex = 24;
            // 
            // FrmCatagories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.CancelButton = this.btnCreateCatagories;
            this.ClientSize = new System.Drawing.Size(1332, 653);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdateCatagories);
            this.Controls.Add(this.btnRemoveCatagories);
            this.Controls.Add(this.btnCreateCatagories);
            this.Controls.Add(this.btnListCatagories);
            this.Controls.Add(this.txtCatagoriesName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCatagoriesId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCatagories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCatagories_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDashboardForm;
        private System.Windows.Forms.Button btnBankProcessForm;
        private System.Windows.Forms.Button btnExpensesForm;
        private System.Windows.Forms.Button btnBillsForm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSettingForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCatagoriesId;
        private System.Windows.Forms.TextBox txtCatagoriesName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnListCatagories;
        private System.Windows.Forms.Button btnCreateCatagories;
        private System.Windows.Forms.Button btnRemoveCatagories;
        private System.Windows.Forms.Button btnUpdateCatagories;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
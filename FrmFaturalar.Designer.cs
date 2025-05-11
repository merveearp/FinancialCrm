namespace FinancialCrm
{
    partial class FrmFaturalar
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Dashboard = new System.Windows.Forms.Button();
            this.Giderler = new System.Windows.Forms.Button();
            this.btnCreateBill = new System.Windows.Forms.Button();
            this.btnBillList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Bankalar = new System.Windows.Forms.Button();
            this.Kategoriler = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BankaHareketleri = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Button();
            this.Ayarlar = new System.Windows.Forms.Button();
            this.Faturalar = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteBill = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(125)))), ((int)(((byte)(165)))));
            this.Dashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Dashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dashboard.Location = new System.Drawing.Point(14, 254);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(195, 35);
            this.Dashboard.TabIndex = 4;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = false;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // Giderler
            // 
            this.Giderler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(125)))), ((int)(((byte)(165)))));
            this.Giderler.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Giderler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Giderler.Location = new System.Drawing.Point(16, 172);
            this.Giderler.Name = "Giderler";
            this.Giderler.Size = new System.Drawing.Size(193, 35);
            this.Giderler.TabIndex = 2;
            this.Giderler.Text = "Giderler";
            this.Giderler.UseVisualStyleBackColor = false;
            this.Giderler.Click += new System.EventHandler(this.Giderler_Click);
            // 
            // btnCreateBill
            // 
            this.btnCreateBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(125)))), ((int)(((byte)(165)))));
            this.btnCreateBill.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateBill.Location = new System.Drawing.Point(127, 186);
            this.btnCreateBill.Name = "btnCreateBill";
            this.btnCreateBill.Size = new System.Drawing.Size(127, 35);
            this.btnCreateBill.TabIndex = 20;
            this.btnCreateBill.Text = "Yeni Fatura";
            this.btnCreateBill.UseVisualStyleBackColor = false;
            this.btnCreateBill.Click += new System.EventHandler(this.btnCreateBill_Click);
            // 
            // btnBillList
            // 
            this.btnBillList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(125)))), ((int)(((byte)(165)))));
            this.btnBillList.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBillList.Location = new System.Drawing.Point(3, 186);
            this.btnBillList.Name = "btnBillList";
            this.btnBillList.Size = new System.Drawing.Size(125, 35);
            this.btnBillList.TabIndex = 16;
            this.btnBillList.Text = "Fatura Listesi";
            this.btnBillList.UseVisualStyleBackColor = false;
            this.btnBillList.Click += new System.EventHandler(this.btnBillList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(61, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tarih : ";
            // 
            // Bankalar
            // 
            this.Bankalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(125)))), ((int)(((byte)(165)))));
            this.Bankalar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Bankalar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bankalar.Location = new System.Drawing.Point(17, 90);
            this.Bankalar.Name = "Bankalar";
            this.Bankalar.Size = new System.Drawing.Size(192, 35);
            this.Bankalar.TabIndex = 1;
            this.Bankalar.Text = "Bankalar";
            this.Bankalar.UseVisualStyleBackColor = false;
            this.Bankalar.Click += new System.EventHandler(this.Bankalar_Click);
            // 
            // Kategoriler
            // 
            this.Kategoriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(125)))), ((int)(((byte)(165)))));
            this.Kategoriler.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kategoriler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Kategoriler.Location = new System.Drawing.Point(17, 49);
            this.Kategoriler.Name = "Kategoriler";
            this.Kategoriler.Size = new System.Drawing.Size(192, 35);
            this.Kategoriler.TabIndex = 0;
            this.Kategoriler.Text = "Kategoriler";
            this.Kategoriler.UseVisualStyleBackColor = false;
            this.Kategoriler.Click += new System.EventHandler(this.Kategoriler_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(127, 77);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(262, 22);
            this.txtAmount.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(52, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Miktar :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(7, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fatura Başlık :";
            // 
            // BankaHareketleri
            // 
            this.BankaHareketleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(125)))), ((int)(((byte)(165)))));
            this.BankaHareketleri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BankaHareketleri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BankaHareketleri.Location = new System.Drawing.Point(16, 213);
            this.BankaHareketleri.Name = "BankaHareketleri";
            this.BankaHareketleri.Size = new System.Drawing.Size(193, 35);
            this.BankaHareketleri.TabIndex = 3;
            this.BankaHareketleri.Text = "Banka Hareketleri";
            this.BankaHareketleri.UseVisualStyleBackColor = false;
            this.BankaHareketleri.Click += new System.EventHandler(this.BankaHareketleri_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(113)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.Ayarlar);
            this.panel1.Controls.Add(this.Faturalar);
            this.panel1.Controls.Add(this.Dashboard);
            this.panel1.Controls.Add(this.BankaHareketleri);
            this.panel1.Controls.Add(this.Giderler);
            this.panel1.Controls.Add(this.Bankalar);
            this.panel1.Controls.Add(this.Kategoriler);
            this.panel1.Location = new System.Drawing.Point(6, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 562);
            this.panel1.TabIndex = 13;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(125)))), ((int)(((byte)(165)))));
            this.Logout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Logout.Location = new System.Drawing.Point(14, 336);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(195, 35);
            this.Logout.TabIndex = 1;
            this.Logout.Text = "Çıkış Yap";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Ayarlar
            // 
            this.Ayarlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(125)))), ((int)(((byte)(165)))));
            this.Ayarlar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ayarlar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ayarlar.Location = new System.Drawing.Point(14, 295);
            this.Ayarlar.Name = "Ayarlar";
            this.Ayarlar.Size = new System.Drawing.Size(195, 35);
            this.Ayarlar.TabIndex = 2;
            this.Ayarlar.Text = "Ayarlar";
            this.Ayarlar.UseVisualStyleBackColor = false;
            this.Ayarlar.Click += new System.EventHandler(this.Ayarlar_Click);
            // 
            // Faturalar
            // 
            this.Faturalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(125)))), ((int)(((byte)(165)))));
            this.Faturalar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Faturalar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Faturalar.Location = new System.Drawing.Point(17, 131);
            this.Faturalar.Name = "Faturalar";
            this.Faturalar.Size = new System.Drawing.Size(192, 35);
            this.Faturalar.TabIndex = 5;
            this.Faturalar.Text = "Faturalar";
            this.Faturalar.UseVisualStyleBackColor = false;
            this.Faturalar.Click += new System.EventHandler(this.Faturalar_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(127, 40);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(262, 22);
            this.txtTitle.TabIndex = 11;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(127, 9);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(262, 22);
            this.txtId.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(153)))), ((int)(((byte)(190)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(6, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1110, 44);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fatura Formu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(35, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fatura Id :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(234)))), ((int)(((byte)(249)))));
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.btnDeleteBill);
            this.panel3.Controls.Add(this.comboBoxCategory);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnCreateBill);
            this.panel3.Controls.Add(this.btnBillList);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtAmount);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtTitle);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(234, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(409, 282);
            this.panel3.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(262, 22);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(125)))), ((int)(((byte)(165)))));
            this.btnDeleteBill.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteBill.Location = new System.Drawing.Point(257, 186);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(132, 35);
            this.btnDeleteBill.TabIndex = 22;
            this.btnDeleteBill.Text = "Fatura Sil";
            this.btnDeleteBill.UseVisualStyleBackColor = false;
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(127, 147);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(262, 24);
            this.comboBoxCategory.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(31, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Kategori  : ";
            // 
            // chart1
            // 
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(649, 92);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series9.Legend = "Legend1";
            series9.Name = "Faturalar";
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(467, 243);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(221)))), ((int)(((byte)(67)))));
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(649, 53);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(467, 39);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(321, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Fatura tutarlarına aşağıdaki grafikten ulaşabilirsiniz";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(237, 341);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(879, 232);
            this.dataGridView1.TabIndex = 19;
            // 
            // FrmFaturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 608);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "FrmFaturalar";
            this.Text = "FrmFaturalar";
            this.Load += new System.EventHandler(this.FrmFaturalar_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Button Giderler;
        private System.Windows.Forms.Button btnCreateBill;
        private System.Windows.Forms.Button btnBillList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Bankalar;
        private System.Windows.Forms.Button Kategoriler;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BankaHareketleri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Ayarlar;
        private System.Windows.Forms.Button Faturalar;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
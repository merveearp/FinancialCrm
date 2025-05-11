namespace FinancialCrm
{
    partial class FrmBankProcesses
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblAmount = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.Faturalar = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.BankaHareketleri = new System.Windows.Forms.Button();
            this.Giderler = new System.Windows.Forms.Button();
            this.Bankalar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Kategoriler = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAmount.Location = new System.Drawing.Point(182, 4);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(113, 49);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "0.00₺";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(133)))), ((int)(((byte)(168)))));
            this.panel3.Controls.Add(this.lblAmount);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(784, 469);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(527, 59);
            this.panel3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Toplam Havale :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Banka Hareketleri Formu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(153)))), ((int)(((byte)(190)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1299, 52);
            this.panel2.TabIndex = 10;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(125)))), ((int)(((byte)(165)))));
            this.Logout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Logout.Location = new System.Drawing.Point(19, 311);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(172, 35);
            this.Logout.TabIndex = 1;
            this.Logout.Text = "Çıkış Yap";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(125)))), ((int)(((byte)(165)))));
            this.Settings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Settings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Settings.Location = new System.Drawing.Point(19, 270);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(172, 35);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Ayarlar";
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Faturalar
            // 
            this.Faturalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(125)))), ((int)(((byte)(165)))));
            this.Faturalar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Faturalar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Faturalar.Location = new System.Drawing.Point(22, 106);
            this.Faturalar.Name = "Faturalar";
            this.Faturalar.Size = new System.Drawing.Size(169, 35);
            this.Faturalar.TabIndex = 5;
            this.Faturalar.Text = "Faturalar";
            this.Faturalar.UseVisualStyleBackColor = false;
            this.Faturalar.Click += new System.EventHandler(this.Faturalar_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(125)))), ((int)(((byte)(165)))));
            this.Dashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Dashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dashboard.Location = new System.Drawing.Point(19, 229);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(172, 35);
            this.Dashboard.TabIndex = 4;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = false;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // BankaHareketleri
            // 
            this.BankaHareketleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(125)))), ((int)(((byte)(165)))));
            this.BankaHareketleri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BankaHareketleri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BankaHareketleri.Location = new System.Drawing.Point(21, 188);
            this.BankaHareketleri.Name = "BankaHareketleri";
            this.BankaHareketleri.Size = new System.Drawing.Size(170, 35);
            this.BankaHareketleri.TabIndex = 3;
            this.BankaHareketleri.Text = "Banka Hareketleri";
            this.BankaHareketleri.UseVisualStyleBackColor = false;
            this.BankaHareketleri.Click += new System.EventHandler(this.BankaHareketleri_Click);
            // 
            // Giderler
            // 
            this.Giderler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(125)))), ((int)(((byte)(165)))));
            this.Giderler.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Giderler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Giderler.Location = new System.Drawing.Point(21, 147);
            this.Giderler.Name = "Giderler";
            this.Giderler.Size = new System.Drawing.Size(170, 35);
            this.Giderler.TabIndex = 2;
            this.Giderler.Text = "Giderler";
            this.Giderler.UseVisualStyleBackColor = false;
            this.Giderler.Click += new System.EventHandler(this.Giderler_Click);
            // 
            // Bankalar
            // 
            this.Bankalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(125)))), ((int)(((byte)(165)))));
            this.Bankalar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Bankalar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bankalar.Location = new System.Drawing.Point(22, 65);
            this.Bankalar.Name = "Bankalar";
            this.Bankalar.Size = new System.Drawing.Size(169, 35);
            this.Bankalar.TabIndex = 1;
            this.Bankalar.Text = "Bankalar";
            this.Bankalar.UseVisualStyleBackColor = false;
            this.Bankalar.Click += new System.EventHandler(this.Bankalar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(113)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.Settings);
            this.panel1.Controls.Add(this.Faturalar);
            this.panel1.Controls.Add(this.Dashboard);
            this.panel1.Controls.Add(this.BankaHareketleri);
            this.panel1.Controls.Add(this.Giderler);
            this.panel1.Controls.Add(this.Bankalar);
            this.panel1.Controls.Add(this.Kategoriler);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 475);
            this.panel1.TabIndex = 9;
            // 
            // Kategoriler
            // 
            this.Kategoriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(125)))), ((int)(((byte)(165)))));
            this.Kategoriler.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kategoriler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Kategoriler.Location = new System.Drawing.Point(22, 24);
            this.Kategoriler.Name = "Kategoriler";
            this.Kategoriler.Size = new System.Drawing.Size(169, 35);
            this.Kategoriler.TabIndex = 0;
            this.Kategoriler.Text = "Kategoriler";
            this.Kategoriler.UseVisualStyleBackColor = false;
            this.Kategoriler.Click += new System.EventHandler(this.Kategoriler_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(221)))), ((int)(((byte)(67)))));
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(252, 61);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(526, 38);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(523, 41);
            this.label3.TabIndex = 18;
            this.label3.Text = "Gelen Havale İşlemlerine aşağıdaki grafikten ulaşabilirsiniz\r\n";
            // 
            // chart1
            // 
            chartArea8.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart1.Legends.Add(legend8);
            this.chart1.Location = new System.Drawing.Point(240, 105);
            this.chart1.Name = "chart1";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Havale İşlemleri";
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(538, 423);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(211)))), ((int)(((byte)(243)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(784, 71);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(527, 392);
            this.dataGridView.TabIndex = 19;
            // 
            // FrmBankProcesses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 543);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBankProcesses";
            this.Text = "FrmBankProcesses";
            this.Load += new System.EventHandler(this.FrmBankProcesses_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Faturalar;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Button BankaHareketleri;
        private System.Windows.Forms.Button Giderler;
        private System.Windows.Forms.Button Bankalar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Kategoriler;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}
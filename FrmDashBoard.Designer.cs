namespace FinancialCrm
{
    partial class FrmDashBoard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.lblBillTitle = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblLastBankProcessAmount = new System.Windows.Forms.Label();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.lblLastBankProcess = new System.Windows.Forms.Label();
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
            this.Kategoriler = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBillAmount
            // 
            this.lblBillAmount.AutoSize = true;
            this.lblBillAmount.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBillAmount.Location = new System.Drawing.Point(3, 67);
            this.lblBillAmount.Name = "lblBillAmount";
            this.lblBillAmount.Size = new System.Drawing.Size(113, 49);
            this.lblBillAmount.TabIndex = 6;
            this.lblBillAmount.Text = "0.00₺";
            // 
            // lblBillTitle
            // 
            this.lblBillTitle.AutoSize = true;
            this.lblBillTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBillTitle.Location = new System.Drawing.Point(54, 16);
            this.lblBillTitle.Name = "lblBillTitle";
            this.lblBillTitle.Size = new System.Drawing.Size(121, 24);
            this.lblBillTitle.TabIndex = 4;
            this.lblBillTitle.Text = "Fatura Başlığı";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.panel5.Controls.Add(this.lblBillAmount);
            this.panel5.Controls.Add(this.lblBillTitle);
            this.panel5.Location = new System.Drawing.Point(501, 62);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(248, 158);
            this.panel5.TabIndex = 13;
            // 
            // lblLastBankProcessAmount
            // 
            this.lblLastBankProcessAmount.AutoSize = true;
            this.lblLastBankProcessAmount.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastBankProcessAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLastBankProcessAmount.Location = new System.Drawing.Point(3, 67);
            this.lblLastBankProcessAmount.Name = "lblLastBankProcessAmount";
            this.lblLastBankProcessAmount.Size = new System.Drawing.Size(113, 49);
            this.lblLastBankProcessAmount.TabIndex = 6;
            this.lblLastBankProcessAmount.Text = "0.00₺";
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.AutoSize = true;
            this.lblTotalBalance.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalBalance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalBalance.Location = new System.Drawing.Point(17, 67);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(113, 49);
            this.lblTotalBalance.TabIndex = 6;
            this.lblTotalBalance.Text = "0.00₺";
            // 
            // lblLastBankProcess
            // 
            this.lblLastBankProcess.AutoSize = true;
            this.lblLastBankProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastBankProcess.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLastBankProcess.Location = new System.Drawing.Point(47, 16);
            this.lblLastBankProcess.Name = "lblLastBankProcess";
            this.lblLastBankProcess.Size = new System.Drawing.Size(157, 24);
            this.lblLastBankProcess.TabIndex = 4;
            this.lblLastBankProcess.Text = "Gelen Son Havale";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.panel3.Controls.Add(this.lblTotalBalance);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(231, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 158);
            this.panel3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(43, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Toplam Bakiyem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dashboard Genel Bakış Formu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(153)))), ((int)(((byte)(190)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 52);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.lblLastBankProcessAmount);
            this.panel4.Controls.Add(this.lblLastBankProcess);
            this.panel4.Location = new System.Drawing.Point(768, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 158);
            this.panel4.TabIndex = 12;
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
            this.panel1.Location = new System.Drawing.Point(1, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 501);
            this.panel1.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(231, 296);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(375, 258);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(625, 296);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Legend = "Legend1";
            series4.Name = "Faturalar";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(401, 258);
            this.chart2.TabIndex = 15;
            this.chart2.Text = "chart2";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(221)))), ((int)(((byte)(67)))));
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(229, 226);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(377, 65);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 42);
            this.label3.TabIndex = 18;
            this.label3.Text = "Bankalar ve banka hesaplarındaki para miktarlarına aşağıdaki grafikten ulaşabilir" +
    "siniz";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(221)))), ((int)(((byte)(67)))));
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(625, 226);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(401, 65);
            this.flowLayoutPanel2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 63);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ödenen ve ödenmesi gereken fatura tutarlarına aşağıdaki grafikten ulaşabilirsiniz" +
    "\r\n\r\n";
            // 
            // FrmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 596);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Formu";
            this.Load += new System.EventHandler(this.FrmDashBoard_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.Label lblBillTitle;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblLastBankProcessAmount;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.Label lblLastBankProcess;
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
        private System.Windows.Forms.Button Kategoriler;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label4;
    }
}


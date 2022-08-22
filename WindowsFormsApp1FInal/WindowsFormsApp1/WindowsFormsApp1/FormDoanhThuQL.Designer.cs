
namespace WindowsFormsApp1
{
    partial class FormDoanhThuQL
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbTongDoanhThu = new System.Windows.Forms.Label();
            this.lbTongDT = new System.Windows.Forms.Panel();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTongDonHang = new System.Windows.Forms.Panel();
            this.lbHD = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPhim = new System.Windows.Forms.TabPage();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.dtpNKT = new System.Windows.Forms.DateTimePicker();
            this.dtbNBD = new System.Windows.Forms.DateTimePicker();
            this.cbLoaiTG = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabTongQuan1 = new System.Windows.Forms.TabPage();
            this.DoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabChiTiet1 = new System.Windows.Forms.TabPage();
            this.datagridvPhim = new System.Windows.Forms.DataGridView();
            this.cbLoc = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTongDT.SuspendLayout();
            this.lbTongDonHang.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPhim.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabTongQuan1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThu)).BeginInit();
            this.tabChiTiet1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridvPhim)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTongDoanhThu
            // 
            this.lbTongDoanhThu.AutoSize = true;
            this.lbTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongDoanhThu.ForeColor = System.Drawing.Color.White;
            this.lbTongDoanhThu.Location = new System.Drawing.Point(1824, 598);
            this.lbTongDoanhThu.Name = "lbTongDoanhThu";
            this.lbTongDoanhThu.Size = new System.Drawing.Size(0, 25);
            this.lbTongDoanhThu.TabIndex = 0;
            // 
            // lbTongDT
            // 
            this.lbTongDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(65)))), ((int)(((byte)(49)))));
            this.lbTongDT.Controls.Add(this.lbTongTien);
            this.lbTongDT.Controls.Add(this.label8);
            this.lbTongDT.Location = new System.Drawing.Point(1533, 29);
            this.lbTongDT.Name = "lbTongDT";
            this.lbTongDT.Size = new System.Drawing.Size(325, 93);
            this.lbTongDT.TabIndex = 18;
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTongTien.Location = new System.Drawing.Point(33, 43);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(36, 40);
            this.lbTongTien.TabIndex = 1;
            this.lbTongTien.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(21, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tổng doanh thu";
            // 
            // lbTongDonHang
            // 
            this.lbTongDonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(191)))), ((int)(((byte)(84)))));
            this.lbTongDonHang.Controls.Add(this.lbHD);
            this.lbTongDonHang.Controls.Add(this.label13);
            this.lbTongDonHang.Location = new System.Drawing.Point(1154, 29);
            this.lbTongDonHang.Name = "lbTongDonHang";
            this.lbTongDonHang.Size = new System.Drawing.Size(325, 93);
            this.lbTongDonHang.TabIndex = 19;
            // 
            // lbHD
            // 
            this.lbHD.AutoSize = true;
            this.lbHD.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHD.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbHD.Location = new System.Drawing.Point(20, 43);
            this.lbHD.Name = "lbHD";
            this.lbHD.Size = new System.Drawing.Size(36, 40);
            this.lbHD.TabIndex = 0;
            this.lbHD.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(11, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tổng đơn hàng";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPhim);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1882, 898);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPhim
            // 
            this.tabPhim.BackColor = System.Drawing.SystemColors.Control;
            this.tabPhim.Controls.Add(this.btTimKiem);
            this.tabPhim.Controls.Add(this.dtpNKT);
            this.tabPhim.Controls.Add(this.dtbNBD);
            this.tabPhim.Controls.Add(this.cbLoaiTG);
            this.tabPhim.Controls.Add(this.label3);
            this.tabPhim.Controls.Add(this.label2);
            this.tabPhim.Controls.Add(this.label1);
            this.tabPhim.Controls.Add(this.tabControl2);
            this.tabPhim.Controls.Add(this.lbTongDonHang);
            this.tabPhim.Controls.Add(this.lbTongDT);
            this.tabPhim.Location = new System.Drawing.Point(4, 38);
            this.tabPhim.Name = "tabPhim";
            this.tabPhim.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhim.Size = new System.Drawing.Size(1874, 856);
            this.tabPhim.TabIndex = 0;
            this.tabPhim.Text = "Phim";
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btTimKiem.Location = new System.Drawing.Point(768, 133);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(288, 62);
            this.btTimKiem.TabIndex = 29;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // dtpNKT
            // 
            this.dtpNKT.CustomFormat = "dd/MM/yyyy";
            this.dtpNKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNKT.Location = new System.Drawing.Point(768, 29);
            this.dtpNKT.Name = "dtpNKT";
            this.dtpNKT.Size = new System.Drawing.Size(288, 36);
            this.dtpNKT.TabIndex = 26;
            // 
            // dtbNBD
            // 
            this.dtbNBD.CustomFormat = "dd/MM/yyyy";
            this.dtbNBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbNBD.Location = new System.Drawing.Point(243, 29);
            this.dtbNBD.Name = "dtbNBD";
            this.dtbNBD.Size = new System.Drawing.Size(288, 36);
            this.dtbNBD.TabIndex = 26;
            // 
            // cbLoaiTG
            // 
            this.cbLoaiTG.FormattingEnabled = true;
            this.cbLoaiTG.Items.AddRange(new object[] {
            "Theongay",
            "Theothang",
            "Theonam"});
            this.cbLoaiTG.Location = new System.Drawing.Point(243, 141);
            this.cbLoaiTG.Name = "cbLoaiTG";
            this.cbLoaiTG.Size = new System.Drawing.Size(288, 37);
            this.cbLoaiTG.TabIndex = 25;
            this.cbLoaiTG.SelectedIndexChanged += new System.EventHandler(this.cbLoaiTG_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Loại thời gian";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabTongQuan1);
            this.tabControl2.Controls.Add(this.tabChiTiet1);
            this.tabControl2.Location = new System.Drawing.Point(-2, 282);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1871, 569);
            this.tabControl2.TabIndex = 0;
            // 
            // tabTongQuan1
            // 
            this.tabTongQuan1.Controls.Add(this.DoanhThu);
            this.tabTongQuan1.Location = new System.Drawing.Point(4, 38);
            this.tabTongQuan1.Name = "tabTongQuan1";
            this.tabTongQuan1.Padding = new System.Windows.Forms.Padding(3);
            this.tabTongQuan1.Size = new System.Drawing.Size(1863, 527);
            this.tabTongQuan1.TabIndex = 0;
            this.tabTongQuan1.Text = "Tổng Quan";
            this.tabTongQuan1.UseVisualStyleBackColor = true;
            // 
            // DoanhThu
            // 
            chartArea4.Name = "ChartArea1";
            this.DoanhThu.ChartAreas.Add(chartArea4);
            this.DoanhThu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend4.Name = "Legend1";
            this.DoanhThu.Legends.Add(legend4);
            this.DoanhThu.Location = new System.Drawing.Point(6, 6);
            this.DoanhThu.Name = "DoanhThu";
            this.DoanhThu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "DoanhThu";
            this.DoanhThu.Series.Add(series4);
            this.DoanhThu.Size = new System.Drawing.Size(1837, 515);
            this.DoanhThu.TabIndex = 0;
            this.DoanhThu.Text = "chart1";
            // 
            // tabChiTiet1
            // 
            this.tabChiTiet1.Controls.Add(this.datagridvPhim);
            this.tabChiTiet1.Controls.Add(this.cbLoc);
            this.tabChiTiet1.Controls.Add(this.button3);
            this.tabChiTiet1.Controls.Add(this.label4);
            this.tabChiTiet1.Location = new System.Drawing.Point(4, 38);
            this.tabChiTiet1.Name = "tabChiTiet1";
            this.tabChiTiet1.Padding = new System.Windows.Forms.Padding(3);
            this.tabChiTiet1.Size = new System.Drawing.Size(1863, 527);
            this.tabChiTiet1.TabIndex = 1;
            this.tabChiTiet1.Text = "Chi Tiết";
            this.tabChiTiet1.UseVisualStyleBackColor = true;
            // 
            // datagridvPhim
            // 
            this.datagridvPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridvPhim.Location = new System.Drawing.Point(6, 49);
            this.datagridvPhim.MultiSelect = false;
            this.datagridvPhim.Name = "datagridvPhim";
            this.datagridvPhim.RowHeadersWidth = 51;
            this.datagridvPhim.RowTemplate.Height = 40;
            this.datagridvPhim.RowTemplate.ReadOnly = true;
            this.datagridvPhim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridvPhim.Size = new System.Drawing.Size(1850, 472);
            this.datagridvPhim.TabIndex = 46;
            // 
            // cbLoc
            // 
            this.cbLoc.FormattingEnabled = true;
            this.cbLoc.Items.AddRange(new object[] {
            "Theo số tiền thấp đến cao",
            "Theo số tiền cao đến thấp",
            "Theo ngày thấp đến cao",
            "Theo ngày cao đến thấp"});
            this.cbLoc.Location = new System.Drawing.Point(1379, 6);
            this.cbLoc.Name = "cbLoc";
            this.cbLoc.Size = new System.Drawing.Size(361, 37);
            this.cbLoc.TabIndex = 28;
            this.cbLoc.SelectedIndexChanged += new System.EventHandler(this.cbLoc_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Turquoise;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1749, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 34);
            this.button3.TabIndex = 44;
            this.button3.Text = "In báo cáo";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1319, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Lọc";
            // 
            // FormDoanhThuQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1942, 968);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbTongDoanhThu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDoanhThuQL";
            this.Text = "FormDoanhThuQL";
            this.Load += new System.EventHandler(this.FormDoanhThuQL_Load);
            this.lbTongDT.ResumeLayout(false);
            this.lbTongDT.PerformLayout();
            this.lbTongDonHang.ResumeLayout(false);
            this.lbTongDonHang.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPhim.ResumeLayout(false);
            this.tabPhim.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabTongQuan1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThu)).EndInit();
            this.tabChiTiet1.ResumeLayout(false);
            this.tabChiTiet1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridvPhim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTongDoanhThu;
        private System.Windows.Forms.Panel lbTongDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel lbTongDonHang;
        private System.Windows.Forms.Label lbHD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPhim;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabTongQuan1;
        private System.Windows.Forms.TabPage tabChiTiet1;
        private System.Windows.Forms.ComboBox cbLoc;
        private System.Windows.Forms.DateTimePicker dtpNKT;
        private System.Windows.Forms.DateTimePicker dtbNBD;
        private System.Windows.Forms.ComboBox cbLoaiTG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart DoanhThu;
        private System.Windows.Forms.DataGridView datagridvPhim;
    }
}
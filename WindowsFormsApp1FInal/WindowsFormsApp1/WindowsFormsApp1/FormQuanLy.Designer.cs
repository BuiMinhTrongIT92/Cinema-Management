
namespace WindowsFormsApp1
{
    partial class FormQuanLy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btLogOutQL = new FontAwesome.Sharp.IconButton();
            this.btLichChieu = new System.Windows.Forms.Button();
            this.btKhachHang = new System.Windows.Forms.Button();
            this.btNhanVien = new System.Windows.Forms.Button();
            this.btPhim = new System.Windows.Forms.Button();
            this.btDoanhThu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btLogOutQL);
            this.panel1.Controls.Add(this.btLichChieu);
            this.panel1.Controls.Add(this.btKhachHang);
            this.panel1.Controls.Add(this.btNhanVien);
            this.panel1.Controls.Add(this.btPhim);
            this.panel1.Controls.Add(this.btDoanhThu);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 148);
            this.panel1.TabIndex = 2;
            // 
            // btLogOutQL
            // 
            this.btLogOutQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.btLogOutQL.FlatAppearance.BorderSize = 0;
            this.btLogOutQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogOutQL.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogOutQL.ForeColor = System.Drawing.Color.PaleGreen;
            this.btLogOutQL.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btLogOutQL.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(164)))), ((int)(((byte)(201)))));
            this.btLogOutQL.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btLogOutQL.IconSize = 30;
            this.btLogOutQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogOutQL.Location = new System.Drawing.Point(1691, 49);
            this.btLogOutQL.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btLogOutQL.Name = "btLogOutQL";
            this.btLogOutQL.Size = new System.Drawing.Size(175, 48);
            this.btLogOutQL.TabIndex = 9;
            this.btLogOutQL.Text = "LogOut";
            this.btLogOutQL.UseVisualStyleBackColor = false;
            this.btLogOutQL.Click += new System.EventHandler(this.btLogOutQL_Click);
            // 
            // btLichChieu
            // 
            this.btLichChieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btLichChieu.FlatAppearance.BorderSize = 0;
            this.btLichChieu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(89)))), ((int)(((byte)(98)))));
            this.btLichChieu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(49)))), ((int)(((byte)(76)))));
            this.btLichChieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLichChieu.ForeColor = System.Drawing.Color.White;
            this.btLichChieu.Location = new System.Drawing.Point(1258, 3);
            this.btLichChieu.Name = "btLichChieu";
            this.btLichChieu.Size = new System.Drawing.Size(167, 148);
            this.btLichChieu.TabIndex = 10;
            this.btLichChieu.Text = "Lịch Chiếu";
            this.btLichChieu.UseVisualStyleBackColor = false;
            this.btLichChieu.Click += new System.EventHandler(this.btDoanhThu_Click);
            // 
            // btKhachHang
            // 
            this.btKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btKhachHang.FlatAppearance.BorderSize = 0;
            this.btKhachHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(89)))), ((int)(((byte)(98)))));
            this.btKhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(49)))), ((int)(((byte)(76)))));
            this.btKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btKhachHang.ForeColor = System.Drawing.Color.White;
            this.btKhachHang.Location = new System.Drawing.Point(1047, 3);
            this.btKhachHang.Name = "btKhachHang";
            this.btKhachHang.Size = new System.Drawing.Size(167, 148);
            this.btKhachHang.TabIndex = 10;
            this.btKhachHang.Text = "Khách Hàng";
            this.btKhachHang.UseVisualStyleBackColor = false;
            this.btKhachHang.Click += new System.EventHandler(this.btDoanhThu_Click);
            // 
            // btNhanVien
            // 
            this.btNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btNhanVien.FlatAppearance.BorderSize = 0;
            this.btNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(89)))), ((int)(((byte)(98)))));
            this.btNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(49)))), ((int)(((byte)(76)))));
            this.btNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNhanVien.ForeColor = System.Drawing.Color.White;
            this.btNhanVien.Location = new System.Drawing.Point(812, 3);
            this.btNhanVien.Name = "btNhanVien";
            this.btNhanVien.Size = new System.Drawing.Size(167, 148);
            this.btNhanVien.TabIndex = 10;
            this.btNhanVien.Text = "Nhân Viên";
            this.btNhanVien.UseVisualStyleBackColor = false;
            this.btNhanVien.Click += new System.EventHandler(this.btDoanhThu_Click);
            // 
            // btPhim
            // 
            this.btPhim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btPhim.FlatAppearance.BorderSize = 0;
            this.btPhim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(89)))), ((int)(((byte)(98)))));
            this.btPhim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(49)))), ((int)(((byte)(76)))));
            this.btPhim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPhim.ForeColor = System.Drawing.Color.White;
            this.btPhim.Location = new System.Drawing.Point(608, 3);
            this.btPhim.Name = "btPhim";
            this.btPhim.Size = new System.Drawing.Size(167, 148);
            this.btPhim.TabIndex = 10;
            this.btPhim.Text = "Phim";
            this.btPhim.UseVisualStyleBackColor = false;
            this.btPhim.Click += new System.EventHandler(this.btDoanhThu_Click);
            // 
            // btDoanhThu
            // 
            this.btDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btDoanhThu.FlatAppearance.BorderSize = 0;
            this.btDoanhThu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(89)))), ((int)(((byte)(98)))));
            this.btDoanhThu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(49)))), ((int)(((byte)(76)))));
            this.btDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btDoanhThu.Location = new System.Drawing.Point(375, 3);
            this.btDoanhThu.Name = "btDoanhThu";
            this.btDoanhThu.Size = new System.Drawing.Size(167, 145);
            this.btDoanhThu.TabIndex = 10;
            this.btDoanhThu.Text = "Doanh Thu";
            this.btDoanhThu.UseVisualStyleBackColor = false;
            this.btDoanhThu.Click += new System.EventHandler(this.btDoanhThu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 109);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 148);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1924, 710);
            this.pnMain.TabIndex = 3;
            // 
            // FormQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 858);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FormQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuanLy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormQuanLy_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btKhachHang;
        private System.Windows.Forms.Button btNhanVien;
        private System.Windows.Forms.Button btPhim;
        private System.Windows.Forms.Button btDoanhThu;
        private FontAwesome.Sharp.IconButton btLogOutQL;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button btLichChieu;
    }
}
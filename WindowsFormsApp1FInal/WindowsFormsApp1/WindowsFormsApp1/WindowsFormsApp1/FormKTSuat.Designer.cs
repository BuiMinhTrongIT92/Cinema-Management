
namespace WindowsFormsApp1
{
    partial class FormKTSuat
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
            this.dtgKTSuat = new System.Windows.Forms.DataGridView();
            this.ptAnhDemo = new System.Windows.Forms.PictureBox();
            this.lbTrong = new System.Windows.Forms.Label();
            this.lbDaDat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTenPhim = new System.Windows.Forms.Label();
            this.lbRap = new System.Windows.Forms.Label();
            this.lbTGChieu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKTSuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptAnhDemo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgKTSuat
            // 
            this.dtgKTSuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKTSuat.Location = new System.Drawing.Point(418, 12);
            this.dtgKTSuat.Name = "dtgKTSuat";
            this.dtgKTSuat.RowHeadersWidth = 51;
            this.dtgKTSuat.RowTemplate.Height = 40;
            this.dtgKTSuat.RowTemplate.ReadOnly = true;
            this.dtgKTSuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgKTSuat.Size = new System.Drawing.Size(757, 649);
            this.dtgKTSuat.TabIndex = 1;
            this.dtgKTSuat.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKTSuat_CellContentDoubleClick);
            this.dtgKTSuat.SelectionChanged += new System.EventHandler(this.dtgKTSuat_SelectionChanged);
            // 
            // ptAnhDemo
            // 
            this.ptAnhDemo.Location = new System.Drawing.Point(80, 12);
            this.ptAnhDemo.Name = "ptAnhDemo";
            this.ptAnhDemo.Size = new System.Drawing.Size(244, 326);
            this.ptAnhDemo.TabIndex = 0;
            this.ptAnhDemo.TabStop = false;
            // 
            // lbTrong
            // 
            this.lbTrong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(191)))), ((int)(((byte)(84)))));
            this.lbTrong.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrong.ForeColor = System.Drawing.Color.MintCream;
            this.lbTrong.Location = new System.Drawing.Point(301, 358);
            this.lbTrong.Name = "lbTrong";
            this.lbTrong.Size = new System.Drawing.Size(97, 60);
            this.lbTrong.TabIndex = 2;
            this.lbTrong.Text = "91";
            this.lbTrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDaDat
            // 
            this.lbDaDat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.lbDaDat.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbDaDat.ForeColor = System.Drawing.Color.MintCream;
            this.lbDaDat.Location = new System.Drawing.Point(301, 443);
            this.lbDaDat.Name = "lbDaDat";
            this.lbDaDat.Size = new System.Drawing.Size(97, 58);
            this.lbDaDat.TabIndex = 2;
            this.lbDaDat.Text = "3";
            this.lbDaDat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(214, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Trống";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(239, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đặt";
            // 
            // lbTenPhim
            // 
            this.lbTenPhim.AutoSize = true;
            this.lbTenPhim.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenPhim.ForeColor = System.Drawing.Color.White;
            this.lbTenPhim.Location = new System.Drawing.Point(118, 526);
            this.lbTenPhim.Name = "lbTenPhim";
            this.lbTenPhim.Size = new System.Drawing.Size(0, 22);
            this.lbTenPhim.TabIndex = 14;
            // 
            // lbRap
            // 
            this.lbRap.AutoSize = true;
            this.lbRap.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRap.ForeColor = System.Drawing.Color.White;
            this.lbRap.Location = new System.Drawing.Point(118, 617);
            this.lbRap.Name = "lbRap";
            this.lbRap.Size = new System.Drawing.Size(0, 22);
            this.lbRap.TabIndex = 13;
            // 
            // lbTGChieu
            // 
            this.lbTGChieu.AutoSize = true;
            this.lbTGChieu.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTGChieu.ForeColor = System.Drawing.Color.White;
            this.lbTGChieu.Location = new System.Drawing.Point(180, 574);
            this.lbTGChieu.Name = "lbTGChieu";
            this.lbTGChieu.Size = new System.Drawing.Size(0, 22);
            this.lbTGChieu.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 617);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rạp số:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 574);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Thời gian chiếu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 526);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tên phim:";
            // 
            // FormKTSuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1187, 673);
            this.Controls.Add(this.lbTenPhim);
            this.Controls.Add(this.lbRap);
            this.Controls.Add(this.lbTGChieu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbDaDat);
            this.Controls.Add(this.lbTrong);
            this.Controls.Add(this.dtgKTSuat);
            this.Controls.Add(this.ptAnhDemo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormKTSuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormKTSuat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKTSuat_FormClosed);
            this.Load += new System.EventHandler(this.FormKTSuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKTSuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptAnhDemo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptAnhDemo;
        private System.Windows.Forms.DataGridView dtgKTSuat;
        private System.Windows.Forms.Label lbTrong;
        private System.Windows.Forms.Label lbDaDat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTenPhim;
        private System.Windows.Forms.Label lbRap;
        private System.Windows.Forms.Label lbTGChieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
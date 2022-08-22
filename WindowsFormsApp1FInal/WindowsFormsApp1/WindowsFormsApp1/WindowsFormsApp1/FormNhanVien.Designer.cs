
namespace WindowsFormsApp1
{
    partial class FormNhanVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btBanVe = new FontAwesome.Sharp.IconButton();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTicketSales = new System.Windows.Forms.Label();
            this.btSetting = new FontAwesome.Sharp.IconButton();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btMyProfile = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnMain = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btLogOut = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.btBanVe);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 820);
            this.panel1.TabIndex = 0;
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(164)))), ((int)(((byte)(201)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.TicketAlt;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(164)))), ((int)(((byte)(201)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 60;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 498);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(205, 322);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Text = "  Thức ăn";
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // btBanVe
            // 
            this.btBanVe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btBanVe.FlatAppearance.BorderSize = 0;
            this.btBanVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBanVe.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBanVe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(164)))), ((int)(((byte)(201)))));
            this.btBanVe.IconChar = FontAwesome.Sharp.IconChar.TicketAlt;
            this.btBanVe.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(164)))), ((int)(((byte)(201)))));
            this.btBanVe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btBanVe.IconSize = 60;
            this.btBanVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBanVe.Location = new System.Drawing.Point(0, 212);
            this.btBanVe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btBanVe.Name = "btBanVe";
            this.btBanVe.Size = new System.Drawing.Size(205, 374);
            this.btBanVe.TabIndex = 1;
            this.btBanVe.Text = "Vé";
            this.btBanVe.UseVisualStyleBackColor = true;
            this.btBanVe.Click += new System.EventHandler(this.btBanVe_Click);
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.Image = global::WindowsFormsApp1.Properties.Resources.Logo;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Padding = new System.Windows.Forms.Padding(44, 50, 44, 50);
            this.picLogo.Size = new System.Drawing.Size(205, 212);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btSetting);
            this.panel2.Controls.Add(this.lbTenNV);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btMyProfile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(205, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1265, 125);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbTicketSales);
            this.panel3.Location = new System.Drawing.Point(6, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(684, 100);
            this.panel3.TabIndex = 5;
            // 
            // lbTicketSales
            // 
            this.lbTicketSales.AutoSize = true;
            this.lbTicketSales.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTicketSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(164)))), ((int)(((byte)(201)))));
            this.lbTicketSales.Location = new System.Drawing.Point(51, 23);
            this.lbTicketSales.Name = "lbTicketSales";
            this.lbTicketSales.Size = new System.Drawing.Size(325, 57);
            this.lbTicketSales.TabIndex = 5;
            this.lbTicketSales.Text = "Ticket sales";
            // 
            // btSetting
            // 
            this.btSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.btSetting.FlatAppearance.BorderSize = 0;
            this.btSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSetting.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(164)))), ((int)(((byte)(201)))));
            this.btSetting.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btSetting.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(164)))), ((int)(((byte)(201)))));
            this.btSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btSetting.IconSize = 30;
            this.btSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSetting.Location = new System.Drawing.Point(1006, 77);
            this.btSetting.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btSetting.Name = "btSetting";
            this.btSetting.Size = new System.Drawing.Size(175, 48);
            this.btSetting.TabIndex = 3;
            this.btSetting.Text = "Setting";
            this.btSetting.UseVisualStyleBackColor = false;
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNV.ForeColor = System.Drawing.Color.White;
            this.lbTenNV.Location = new System.Drawing.Point(866, 46);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(0, 29);
            this.lbTenNV.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(164)))), ((int)(((byte)(201)))));
            this.label1.Location = new System.Drawing.Point(696, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Xin chào:";
            // 
            // btMyProfile
            // 
            this.btMyProfile.FlatAppearance.BorderSize = 0;
            this.btMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMyProfile.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMyProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(164)))), ((int)(((byte)(201)))));
            this.btMyProfile.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            this.btMyProfile.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(164)))), ((int)(((byte)(201)))));
            this.btMyProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btMyProfile.IconSize = 30;
            this.btMyProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMyProfile.Location = new System.Drawing.Point(1003, 0);
            this.btMyProfile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btMyProfile.Name = "btMyProfile";
            this.btMyProfile.Size = new System.Drawing.Size(178, 125);
            this.btMyProfile.TabIndex = 2;
            this.btMyProfile.Text = "My Profile";
            this.btMyProfile.UseVisualStyleBackColor = true;
            this.btMyProfile.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMain.Controls.Add(this.iconButton1);
            this.pnMain.Controls.Add(this.groupBox1);
            this.pnMain.Controls.Add(this.panel4);
            this.pnMain.Controls.Add(this.iconButton5);
            this.pnMain.Controls.Add(this.iconButton3);
            this.pnMain.Controls.Add(this.listView1);
            this.pnMain.Controls.Add(this.btLogOut);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(205, 125);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1265, 695);
            this.pnMain.TabIndex = 4;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(164)))), ((int)(((byte)(201)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(1078, 348);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(175, 71);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.Text = "In";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(491, 531);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 175);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách hàng thân thiết";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 36);
            this.textBox2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số lần mua:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã khách hàng:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lbTongTien);
            this.panel4.Location = new System.Drawing.Point(22, 544);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(463, 162);
            this.panel4.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số tiền phải trả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giảm giá:";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.ForeColor = System.Drawing.Color.Black;
            this.lbTongTien.Location = new System.Drawing.Point(20, 18);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(143, 29);
            this.lbTongTien.TabIndex = 5;
            this.lbTongTien.Text = "Thành tiền:";
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.LimeGreen;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.Black;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton5.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(164)))), ((int)(((byte)(201)))));
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 30;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(952, 612);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(265, 65);
            this.iconButton5.TabIndex = 7;
            this.iconButton5.Text = "Thanh Toán";
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.Turquoise;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(164)))), ((int)(((byte)(201)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(1078, 425);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(175, 71);
            this.iconButton3.TabIndex = 6;
            this.iconButton3.Text = "Xóa";
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(36, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1037, 473);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btLogOut
            // 
            this.btLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.btLogOut.FlatAppearance.BorderSize = 0;
            this.btLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogOut.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogOut.ForeColor = System.Drawing.Color.Red;
            this.btLogOut.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btLogOut.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(164)))), ((int)(((byte)(201)))));
            this.btLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btLogOut.IconSize = 30;
            this.btLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogOut.Location = new System.Drawing.Point(1005, 3);
            this.btLogOut.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btLogOut.Name = "btLogOut";
            this.btLogOut.Size = new System.Drawing.Size(175, 48);
            this.btLogOut.TabIndex = 3;
            this.btLogOut.Text = "LogOut";
            this.btLogOut.UseVisualStyleBackColor = false;
            this.btLogOut.Click += new System.EventHandler(this.btLogOut_Click);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 820);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picLogo;
        private FontAwesome.Sharp.IconButton btBanVe;
        private FontAwesome.Sharp.IconButton btMyProfile;
        private FontAwesome.Sharp.IconButton btSetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTicketSales;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton btLogOut;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbTenNV;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}



namespace WindowsFormsApp1
{
    partial class FormLichChieu
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
            this.dataGridViewQLLC = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtbNgayKC = new System.Windows.Forms.DateTimePicker();
            this.dtbNgayKT = new System.Windows.Forms.DateTimePicker();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.txtMaLC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpTGBD = new System.Windows.Forms.DateTimePicker();
            this.dtpTGKT = new System.Windows.Forms.DateTimePicker();
            this.txtMaLC1 = new System.Windows.Forms.TextBox();
            this.txtMaRap = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtMaSC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewQLSC = new System.Windows.Forms.DataGridView();
            this.btXoaLC = new System.Windows.Forms.Button();
            this.btSuaLC = new System.Windows.Forms.Button();
            this.btThemLC = new System.Windows.Forms.Button();
            this.btThemSC = new System.Windows.Forms.Button();
            this.btSuaSC = new System.Windows.Forms.Button();
            this.btXoaSC = new System.Windows.Forms.Button();
            this.searchLC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.searchSC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLLC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLSC)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQLLC
            // 
            this.dataGridViewQLLC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQLLC.Location = new System.Drawing.Point(38, 236);
            this.dataGridViewQLLC.Name = "dataGridViewQLLC";
            this.dataGridViewQLLC.RowHeadersWidth = 51;
            this.dataGridViewQLLC.RowTemplate.Height = 40;
            this.dataGridViewQLLC.RowTemplate.ReadOnly = true;
            this.dataGridViewQLLC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQLLC.Size = new System.Drawing.Size(899, 511);
            this.dataGridViewQLLC.TabIndex = 14;
            this.dataGridViewQLLC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQLLC_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtbNgayKC);
            this.groupBox1.Controls.Add(this.dtbNgayKT);
            this.groupBox1.Controls.Add(this.txtMaPhim);
            this.groupBox1.Controls.Add(this.txtMaLC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(38, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(899, 218);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lịch chiếu";
            // 
            // dtbNgayKC
            // 
            this.dtbNgayKC.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbNgayKC.CustomFormat = "dd/MM/yyyy";
            this.dtbNgayKC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbNgayKC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbNgayKC.Location = new System.Drawing.Point(222, 149);
            this.dtbNgayKC.Name = "dtbNgayKC";
            this.dtbNgayKC.Size = new System.Drawing.Size(228, 22);
            this.dtbNgayKC.TabIndex = 11;
            // 
            // dtbNgayKT
            // 
            this.dtbNgayKT.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dtbNgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbNgayKT.Location = new System.Drawing.Point(666, 149);
            this.dtbNgayKT.Name = "dtbNgayKT";
            this.dtbNgayKT.Size = new System.Drawing.Size(199, 22);
            this.dtbNgayKT.TabIndex = 11;
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhim.Location = new System.Drawing.Point(666, 73);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(199, 28);
            this.txtMaPhim.TabIndex = 2;
            // 
            // txtMaLC
            // 
            this.txtMaLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLC.Location = new System.Drawing.Point(222, 71);
            this.txtMaLC.Name = "txtMaLC";
            this.txtMaLC.Size = new System.Drawing.Size(228, 28);
            this.txtMaLC.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(471, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày kết thúc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày khởi chiếu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(526, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã phim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã lịch chiếu:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpTGBD);
            this.groupBox2.Controls.Add(this.dtpTGKT);
            this.groupBox2.Controls.Add(this.txtMaLC1);
            this.groupBox2.Controls.Add(this.txtMaRap);
            this.groupBox2.Controls.Add(this.txtGia);
            this.groupBox2.Controls.Add(this.txtMaSC);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(988, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(899, 218);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin suất chiếu";
            // 
            // dtpTGBD
            // 
            this.dtpTGBD.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTGBD.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpTGBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTGBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTGBD.Location = new System.Drawing.Point(213, 106);
            this.dtpTGBD.Name = "dtpTGBD";
            this.dtpTGBD.Size = new System.Drawing.Size(228, 22);
            this.dtpTGBD.TabIndex = 18;
            this.dtpTGBD.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpTGKT
            // 
            this.dtpTGKT.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTGKT.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpTGKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTGKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTGKT.Location = new System.Drawing.Point(657, 106);
            this.dtpTGKT.Name = "dtpTGKT";
            this.dtpTGKT.Size = new System.Drawing.Size(228, 22);
            this.dtpTGKT.TabIndex = 19;
            // 
            // txtMaLC1
            // 
            this.txtMaLC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLC1.Location = new System.Drawing.Point(658, 41);
            this.txtMaLC1.Name = "txtMaLC1";
            this.txtMaLC1.Size = new System.Drawing.Size(228, 28);
            this.txtMaLC1.TabIndex = 16;
            // 
            // txtMaRap
            // 
            this.txtMaRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaRap.Location = new System.Drawing.Point(657, 167);
            this.txtMaRap.Name = "txtMaRap";
            this.txtMaRap.Size = new System.Drawing.Size(228, 28);
            this.txtMaRap.TabIndex = 17;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(213, 165);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(228, 28);
            this.txtGia.TabIndex = 17;
            // 
            // txtMaSC
            // 
            this.txtMaSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSC.Location = new System.Drawing.Point(214, 39);
            this.txtMaSC.Name = "txtMaSC";
            this.txtMaSC.Size = new System.Drawing.Size(228, 28);
            this.txtMaSC.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(470, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày kết thúc:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(543, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 29);
            this.label10.TabIndex = 13;
            this.label10.Text = "Mã rạp:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.White;
            this.lb.Location = new System.Drawing.Point(152, 163);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(60, 29);
            this.lb.TabIndex = 13;
            this.lb.Text = "Giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ngày khởi chiếu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(477, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mã lịch chiếu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(46, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mã suất chiếu:";
            // 
            // dataGridViewQLSC
            // 
            this.dataGridViewQLSC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQLSC.Location = new System.Drawing.Point(988, 236);
            this.dataGridViewQLSC.Name = "dataGridViewQLSC";
            this.dataGridViewQLSC.RowHeadersWidth = 51;
            this.dataGridViewQLSC.RowTemplate.Height = 40;
            this.dataGridViewQLSC.RowTemplate.ReadOnly = true;
            this.dataGridViewQLSC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQLSC.Size = new System.Drawing.Size(899, 511);
            this.dataGridViewQLSC.TabIndex = 14;
            this.dataGridViewQLSC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQLSC_CellContentClick);
            // 
            // btXoaLC
            // 
            this.btXoaLC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(161)))), ((int)(((byte)(234)))));
            this.btXoaLC.FlatAppearance.BorderSize = 0;
            this.btXoaLC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(208)))), ((int)(((byte)(250)))));
            this.btXoaLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoaLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaLC.ForeColor = System.Drawing.Color.White;
            this.btXoaLC.Location = new System.Drawing.Point(434, 763);
            this.btXoaLC.Name = "btXoaLC";
            this.btXoaLC.Size = new System.Drawing.Size(177, 48);
            this.btXoaLC.TabIndex = 18;
            this.btXoaLC.Text = "Xóa";
            this.btXoaLC.UseVisualStyleBackColor = false;
            this.btXoaLC.Click += new System.EventHandler(this.btXoaLC_Click);
            // 
            // btSuaLC
            // 
            this.btSuaLC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(161)))), ((int)(((byte)(234)))));
            this.btSuaLC.FlatAppearance.BorderSize = 0;
            this.btSuaLC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(208)))), ((int)(((byte)(250)))));
            this.btSuaLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSuaLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaLC.ForeColor = System.Drawing.Color.White;
            this.btSuaLC.Location = new System.Drawing.Point(235, 763);
            this.btSuaLC.Name = "btSuaLC";
            this.btSuaLC.Size = new System.Drawing.Size(177, 48);
            this.btSuaLC.TabIndex = 19;
            this.btSuaLC.Text = "Sửa";
            this.btSuaLC.UseVisualStyleBackColor = false;
            this.btSuaLC.Click += new System.EventHandler(this.btSuaLC_Click);
            // 
            // btThemLC
            // 
            this.btThemLC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(161)))), ((int)(((byte)(234)))));
            this.btThemLC.FlatAppearance.BorderSize = 0;
            this.btThemLC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(208)))), ((int)(((byte)(250)))));
            this.btThemLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemLC.ForeColor = System.Drawing.Color.White;
            this.btThemLC.Location = new System.Drawing.Point(38, 763);
            this.btThemLC.Name = "btThemLC";
            this.btThemLC.Size = new System.Drawing.Size(177, 48);
            this.btThemLC.TabIndex = 20;
            this.btThemLC.Text = "Thêm";
            this.btThemLC.UseVisualStyleBackColor = false;
            this.btThemLC.Click += new System.EventHandler(this.btThemLC_Click);
            // 
            // btThemSC
            // 
            this.btThemSC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(188)))));
            this.btThemSC.FlatAppearance.BorderSize = 0;
            this.btThemSC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(208)))), ((int)(((byte)(250)))));
            this.btThemSC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemSC.ForeColor = System.Drawing.Color.White;
            this.btThemSC.Location = new System.Drawing.Point(988, 763);
            this.btThemSC.Name = "btThemSC";
            this.btThemSC.Size = new System.Drawing.Size(177, 48);
            this.btThemSC.TabIndex = 20;
            this.btThemSC.Text = "Thêm";
            this.btThemSC.UseVisualStyleBackColor = false;
            this.btThemSC.Click += new System.EventHandler(this.btThemSC_Click);
            // 
            // btSuaSC
            // 
            this.btSuaSC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(188)))));
            this.btSuaSC.FlatAppearance.BorderSize = 0;
            this.btSuaSC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(208)))), ((int)(((byte)(250)))));
            this.btSuaSC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSuaSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaSC.ForeColor = System.Drawing.Color.White;
            this.btSuaSC.Location = new System.Drawing.Point(1185, 763);
            this.btSuaSC.Name = "btSuaSC";
            this.btSuaSC.Size = new System.Drawing.Size(177, 48);
            this.btSuaSC.TabIndex = 19;
            this.btSuaSC.Text = "Sửa";
            this.btSuaSC.UseVisualStyleBackColor = false;
            this.btSuaSC.Click += new System.EventHandler(this.btSuaSC_Click);
            // 
            // btXoaSC
            // 
            this.btXoaSC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(188)))));
            this.btXoaSC.FlatAppearance.BorderSize = 0;
            this.btXoaSC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(208)))), ((int)(((byte)(250)))));
            this.btXoaSC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoaSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaSC.ForeColor = System.Drawing.Color.White;
            this.btXoaSC.Location = new System.Drawing.Point(1384, 763);
            this.btXoaSC.Name = "btXoaSC";
            this.btXoaSC.Size = new System.Drawing.Size(177, 48);
            this.btXoaSC.TabIndex = 18;
            this.btXoaSC.Text = "Xóa";
            this.btXoaSC.UseVisualStyleBackColor = false;
            this.btXoaSC.Click += new System.EventHandler(this.btXoaSC_Click);
            // 
            // searchLC
            // 
            this.searchLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLC.Location = new System.Drawing.Point(635, 767);
            this.searchLC.Name = "searchLC";
            this.searchLC.Size = new System.Drawing.Size(256, 36);
            this.searchLC.TabIndex = 21;
            this.searchLC.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(891, 764);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 39);
            this.label11.TabIndex = 22;
            this.label11.Text = "🔍";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1838, 764);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 39);
            this.label9.TabIndex = 24;
            this.label9.Text = "🔍";
            // 
            // searchSC
            // 
            this.searchSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSC.Location = new System.Drawing.Point(1582, 767);
            this.searchSC.Name = "searchSC";
            this.searchSC.Size = new System.Drawing.Size(256, 36);
            this.searchSC.TabIndex = 23;
            this.searchSC.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormLichChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1942, 1008);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.searchSC);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.searchLC);
            this.Controls.Add(this.btXoaSC);
            this.Controls.Add(this.btXoaLC);
            this.Controls.Add(this.btSuaSC);
            this.Controls.Add(this.btSuaLC);
            this.Controls.Add(this.btThemSC);
            this.Controls.Add(this.btThemLC);
            this.Controls.Add(this.dataGridViewQLSC);
            this.Controls.Add(this.dataGridViewQLLC);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLichChieu";
            this.Text = "FormLichChieu";
            this.Load += new System.EventHandler(this.FormLichChieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLLC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLSC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQLLC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtbNgayKT;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.TextBox txtMaLC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtbNgayKC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewQLSC;
        private System.Windows.Forms.Button btXoaLC;
        private System.Windows.Forms.Button btSuaLC;
        private System.Windows.Forms.Button btThemLC;
        private System.Windows.Forms.Button btThemSC;
        private System.Windows.Forms.Button btSuaSC;
        private System.Windows.Forms.Button btXoaSC;
        private System.Windows.Forms.DateTimePicker dtpTGBD;
        private System.Windows.Forms.DateTimePicker dtpTGKT;
        private System.Windows.Forms.TextBox txtMaLC1;
        private System.Windows.Forms.TextBox txtMaRap;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtMaSC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox searchLC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox searchSC;
    }
}
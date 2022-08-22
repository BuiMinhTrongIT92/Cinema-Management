using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        FormNhanVien fnvv;
        FormQuanLy fql;
        public static string tenQL = "";
        public static string maNV = "";
        public FormLogin()
        {
            InitializeComponent();
        }
       
        string connectLink = @"Data Source=LAPTOP-RPIGMS1F;Initial Catalog=QLBanVe;Integrated Security=True";
        SqlConnection connectt;
        string path = Application.StartupPath + @"\Resource\phim\";
        private void FormLogin_Load(object sender, EventArgs e)
        {
            connectt = new SqlConnection(connectLink);
            connectt.Open();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackgroundImage = Image.FromFile(path + "darkblue.jpg");
            pictureBox1.BackgroundImage = Image.FromFile(path + "Logo.png");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        string ChucV;
        string TK;
        string MK;
        private void button1_Click(object sender, EventArgs e)
        {
            ChucV = cbChucVu.Text;
            TK =  txtTK.Text;
            MK = txtMK.Text;
            string qĐN = "Select * from NhanVien where TenTK = '" + TK + "' and MatKhau= '" + MK + "' and CapBac = '" + ChucV + "'";
            DataTable dataTable = ConnectFun.RunQuery(qĐN);
            if (dataTable.Rows.Count > 0)
            {
                if (dataTable.Rows[0][8].ToString() == "NhanVien")
                {
                    fnvv = new FormNhanVien();
                    FormNhanVien.tennv = dataTable.Rows[0][1].ToString();
                    maNV = dataTable.Rows[0][0].ToString();
                    fnvv.ShowDialog();
                }
                if (dataTable.Rows[0][8].ToString() == "QuanLy")
                {
                    fql = new FormQuanLy();
                    FormQuanLy.tenQL = dataTable.Rows[0][1].ToString();
                    fql.ShowDialog();
                }
            }
            else
                MessageBox.Show("Sai tài khoản");
        }
        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                
                if (cbChucVu.Text == "Nhân viên" && txtTK.Text == "MinhTrong"
                && txtMK.Text == "trong")
                {
                    FormNhanVien.tennv = txtTK.Text;
                    fnvv.ShowDialog();
                }
                else if (cbChucVu.Text == "Quản lý" && txtTK.Text == "MinhSang"
                    && txtMK.Text == "sang")
                {
                    FormQuanLy.tenQL = txtTK.Text;
                    fql.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập !!!", "Thông báo");
                }
            }
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

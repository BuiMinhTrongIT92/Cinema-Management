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

namespace WindowsFormsApp1
{
    public partial class FormNhanVien : Form
    {
      
        public static FormChonCho cc;
        FormThucAn ThucAn;
        public FormNhanVien()
        {
            InitializeComponent();
        }
        public void LoadListKhachHang()
        {

            string query = "Select * From KhachHang";

            dataGridViewKH.DataSource = ConnectFun.RunQuery(query);

            dataGridViewKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        bool IscheckTextBox()
        {
            if (txtMaKH.Text != "" && txtTenKH.Text != "" && dtNgaySinhKH.Text != ""
                && txtDiaChiKH.Text != "" && txtSDTKH.Text != "" && cbGioiTinhKH.Text != ""
                && txtEmailKhachHang.Text != "")
            {
                return true;
            }
            return false;
        }
        private void DeleteAll()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            dtNgaySinhKH.Text = "";
            txtDiaChiKH.Text = "";
            txtSDTKH.Text = "";
            cbGioiTinhKH.Text = "";
            txtEmailKhachHang.Text = "";
        }
        bool flag = false;
        string k = Application.StartupPath;
        public static string tennv = "";
        string path = Application.StartupPath + @"\Resource\phim\";
        private void Form1_Load(object sender, EventArgs e)
        {
            lbTenNV.Text = tennv;
            picLogo.Image = Image.FromFile(path +"Logo.png");
            
            this.MinimumSize= this.Size;
            this.MaximumSize = this.Size;
            this.FormBorderStyle = FormBorderStyle.None;
            LoadListKhachHang();


            //MauPTTKHT



        }
        private void btThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn thêm", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    for (int i = 0; i < dataGridViewKH.Rows.Count - 1; i++)
                    {
                        string updatebySDT = dataGridViewKH.Rows[i].Cells[3].Value.ToString();
                        string updatebyEmail = dataGridViewKH.Rows[i].Cells[6].Value.ToString();
                        string updatebyMAKH = dataGridViewKH.Rows[i].Cells[0].Value.ToString();
                        if (txtSDTKH.Text == updatebySDT)
                        {
                            throw new Exception("Số điện thoại đã tồn tại");
                        }
                        if (txtEmailKhachHang.Text == updatebyEmail)
                        {
                            throw new Exception("Email đã tồn tại");
                        }
                        if (txtMaKH.Text == updatebyMAKH)
                        {
                            throw new Exception("Mã khách hàng đã tồn tại");
                        }
                    }

                    if (IscheckTextBox() == true)
                    {
                        if (txtSDTKH.Text.Length == 10)
                        {
                            TSX.Them("INSERT INTO KhachHang Values ('" + txtMaKH.Text + "',N'" + txtTenKH.Text + "',N'" + txtDiaChiKH.Text + "',N'" + txtSDTKH.Text + "',N'" + dtNgaySinhKH.Text
                                        + "',N'" + cbGioiTinhKH.Text + "',N'" + txtEmailKhachHang.Text + "',N'Thân Thiết')", dataGridViewKH);
                            MessageBox.Show("Thêm thành công");
                            LoadListKhachHang();
                            DeleteAll();
                        }
                        else
                        {
                            MessageBox.Show("Số điện thoại chỉ được nhập 10 số");
                            txtSDTKH.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập đủ dữ liệu");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(flag == false)
            {
                btLogOut.BringToFront();
                
                btLogOut.Show();
                flag = true;
            }
            else
            {
                btLogOut.Hide();
                flag = false;
            }
            
        }
        int xx = 2;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point k = lbTicketSales.Location;
            k.X += xx;
            lbTicketSales.Location = k;
            if (k.X > 300)
            {
                xx=-2;
            }
            if (k.X < -2)
            {
                xx = 2;
            }

        }

        private void btBanVe_Click(object sender, EventArgs e)
        {
            cc = new FormChonCho();
            cc.ShowDialog();
        }

        private void btLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridViewKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int z = dataGridViewKH.CurrentRow.Index;
            dataGridViewKH.ReadOnly = true;
            try
            {
                if (dataGridViewKH.CurrentRow.Index == dataGridViewKH.Rows.Count)
                {
                    DeleteAll();
                }
                txtMaKH.Text = dataGridViewKH.Rows[z].Cells[0].Value.ToString();
                txtTenKH.Text = dataGridViewKH.Rows[z].Cells[1].Value.ToString();
                txtDiaChiKH.Text = dataGridViewKH.Rows[z].Cells[2].Value.ToString();
                txtSDTKH.Text = dataGridViewKH.Rows[z].Cells[3].Value.ToString();
                dtNgaySinhKH.Text = dataGridViewKH.Rows[z].Cells[4].Value.ToString();
                cbGioiTinhKH.Text = dataGridViewKH.Rows[z].Cells[5].Value.ToString();
                txtEmailKhachHang.Text = dataGridViewKH.Rows[z].Cells[6].Value.ToString();
               
            }
            catch (Exception)
            {

                MessageBox.Show("Chưa nhập đủ)");
            }
            btThem.Enabled = true;
            btSua.Enabled = true;
        }
      
        private void btSua_Click(object sender, EventArgs e)
        {
            if (IscheckTextBox() == true)
            {
                if (MessageBox.Show("Bạn có chắc chắn sửa", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (dataGridViewKH.CurrentRow != null)
                    {
                        int s = dataGridViewKH.CurrentRow.Index;
                        string upadtebyMaKH = dataGridViewKH.Rows[s].Cells[0].Value.ToString();
                        try
                        {
                            for (int i = 0; i < dataGridViewKH.Rows.Count - 1; i++)
                            {
                                string updatebySDT = dataGridViewKH.Rows[i].Cells[3].Value.ToString();
                                string updatebyEmail = dataGridViewKH.Rows[i].Cells[6].Value.ToString();
                                if (txtEmailKhachHang.Text != dataGridViewKH.Rows[s].Cells[6].Value.ToString() && txtEmailKhachHang.Text == updatebyEmail)
                                {
                                    throw new Exception("Email đã tồn tại");
                                }
                                if (txtSDTKH.Text == updatebySDT && txtSDTKH.Text != dataGridViewKH.Rows[s].Cells[3].Value.ToString())
                                {
                                    throw new Exception("Số điện thoại đã tồn tại");
                                }
                            }


                            if (txtMaKH.Text != upadtebyMaKH)
                            {
                                throw new Exception("Không được phép sửa Mã khách hàng");
                            }

                            if (txtSDTKH.Text.Length == 10)
                            {
                                string k = "UPDATE KhachHang SET MaKH = N'" + txtMaKH.Text + "',TenKH = N'" + txtTenKH.Text + "',DiaChiKH =N'" + txtDiaChiKH.Text + "',SDTKH ='" + txtSDTKH.Text + "',NgaySinhKH = N'" + dtNgaySinhKH.Text
                                                + "',GioiTinh = N'" + cbGioiTinhKH.Text + "',Email = N'" + txtEmailKhachHang.Text + "',LoaiKH = N'Thân Thiết'" + "Where MaKH='" + upadtebyMaKH + "'";
                                dataGridViewKH.DataSource = ConnectFun.RunQuery(k);
                                LoadListKhachHang();
                                MessageBox.Show("Sửa thành công");
                                DeleteAll();
                            }
                            else
                            {
                                MessageBox.Show("Số điện thoại chỉ được nhập 10 số");
                                txtSDTKH.Focus();
                            }
                        }
                        //catch (SqlException)
                        //{
                        //    MessageBox.Show("Số điện thoại đã tồn tại");
                        //}
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Nhập đủ dữ liệu");
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ThucAn = new FormThucAn();
            ThucAn.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormNhanVienQL : Form
    {
        SqlConnection SqlConnection = new SqlConnection(@"Data Source=LAPTOP-RPIGMS1F;Initial Catalog=QLBanVe;Integrated Security=True");
        SqlCommand SqlCommand = new SqlCommand();
        public FormNhanVienQL()
        {
            InitializeComponent();
            LoadListNhanVien();
        }
        public void  LoadListNhanVien()
        {
           
            string query = "Select * From NhanVien";
            
            dataGridViewQLNV.DataSource = ConnectFun.RunQuery(query);

            dataGridViewQLNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        bool IscheckTextBox()
        {
            if (txtMaNV.Text != "" && txtTenNV.Text != "" && txtTenTK.Text != "" && txtMK.Text != "" && txtDiaChi.Text != "" && cbGioiTinh.Text != "" && cbChucVu.Text != "" && dtNgaySinhNV.Text != "" && txtSDT.Text != "")
            {
                return true;
            }
            return false;
        }
        
        private void btThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn thêm", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (IscheckTextBox() == true)
                    {

                        if (txtSDT.Text.Length == 10)
                        {
                            TSX.Them("set dateformat dmy INSERT INTO NhanVien Values (N'" + txtMaNV.Text + "',N'" + txtTenNV.Text + "',N'" + txtTenTK.Text + "',N'" + txtMK.Text + "',N'" + txtDiaChi.Text
                                        + "',N'" + cbGioiTinh.Text + "',N'" + dtNgaySinhNV.Text + "',N'" + txtSDT.Text + "',N'" + cbChucVu.Text + "')", dataGridViewQLNV);
                            MessageBox.Show("Thêm thành công");
                            LoadListNhanVien();
                            DeleteAll();
                        }
                        else
                        {
                            MessageBox.Show("Số điện thoại chỉ được nhập 10 số");
                            txtSDT.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập đủ dữ liệu");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã nhân viên và tên tài khoản không được trùng!!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if(IscheckTextBox() == true)
            {
                if (MessageBox.Show("Bạn có chắc chắn sửa", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (dataGridViewQLNV.CurrentRow != null)
                    {

                        int s = dataGridViewQLNV.CurrentRow.Index;
                        string upadtebyMaNV = dataGridViewQLNV.Rows[s].Cells[0].Value.ToString();
                        try
                        {
                            for (int i = 0; i < dataGridViewQLNV.Rows.Count-1; i++)
                            {
                                string updatebySDT = dataGridViewQLNV.Rows[i].Cells[7].Value.ToString();
                                string updatebyTenTK = dataGridViewQLNV.Rows[i].Cells[2].Value.ToString();
                                if (txtTenTK.Text == updatebyTenTK && txtTenTK.Text != dataGridViewQLNV.Rows[s].Cells[2].Value.ToString())
                                {
                                    throw new Exception("Tên tài khoản đã tồn tại");
                                }
                                if (txtSDT.Text == updatebySDT && txtSDT.Text != dataGridViewQLNV.Rows[s].Cells[7].Value.ToString())
                                {
                                    throw new Exception("Số điện thoại đã tồn tại");
                                }
                            }
                            if (txtMaNV.Text != upadtebyMaNV)
                            {
                                throw new Exception("Không được phép sửa Mã nhân viên");
                            }
                            else
                            {
                                if (txtSDT.Text.Length == 10)
                                {
                                    string k = "set dateformat dmy UPDATE NhanVien SET TenNV = N'" + txtTenNV.Text + "', TenTK = N'" + txtTenTK.Text + "', MatKhau = N'" + txtMK.Text + "',DiaChiNV = N'" + txtDiaChi.Text
                                    + "',GioiTinhNV = N'" + cbGioiTinh.Text + "',NgaySinhNV = N'" + dtNgaySinhNV.Text + "',SDTNV = N'" + txtSDT.Text + "',CapBac = N'" + cbChucVu.Text + "'" + "Where MaNV='" + upadtebyMaNV + "'";
                                    dataGridViewQLNV.DataSource = ConnectFun.RunQuery(k);
                                    LoadListNhanVien();
                                    MessageBox.Show("Sửa thành công");
                                    DeleteAll();
                                }
                                else
                                {
                                    MessageBox.Show("Số điện thoại chỉ được nhập 10 số");
                                    txtSDT.Focus();
                                }
                            }
                        }
                        catch(Exception ex)
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
        private void DeleteAll()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtTenTK.Text = "";
            txtMK.Text = "";
            txtDiaChi.Text = "";
            cbGioiTinh.Text = "";
            cbChucVu.Text = "";
            dtNgaySinhNV.Text = "";
            txtSDT.Text = "";
        }
        private void dataGridViewQLNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int i = e.RowIndex ;
            dataGridViewQLNV.ReadOnly = true;
            try
            {
               
                txtMaNV.Text = dataGridViewQLNV.Rows[i].Cells["MaNV"].Value.ToString();
                txtTenNV.Text = dataGridViewQLNV.Rows[i].Cells[1].Value.ToString();
                txtTenTK.Text = dataGridViewQLNV.Rows[i].Cells[2].Value.ToString();
                txtMK.Text = dataGridViewQLNV.Rows[i].Cells[3].Value.ToString();
                txtDiaChi.Text = dataGridViewQLNV.Rows[i].Cells[4].Value.ToString();
                cbGioiTinh.Text = dataGridViewQLNV.Rows[i].Cells[5].Value.ToString();
                dtNgaySinhNV.Text = dataGridViewQLNV.Rows[i].Cells[6].Value.ToString();
                txtSDT.Text = dataGridViewQLNV.Rows[i].Cells[7].Value.ToString();
                cbChucVu.Text = dataGridViewQLNV.Rows[i].Cells[8].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Chưa nhập đủ)");
            }
            btThem.Enabled = true;
            btSua.Enabled = true;
            btXoa.Enabled = true;
            
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Bạn có chắc chắn xóa", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (dataGridViewQLNV.Rows.Count > 1)
                    {
                        TSX.Xoa(dataGridViewQLNV, "MaNV", "NhanVien");
                        LoadListNhanVien();
                        MessageBox.Show("Xóa thành công");
                        DeleteAll();
                    }
                }
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            if(txtMaNV.Text == "")
            {
                dtNgaySinhNV.Enabled = false;
                
            }
            else
            {
                dtNgaySinhNV.Enabled = true;
                btThem.Enabled = true;
                btSua.Enabled = true;
                btXoa.Enabled = true;
            }    
            
        }

        private void FormNhanVienQL_Load(object sender, EventArgs e)
        {
            dtNgaySinhNV.Enabled = false;
            btThem.Enabled = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;
           
        }
    }
}

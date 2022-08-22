using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormKhachHanqQL : Form
    {
        public FormKhachHanqQL()
        {
            InitializeComponent();
            LoadListKhachHang();
        }

        public void LoadListKhachHang()
        {

            string query = "Select * From KhachHang";

            dataGridViewQLKH.DataSource = ConnectFun.RunQuery(query);

            dataGridViewQLKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        bool IscheckTextBox()
        {
            if (txtMaKH.Text != "" && txtTenKH.Text != "" && dtNgaySinhKH.Text != "" 
                && txtDiaChiKH.Text != "" && txtSDTKH.Text != "" && cbGioiTinhKH.Text != "" 
                 && txtEmailKhachHang.Text != "" )
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
        private void btThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn thêm", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    for (int i = 0; i < dataGridViewQLKH.Rows.Count-1; i++)
                    {
                        string updatebySDT = dataGridViewQLKH.Rows[i].Cells[3].Value.ToString();
                        string updatebyEmail = dataGridViewQLKH.Rows[i].Cells[6].Value.ToString();
                        string updatebyMAKH = dataGridViewQLKH.Rows[i].Cells[0].Value.ToString();
                        if (txtSDTKH.Text == updatebySDT)
                        {
                            throw new Exception("Số điện thoại đã tồn tại");
                        }
                        if (txtEmailKhachHang.Text == updatebyEmail)
                        {
                            throw new Exception("Email đã tồn tại");
                        }
                        if(txtMaKH.Text == updatebyMAKH)
                        {
                            throw new Exception("Mã khách hàng đã tồn tại");
                        }
                    }

                    if (IscheckTextBox() == true)
                    {
                        if (txtSDTKH.Text.Length == 10)
                        {
                            TSX.Them("set dateformat dmy INSERT INTO KhachHang Values ('" + txtMaKH.Text + "',N'" + txtTenKH.Text + "',N'" + txtDiaChiKH.Text + "',N'" + txtSDTKH.Text + "',N'" + dtNgaySinhKH.Text
                                        + "',N'" + cbGioiTinhKH.Text + "',N'" + txtEmailKhachHang.Text + "',N'Thân Thiết',0)", dataGridViewQLKH);
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


        private void dataGridViewQLKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int z = dataGridViewQLKH.CurrentRow.Index;
            dataGridViewQLKH.ReadOnly = true;
            try
            {
                if (dataGridViewQLKH.CurrentRow.Index == dataGridViewQLKH.Rows.Count)
                {
                    DeleteAll();
                }
                txtMaKH.Text = dataGridViewQLKH.Rows[z].Cells[0].Value.ToString();
                txtTenKH.Text = dataGridViewQLKH.Rows[z].Cells[1].Value.ToString();
                txtDiaChiKH.Text = dataGridViewQLKH.Rows[z].Cells[2].Value.ToString();
                txtSDTKH.Text = dataGridViewQLKH.Rows[z].Cells[3].Value.ToString();
                dtNgaySinhKH.Text = dataGridViewQLKH.Rows[z].Cells[4].Value.ToString();
                cbGioiTinhKH.Text = dataGridViewQLKH.Rows[z].Cells[5].Value.ToString();
                txtEmailKhachHang.Text = dataGridViewQLKH.Rows[z].Cells[6].Value.ToString();
                
            }
            catch (Exception)
            {

                MessageBox.Show("Chưa nhập đủ)");
            }
            btThem.Enabled = true;
            btSua.Enabled = true;
            btXoa.Enabled = true;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            //if(IscheckTextBox() == true)
            //{
            //    if (MessageBox.Show("Bạn có chắc chắn sửa", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //    {
            //        if (dataGridViewQLKH.CurrentRow != null)
            //        {
            //            int s = dataGridViewQLKH.CurrentRow.Index;
            //            string upadtebyMaKH = dataGridViewQLKH.Rows[s].Cells[0].Value.ToString();
            //            try
            //            {
            //                if (txtMaKH.Text != upadtebyMaKH)
            //                {
            //                    throw new Exception("Không được phép sửa Mã khách hàng");
            //                }
            //                if (txtSDTKH.Text.Length == 10)
            //                {
            //                    string k = "UPDATE KhachHang SET MaKH = N'" + txtMaKH.Text + "',TenKH = N'" + txtTenKH.Text + "',DiaChiKH =N'" + txtDiaChiKH.Text + "',SDTKH ='" + txtSDTKH.Text + "',NgaySinhKH = N'" + dtNgaySinhKH.Text
            //                                    + "',GioiTinh = N'" + cbGioiTinhKH.Text + "',Email = N'" + txtEmailKhachHang.Text + "',LoaiKH = N'" + cbLoaiKH.Text + "'" + "Where MaKH='" + upadtebyMaKH + "'";
            //                    dataGridViewQLKH.DataSource = ConnectFun.RunQuery(k);
            //                    LoadListKhachHang();
            //                    MessageBox.Show("Sửa thành công");
            //                    DeleteAll();
            //                }
            //                else
            //                {
            //                    MessageBox.Show("Số điện thoại chỉ được nhập 10 số");
            //                    txtSDTKH.Focus();
            //                }
            //            }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show(ex.Message);
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Nhập đủ dữ liệu");
            //}    

            if (IscheckTextBox() == true)
            {
                if (MessageBox.Show("Bạn có chắc chắn sửa", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (dataGridViewQLKH.CurrentRow != null)
                    {
                        int s = dataGridViewQLKH.CurrentRow.Index;
                        string upadtebyMaKH = dataGridViewQLKH.Rows[s].Cells[0].Value.ToString();
                        try
                        {
                            for (int i=0;i<dataGridViewQLKH.Rows.Count-1;i++)
                            {
                                string updatebySDT = dataGridViewQLKH.Rows[i].Cells[3].Value.ToString();
                                string updatebyEmail = dataGridViewQLKH.Rows[i].Cells[6].Value.ToString();
                                if (txtEmailKhachHang.Text != dataGridViewQLKH.Rows[s].Cells[6].Value.ToString() && txtEmailKhachHang.Text == updatebyEmail)
                                {
                                    throw new Exception("Email đã tồn tại");
                                }
                                if (txtSDTKH.Text == updatebySDT && txtSDTKH.Text != dataGridViewQLKH.Rows[s].Cells[3].Value.ToString() )
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
                                string k = "set dateformat dmy UPDATE KhachHang SET MaKH = N'" + txtMaKH.Text + "',TenKH = N'" + txtTenKH.Text + "',DiaChiKH =N'" + txtDiaChiKH.Text + "',SDTKH ='" + txtSDTKH.Text + "',NgaySinhKH = N'" + dtNgaySinhKH.Text
                                                + "',GioiTinh = N'" + cbGioiTinhKH.Text + "',Email = N'" + txtEmailKhachHang.Text + "',LoaiKH = N'Thân Thiết'" + "Where MaKH='" + upadtebyMaKH + "'";
                                dataGridViewQLKH.DataSource = ConnectFun.RunQuery(k);
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

        private void FormKhachHanqQL_Load(object sender, EventArgs e)
        {
            dtNgaySinhKH.Enabled = false;
            btThem.Enabled = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                dtNgaySinhKH.Enabled = false;
            }
            else
            {
                dtNgaySinhKH.Enabled = true;
                btThem.Enabled = true;
                btSua.Enabled = true;
                btXoa.Enabled = true;
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if(IscheckTextBox() == true)
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (dataGridViewQLKH.Rows.Count > 1)
                    {
                        TSX.Xoa(dataGridViewQLKH, "MaKH", "KhachHang");
                        LoadListKhachHang();
                        MessageBox.Show("Xóa thành công");
                        DeleteAll();
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn dòng để xóa");
            }    
        }
    }
}

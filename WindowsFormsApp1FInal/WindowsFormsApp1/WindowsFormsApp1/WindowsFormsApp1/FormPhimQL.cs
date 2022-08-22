using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormPhimQL : Form
    {
        public FormPhimQL()
        {
            InitializeComponent();
            LoadListPhim();
        }
        
        public void LoadListPhim()
        {

            string query = "Select * From Phim";

            dataGridViewPhim.DataSource = ConnectFun.RunQuery(query);

            dataGridViewPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void DeleteAll()
        {
            txtMaPhim.Text = "";
            txtTenPhim.Text = "";
            txtDaoDien.Text = "";
            txtNamSX.Text = "";
            txtTheLoai.Text = "";
            txtThoiLuong.Text = "";
            txtMoTa.Text = "";
            dtpThoiHan.Text = "";
            
        }
        private void FormPhimQL_Load(object sender, EventArgs e)
        {
            ptbAnhPhim.SizeMode = PictureBoxSizeMode.Zoom;
            dtpThoiHan.Enabled = false;
            btThem.Enabled = false ;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            btThemAnh.Enabled = false;
        }

        private void dataGridViewPhim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            dataGridViewPhim.ReadOnly = true;
            
            try
            {
                
                txtMaPhim.Text = dataGridViewPhim.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenPhim.Text = dataGridViewPhim.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDaoDien.Text = dataGridViewPhim.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtNamSX.Text = dataGridViewPhim.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTheLoai.Text = dataGridViewPhim.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtThoiLuong.Text = dataGridViewPhim.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtMoTa.Text = dataGridViewPhim.Rows[e.RowIndex].Cells[6].Value.ToString();
                dtpThoiHan.Text = dataGridViewPhim.Rows[e.RowIndex].Cells[7].Value.ToString();
                ptbAnhPhim.Image = Image.FromFile(dataGridViewPhim.Rows[e.RowIndex].Cells[8].Value.ToString());
            }
            catch (Exception)
            {

                MessageBox.Show("Chưa nhập đủ");
            }
            btThem.Enabled = true;
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btThemAnh.Enabled = true;
        }

        private void btThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif ";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ptbAnhPhim.Image = Image.FromFile(openFileDialog.FileName);
                pathPhim = openFileDialog.FileName;
            }
        }
        string pathPhim;
        bool checkTextBox()
        {
            
            if (txtMaPhim.Text != "" && txtTenPhim.Text != "" && txtDaoDien.Text != "" && txtNamSX.Text != "" 
                && txtTheLoai.Text != "" && txtThoiLuong.Text != "" && txtMoTa.Text != "" && dtpThoiHan.Text != "" )
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
                    if (checkTextBox() == true)

                    {
                        TSX.Them("INSERT INTO Phim Values (N'" + txtMaPhim.Text + "',N'" + txtTenPhim.Text + "',N'" + txtDaoDien.Text + "',N'" + txtNamSX.Text + "',N'" + txtTheLoai.Text
                                        + "',N'" + txtThoiLuong.Text + "',N'" + txtMoTa.Text + "',N'" + dtpThoiHan.Text + "',N'" + pathPhim + "')", dataGridViewPhim);
                        MessageBox.Show("Thêm thành công");
                        LoadListPhim();
                        DeleteAll();
                    }
                    else
                    {
                        MessageBox.Show("Nhập đủ dữ liệu");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Trùng mã!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn sửa", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                try
                {
                    if (dataGridViewPhim.CurrentRow != null)
                    {
                            int s = dataGridViewPhim.CurrentRow.Index;
                            string upadtebyPhim = dataGridViewPhim.Rows[s].Cells[0].Value.ToString();
                            if (txtMaPhim.Text != upadtebyPhim)
                            {
                                throw new Exception("Không được phép sửa Mã phim");
                            }
                        string k = "UPDATE Phim SET MaPhim = N'" + txtMaPhim.Text + "', TenPhim = N'" + txtTenPhim.Text + "', DaoDien = N'" + txtDaoDien.Text + "',NamSX = N'" + txtNamSX.Text
                            + "',TheLoai = N'" + txtTheLoai.Text + "',ThoiLuong = N'" + txtThoiLuong.Text + "',MoTa = N'" + txtMoTa.Text + "',ThoiHan = N'" + dtpThoiHan.Text + "',AnhPhim = N'" + pathPhim + "'" + "Where MaPhim='" + upadtebyPhim + "'";
                            dataGridViewPhim.DataSource = ConnectFun.RunQuery(k);
                            LoadListPhim();
                            MessageBox.Show("Sửa thành công");
                            DeleteAll();
                     
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Nếu xóa phim tất cả lịch chiếu và suất chiếu của phim cũng sẽ bị xóa", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //{
            //    if (dataGridViewPhim.Rows.Count > 1)
            //    {
            //        //TSX.Xoa3(dataGridViewPhim, "MASC", "ChoNgoi_Rap");
            //        TSX.Xoa2(dataGridViewPhim, "MaLC", "SuatChieu");
            //        TSX.Xoa(dataGridViewPhim, "MaPhim", "LichChieu");
            //        TSX.Xoa(dataGridViewPhim, "MaPhim", "Phim");
            //        LoadListPhim();
            //        MessageBox.Show("Xóa thành công");
            //        DeleteAll();
            //    }
            //}
            if (MessageBox.Show("Nếu xóa phim tất cả lịch chiếu và suất chiếu của phim cũng sẽ bị xóa", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dataGridViewPhim.Rows.Count > 1)
                {
                    //TSX.Xoa3(dataGridViewPhim, "MASC", "ChoNgoi_Rap");
                   
                    TSX.Xoa1(dataGridViewPhim,"MaPhim","ChoNgoi_Rap","SuatChieu","LichChieu","Phim","MaSC","MaLC");
                    LoadListPhim();
                    MessageBox.Show("Xóa thành công");
                    DeleteAll();
                }
            }
        }

        private void txtMaPhim_TextChanged(object sender, EventArgs e)
        {
            if (txtMaPhim.Text == "")
            {
                dtpThoiHan.Enabled = false;
                
            }
            else
            {
                dtpThoiHan.Enabled = true;
                btThem.Enabled = true;
                btSua.Enabled = true;
                btXoa.Enabled = true;
                btThemAnh.Enabled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

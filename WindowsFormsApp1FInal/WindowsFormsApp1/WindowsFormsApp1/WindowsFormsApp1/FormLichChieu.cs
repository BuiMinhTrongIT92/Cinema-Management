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
    public partial class FormLichChieu : Form
    {
        public FormLichChieu()
        {
            InitializeComponent();
        }
        
        public void LoadListLichChieu()
        {

            string query = "set dateformat dmy Select MaLC,KhoiChieu,KetThucChieu,lc.MaPhim,TenPhim from LichChieu lc, Phim p where lc.MaPhim = p.MaPhim";

            dataGridViewQLLC.DataSource = ConnectFun.RunQuery(query);

            dataGridViewQLLC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public void LoadListSuatChieu()
        {

            string query = "set dateformat dmy Select MaSC,BatDau,KetThuc,sc.MaLC,TenPhim,MaRap,Gia from LichChieu lc, Phim p, SuatChieu sc where lc.MaPhim = p.MaPhim and lc.MaLC = sc.MaLC";

            dataGridViewQLSC.DataSource = ConnectFun.RunQuery(query);

            dataGridViewQLSC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormLichChieu_Load(object sender, EventArgs e)
        {
            LoadListLichChieu();
            LoadListSuatChieu();
            dataGridViewQLLC.DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridViewQLSC.DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss";
        }
        bool IscheckTextBox()
        {
            if (txtMaLC.Text != "" && dtbNgayKC.Text != "" && dtpTGKT.Text != "" && txtMaPhim.Text != "" )
            {
                return true;
            }
            return false;
        }
        bool IscheckTextBox1()
        {
            if (txtMaSC.Text != "" && dtpTGBD.Text != "" && dtpTGKT.Text != ""
                && txtGia.Text != "" && txtMaLC1.Text != "" && txtMaRap.Text != ""
               )
            {
                return true;
            }
            return false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(searchSC.Text !="")
            {
                string query = "set dateformat dmy Declare @DL nvarchar(50) set @DL = N'"+searchSC.Text+"' if ISDATE(@DL) =1 begin Select MaSC,BatDau,KetThuc,sc.MaLC,TenPhim,MaRap,Gia from LichChieu lc, Phim p, SuatChieu sc where lc.MaPhim = p.MaPhim and lc.MaLC = sc.MaLC and BatDau = @DL end else begin set dateformat dmy Select MaSC,BatDau,KetThuc,sc.MaLC,TenPhim,MaRap,Gia from LichChieu lc, Phim p, SuatChieu sc where lc.MaPhim = p.MaPhim and lc.MaLC = sc.MaLC and TenPhim like '%'+ @DL+ '%' end";

                dataGridViewQLSC.DataSource = ConnectFun.RunQuery(query);

                dataGridViewQLSC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }  
            else
            {
                LoadListSuatChieu();
            }    
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (searchLC.Text != "")
            {
                string query = "set dateformat dmy Declare @DL nvarchar(50) set @DL = N'" + searchLC.Text+ "' if ISDATE(@DL) = 1 begin set dateformat dmy Select MaLC, KhoiChieu, KetThucChieu, lc.MaPhim,TenPhim from LichChieu lc, Phim p where lc.MaPhim = p.MaPhim and lc.KhoiChieu = @DL end else begin set dateformat dmy Select MaLC, KhoiChieu, KetThucChieu, lc.MaPhim,TenPhim from LichChieu lc, Phim p where lc.MaPhim = p.MaPhim and TenPhim like '%' + @DL + '%' end";


                dataGridViewQLLC.DataSource = ConnectFun.RunQuery(query);

                dataGridViewQLLC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                LoadListLichChieu();
            }
        }

        private void btThemLC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn thêm", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataTable kiemtra = ConnectFun.RunQuery("Select MaPhim from Phim where MaPhim = '" + txtMaPhim.Text + "'");
                    try
                    {
                        if (IscheckTextBox() == true)
                        {
                            if (kiemtra.Rows.Count > 0)
                            {
                                TSX.Them("set dateformat dmy INSERT INTO LichChieu Values ('" + txtMaLC.Text + "',N'" + dtbNgayKC.Text + "',N'" + dtbNgayKT.Text + "',N'" + txtMaPhim.Text + "')", dataGridViewQLLC);
                                MessageBox.Show("Thêm thành công");
                                LoadListLichChieu();
                                DeleteAll();
                            }
                            else
                            {
                                MessageBox.Show("Mã phim không tồn tại");
                            }
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
            else
            {
                MessageBox.Show("Chưa nhập dữ liệu");
            }    
        }
        private void DeleteAll()
        {
            txtMaLC.Text = "";
            dtbNgayKC.Text = "";
            dtbNgayKT.Text = "";
            txtMaPhim.Text = "";
        }
        private void DeleteAll1()
        {
            txtMaSC.Text = "";
            dtpTGBD.Text = "";
            dtpTGKT.Text = "";
            txtGia.Text = "";
            txtMaLC1.Text = "";
            txtMaRap.Text = "";
        }
        
        private void btSuaLC_Click(object sender, EventArgs e)
        {
            if(IscheckTextBox() == true)
            {
                if (MessageBox.Show("Bạn có chắc chắn sửa", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
                {
                    DataTable kiemtra = ConnectFun.RunQuery("Select MaPhim from Phim where MaPhim = '" + txtMaPhim.Text + "'");
                    if (kiemtra.Rows.Count > 0)
                    {
                        try
                        {
                            if (dataGridViewQLLC.CurrentRow != null)
                            {
                                int s = dataGridViewQLLC.CurrentRow.Index;
                                string upadtebyMaLC = dataGridViewQLLC.Rows[s].Cells[0].Value.ToString();
                                if (txtMaLC.Text != upadtebyMaLC)
                                {
                                    throw new Exception("Không được phép sửa Mã lịch chiếu");
                                }
                                string k = "set dateformat dmy UPDATE LichChieu SET MaLC = N'" + txtMaLC.Text + "',KhoiChieu = N'" + dtbNgayKC.Text + "',KetThucChieu =N'" + dtbNgayKT.Text + "',MaPhim ='" + txtMaPhim.Text + "'" + "Where MaLC='" + upadtebyMaLC + "'";
                                dataGridViewQLLC.DataSource = ConnectFun.RunQuery(k);
                                LoadListLichChieu();
                                MessageBox.Show("Sửa thành công");
                                DeleteAll();
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Mã phim không tồn tại");
                    }
                }
                else
                {
                    MessageBox.Show("Nhập đủ dữ liệu");
                }
            }
            else
            {
                MessageBox.Show("Nhập đủ dữ liệu");
            }
        }

        private void btXoaLC_Click(object sender, EventArgs e)
        {
            if(IscheckTextBox() == true)
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (dataGridViewQLLC.Rows.Count > 1)
                    {
                        TSX.Xoa(dataGridViewQLLC, "MaLC", "LichChieu");
                        LoadListLichChieu();
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

        private void dataGridViewQLLC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int z = e.RowIndex;
            dataGridViewQLLC.ReadOnly = true;
            try
            {
                if (dataGridViewQLLC.CurrentRow.Index == dataGridViewQLLC.Rows.Count)
                {
                    DeleteAll();
                }
                txtMaLC.Text = dataGridViewQLLC.Rows[z].Cells[0].Value.ToString();
                dtbNgayKC.Text = dataGridViewQLLC.Rows[z].Cells[1].Value.ToString();
                dtbNgayKT.Text = dataGridViewQLLC.Rows[z].Cells[2].Value.ToString();
                txtMaPhim.Text = dataGridViewQLLC.Rows[z].Cells[3].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Chưa nhập đủ)");
            }
            btThemLC.Enabled = true;
            btSuaLC.Enabled = true;
            btXoaLC.Enabled = true;
        }

        private void btThemSC_Click(object sender, EventArgs e)
        {
            if(IscheckTextBox1() == true)
            {
                if (MessageBox.Show("Bạn có chắc chắn thêm", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DataTable kiemtra1 = ConnectFun.RunQuery("Select MaRap from Rap where MaRap = '" + txtMaRap.Text + "'");
                    DataTable kiemtra2 = ConnectFun.RunQuery("Select MaLC from LichChieu where MaLC = '" + txtMaLC1.Text + "'");
                    if (kiemtra1.Rows.Count > 0 && kiemtra2.Rows.Count > 0)
                    {
                        try
                        {
                            if (IscheckTextBox1() == true)
                            {
                                TSX.Them("set dateformat dmy INSERT INTO SuatChieu Values ('" + txtMaSC.Text + "',N'" + dtpTGBD.Text + "',N'" + dtpTGKT.Text + "',N'" + txtGia.Text + "',N'" + txtMaLC1.Text
                                                + "',N'" + txtMaRap.Text + "')", dataGridViewQLSC);
                                MessageBox.Show("Thêm thành công");
                                LoadListSuatChieu();
                                DeleteAll1();
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
                    else
                    {
                        MessageBox.Show("Không tồn tại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập dữ liệu");
            }
        }

        private void dataGridViewQLSC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int z = dataGridViewQLSC.CurrentRow.Index;
            dataGridViewQLSC.ReadOnly = true;
            try
            {
                if (dataGridViewQLSC.CurrentRow.Index == dataGridViewQLSC.Rows.Count)
                {
                    DeleteAll();
                }
                txtMaSC.Text = dataGridViewQLSC.Rows[z].Cells[0].Value.ToString();
                dtpTGBD.Text = dataGridViewQLSC.Rows[z].Cells[1].Value.ToString();
                dtpTGKT.Text = dataGridViewQLSC.Rows[z].Cells[2].Value.ToString();
                txtGia.Text = dataGridViewQLSC.Rows[z].Cells[6].Value.ToString();
                txtMaLC1.Text = dataGridViewQLSC.Rows[z].Cells[3].Value.ToString();
                txtMaRap.Text = dataGridViewQLSC.Rows[z].Cells[5].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Chưa nhập đủ)");
            }
            btThemSC.Enabled = true;
            btSuaSC.Enabled = true;
            btXoaSC.Enabled = true;
        }

        private void btXoaSC_Click(object sender, EventArgs e)
        {
            if(IscheckTextBox1() == true)
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (dataGridViewQLSC.Rows.Count > 1)
                    {
                        TSX.Xoa(dataGridViewQLSC, "MaSC", "SuatChieu");
                        LoadListSuatChieu();
                        MessageBox.Show("Xóa thành công");
                        DeleteAll1();
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn dòng để xóa");
            }
        }

        private void btSuaSC_Click(object sender, EventArgs e)
        {
            if(IscheckTextBox1() == true)
            {
                if (MessageBox.Show("Bạn có chắc chắn sửa", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DataTable kiemtra1 = ConnectFun.RunQuery("Select MaRap from Rap where MaRap = '" + txtMaRap.Text + "'");
                    DataTable kiemtra2 = ConnectFun.RunQuery("Select MaLC from LichChieu where MaLC = '" + txtMaLC1.Text + "'");
                    if (kiemtra1.Rows.Count > 0 && kiemtra2.Rows.Count >0)
                    {
                        try {
                            if (dataGridViewQLSC.CurrentRow != null)
                            {
                                int s = dataGridViewQLSC.CurrentRow.Index;
                                string upadtebyMaSC = dataGridViewQLSC.Rows[s].Cells[0].Value.ToString();
                                if (txtMaSC.Text != upadtebyMaSC)
                                {
                                    throw new Exception("Không được phép sửa Mã suất chiếu");
                                }
                                string k = "set dateformat dmy UPDATE SuatChieu SET MaSC = N'" + txtMaSC.Text + "',BatDau = N'" + dtpTGBD.Text + "',KetThuc =N'" + dtpTGKT.Text + "',Gia ='" + txtGia.Text + "',MaLC = N'" + txtMaLC1.Text + "',MaRap = N'" + txtMaRap.Text + "'" + "Where MaSC='" + upadtebyMaSC + "'";
                                dataGridViewQLSC.DataSource = ConnectFun.RunQuery(k);
                                LoadListSuatChieu();
                                MessageBox.Show("Sửa thành công");
                                DeleteAll1();
                            }
                        }
                         catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhập đủ dữ liệu");
            }
        }

       
    }
}

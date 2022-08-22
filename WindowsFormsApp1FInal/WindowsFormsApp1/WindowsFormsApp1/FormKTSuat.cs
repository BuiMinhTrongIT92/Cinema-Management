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
    public partial class FormKTSuat : Form
    {
        public FormKTSuat()
        {
            InitializeComponent();
            ptAnhDemo.SizeMode = PictureBoxSizeMode.Zoom;
        }
        public string tenphim;
        DataTable DataTablePhim;
        private DataTable data;
        public string pathAnh;
        private void FormKTSuat_Load(object sender, EventArgs e)
        {
            string query = "Select * From Phim";

            DataTablePhim = ConnectFun.RunQuery(query);
            for (int i = 0; i < DataTablePhim.Rows.Count; i++)
            {
                if (DataTablePhim.Rows[i][0].ToString() == tenphim)
                {
                    string queryy = "set dateformat dmy Select MaSC,BatDau,KetThuc,sc.MaLC,TenPhim,MaRap,Gia,p.MaPhim from LichChieu lc, Phim p, SuatChieu sc where lc.MaPhim = p.MaPhim and lc.MaLC = sc.MaLC and TenPhim = N'" + DataTablePhim.Rows[i][1].ToString() + "'";
                    dtgKTSuat.DataSource = ConnectFun.RunQuery(queryy);
                    ptAnhDemo.Image = Image.FromFile(pathAnh);
                    lbTenPhim.Text = DataTablePhim.Rows[i][1].ToString();
                    lbTGChieu.Text = DataTablePhim.Rows[i][5].ToString();

                }
            }
        }

        private void dtgKTSuat_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormChonCho.MaPhim = dtgKTSuat.Rows[e.RowIndex].Cells[7].Value.ToString();
            FormChonCho.TenPhim = dtgKTSuat.Rows[e.RowIndex].Cells[4].Value.ToString();
            FormChonCho.MASC = dtgKTSuat.Rows[e.RowIndex].Cells[0].Value.ToString();
            FormChonCho.Rap = dtgKTSuat.Rows[e.RowIndex].Cells[5].Value.ToString();
            this.Close();
        }

        private void dtgKTSuat_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgKTSuat.SelectedRows.Count > 0)
            {
                //lbRap.Text = dtgKTSuat.Rows[e.RowIndex].Cells[5].Value.ToString();
                String query = "Select * From ChoNgoi_Rap Where MaSC = '" + dtgKTSuat.SelectedRows[0].Cells[0].Value.ToString() + "'";
                // String query = "Select MASC From ChoNgoi_Rap Where MaSC = 'SC05'";

                data = ConnectFun.RunQuery(query);
                lbDaDat.Text = data.Rows.Count.ToString();
                lbTrong.Text = (94 - int.Parse(lbDaDat.Text)).ToString();
            }
        }

        //public static DataTable getChoNgoi()
        //{
        //    return data;
        //}

        private void FormKTSuat_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormChonCho.signal.Value++;
        }
    }
}

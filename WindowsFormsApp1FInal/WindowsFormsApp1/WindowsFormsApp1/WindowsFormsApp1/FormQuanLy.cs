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
    public partial class FormQuanLy : Form
    {
        private FormDoanhThuQL doanhThu;
        private FormPhimQL phim;
        private FormNhanVienQL nvql;
        private FormKhachHanqQL khql;
        private FormBangDK bdk;
        private FormLichChieu lC;
        Form pnForm;
        public static string tenQL = "";
        public FormQuanLy()
        {
            doanhThu = new FormDoanhThuQL();
            phim = new FormPhimQL();
            nvql = new FormNhanVienQL();
            khql = new FormKhachHanqQL();
            bdk = new FormBangDK();
            lC = new FormLichChieu();
            //doanhThu.Hide();
            //phim.Hide();
            //nvql.Hide();
            //khql.Hide();
            InitializeComponent();
        }
        bool flagQL = false;
        private void btMyProfileQL_Click(object sender, EventArgs e)
        {
            if (flagQL == false)
            {
                btLogOutQL.BringToFront();
                btSettingQL.BringToFront();

                btSettingQL.Show();
                btLogOutQL.Show();
                flagQL = true;
            }
            else
            {
                btLogOutQL.Hide();
                btSettingQL.Hide();
                flagQL = false;
            }

        }
     
        private void FormQuanLy_Load(object sender, EventArgs e)
        {
            btLogOutQL.Hide();
            btSettingQL.Hide();
            ChuyenF(bdk);
        }
        private void ChuyenF(Form Childf)
        {
            
            pnForm = Childf;
            Childf.TopLevel = false;
            Childf.Dock = DockStyle.Fill;
            pnMain.Controls.Add(pnForm);
            Childf.BringToFront();
            Childf.Show();
        }
        private void btDoanhThu_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
         
            switch (bt.Text)
            {
                case "Doanh Thu":
                    ChuyenF(doanhThu);
                    break;
                case "Phim":
                    phim.LoadListPhim();
                    ChuyenF(phim);
                    break;
                case "Nhân Viên":
                    nvql.LoadListNhanVien();
                    ChuyenF(nvql);
                    break;
                case "Khách Hàng":
                    khql.LoadListKhachHang();
                    ChuyenF(khql);
                    break;
                case "Bảng điều khiển":
                    ChuyenF(bdk);
                    break;
                case "Lịch Chiếu":
                    lC.LoadListLichChieu();
                    lC.LoadListSuatChieu();
                    ChuyenF(lC);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btLogOutQL_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

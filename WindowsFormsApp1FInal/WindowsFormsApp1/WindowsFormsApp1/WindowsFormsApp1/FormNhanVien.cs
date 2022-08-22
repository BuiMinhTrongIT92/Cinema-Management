using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormNhanVien : Form
    {

        public static FormChonCho cc;
        public FormNhanVien()
        {
            InitializeComponent();
        }

        bool flag = false;
        string k = Application.StartupPath;
        public static string tennv = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            lbTenNV.Text = tennv;
            picLogo.Image = Image.FromFile(k + @"\Resource\Logo.png");
            btLogOut.Hide();
            btSetting.Hide();
            btSetting.BringToFront();
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.FormBorderStyle = FormBorderStyle.None;


            //MauPTTKHT
            listView1.View = View.Details;
            listView1.Columns.Add("Mã hóa đơn", (int)(listView1.Width * 0.16));
            listView1.Columns.Add("Tên phim", (int)(listView1.Width * 0.16));
            listView1.Columns.Add("Ngày lập", (int)(listView1.Width * 0.16));
            listView1.Columns.Add("Mã suất chiếu", (int)(listView1.Width * 0.16));
            listView1.Columns.Add("Tên nhân viên", (int)(listView1.Width * 0.16));
            listView1.Columns.Add("Tên khách hàng", (int)(listView1.Width * 0.16));
            listView1.Columns.Add("Trạng thái", (int)(listView1.Width * 0.16));
            ListViewItem p = new ListViewItem("HD01");
            p.SubItems.Add("Bố già");
            p.SubItems.Add("12/6/2019");
            p.SubItems.Add("SC01");
            p.SubItems.Add("Bùi Minh Trong");
            p.SubItems.Add("Trần Phúc Đạt");
            p.SubItems.Add("Đã thanh toán");
            listView1.Items.Add(p);


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                btLogOut.BringToFront();
                btSetting.BringToFront();

                btSetting.Show();
                btLogOut.Show();
                flag = true;
            }
            else
            {
                btLogOut.Hide();
                btSetting.Hide();
                flag = false;
            }

        }
        int xx = 2;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point k = lbTicketSales.Location;
            k.X += xx;
            lbTicketSales.Location = k;
            if (k.X > 370)
            {
                xx = -2;
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
            Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

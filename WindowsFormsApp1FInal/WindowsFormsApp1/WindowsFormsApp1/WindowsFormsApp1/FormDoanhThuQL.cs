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
    public partial class FormDoanhThuQL : Form
    {
        public FormDoanhThuQL()
        {
            InitializeComponent();
        }

        private void FormDoanhThuQL_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Mã hóa đơn", (int)(listView1.Width * 0.16));
            listView1.Columns.Add("Mã suất chiếu", (int)(listView1.Width * 0.16));
            listView1.Columns.Add("", (int)(listView1.Width * 0.16));
            listView1.Columns.Add("Mã chỗ ngồi", (int)(listView1.Width * 0.16));
            listView1.Columns.Add("Số thứ tự", (int)(listView1.Width * 0.16));
            listView1.Columns.Add("Loại ghế", (int)(listView1.Width * 0.16));

            ListViewItem p = new ListViewItem("HD01");
            p.SubItems.Add("SC1");
            p.SubItems.Add("BG1");
            p.SubItems.Add("Z");
            p.SubItems.Add("02");
            p.SubItems.Add("Thường");

            listView1.Items.Add(p);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

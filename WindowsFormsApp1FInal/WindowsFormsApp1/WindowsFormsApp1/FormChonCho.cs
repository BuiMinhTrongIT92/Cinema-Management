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
using System.Windows;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class FormChonCho : Form
    {
        public FormChonCho()
        {
            InitializeComponent();
        }

        public static string TenPhim, MASC, Rap;
        public static string MaPhim;
        public static NumericUpDown signal = new NumericUpDown();
        int Dat, Trong;
        double thanhTien,giamGia, tienPhaiTra;
        int soVeMua, soLanGiamGia;
        
        string maKH, maHD;

        private void FormChonCho_Load(object sender, EventArgs e)
        {
            ChonPhim();
            khoiTao();
        }

        private void khoiTao()
        {
            pnCho.BackgroundImage = Image.FromFile(path + "nencho.jpg");
            pnright.BackgroundImage = Image.FromFile(path + "nen2.jpg");
            Dat = 0;
            Trong = 94;
            lbTrong.Text = Trong.ToString();
            lbDat.Text = Dat.ToString();
            lvThongTin.Items.Clear();
            txtMaKH.Text = "";

            TenPhim = "";
            MASC = "";
            Rap = "";
            layThongTin();

            signal.ValueChanged += Signal_ValueChanged;
            //
            for (int i = 0; i < pnCho.Controls.Count; i++)
            {
                if (pnCho.Controls[i].Name.StartsWith("bt"))
                {
                    pnCho.Controls[i].Enabled = false;
                    pnCho.Controls[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(244)))), ((int)(((byte)(217)))));
                    pnCho.Controls[i].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
                }
            }
            //
            ColumnHeader choNgoi = new ColumnHeader();
            choNgoi.Text = "Vị trí";
            choNgoi.Width = 100;
            ColumnHeader loaiVe = new ColumnHeader();
            loaiVe.Text = "Loại vé";
            loaiVe.Width = 150;
            ColumnHeader gia = new ColumnHeader();
            gia.Text = "Giá";
            gia.Width = 150;

            lvThongTin.View = View.Details;
            lvThongTin.Columns.AddRange(new ColumnHeader[] { choNgoi, loaiVe, gia });
            //
            giamGia = 0;
            if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {
                giamGia += 15000;
            }
            lbGiamGia.Text = giamGia.ToString() + " đ";
            thanhTien = 0;
            lbThanhTien.Text = thanhTien.ToString() + " đ";
            tienPhaiTra = 0;
            lbTienPhaiTra.Text = tienPhaiTra.ToString() + " đ";
            //
            soVeMua = 0;
            lbSoLanMua.Text = soVeMua.ToString();
            maKH = "";
            soLanGiamGia = 0;
            //

        }
        private void btK0_Click(object sender, EventArgs e)
        {
            CheckBox k = (CheckBox)sender;
            if (k.Checked)
            {
                k.BackColor = Color.FromArgb(0, 170, 160);
                k.ForeColor = Color.White;
                Dat++;
                Trong--;
                lbDat.Text = Dat.ToString();
                lbTrong.Text = Trong.ToString();
                //choDaChon.Add(k);
                if (rbSinhVien.Checked)
                {
                    themVe(k.Text, "Sinh Viên", "65000 đ");
                    thanhTien += 65000;
                    lbThanhTien.Text = thanhTien.ToString() + " đ";
                    tienPhaiTra = thanhTien - giamGia;
                    lbTienPhaiTra.Text = tienPhaiTra.ToString() + " đ";
                    soVeMua++;
                }
                else
                {
                    themVe(k.Text, "Người Lớn", "80000 đ");
                    thanhTien += 80000;
                    lbThanhTien.Text = thanhTien.ToString() + " đ";
                    tienPhaiTra = thanhTien - giamGia;
                    lbTienPhaiTra.Text = tienPhaiTra.ToString() + " đ";
                    soVeMua++;
                }
            }
            else
            {
                k.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(244)))), ((int)(((byte)(217)))));
                k.ForeColor = Color.FromArgb(0, 170, 160);
                Dat--;
                Trong++;
                lbDat.Text = Dat.ToString();
                lbTrong.Text = Trong.ToString();
                //choDaChon.Remove(k);
                soVeMua--;
                xoaVe(k.Text);
                //xoaChoNgoi(k.Text);
            }

        }
        private void themVe(string choNgoi,string loaiVe, string gia)
        {
            ListViewItem itemChoNgoi = new ListViewItem();
            itemChoNgoi.Text = choNgoi;
            //
            ListViewItem.ListViewSubItem itemLoaiVe = new ListViewItem.ListViewSubItem();
            itemLoaiVe.Text = loaiVe;
            //
            ListViewItem.ListViewSubItem itemGia = new ListViewItem.ListViewSubItem();
            itemGia.Text = gia;
            //
            itemChoNgoi.SubItems.Add(itemLoaiVe);
            itemChoNgoi.SubItems.Add(itemGia);
            //
            lvThongTin.Items.Add(itemChoNgoi);
            //
        }

        private void xoaVe(string choNgoi)
        {
            foreach(ListViewItem item in lvThongTin.Items)
            {
                if (item.Text == choNgoi)
                {
                    if (item.SubItems[1].Text == "Sinh Viên")
                    {
                        thanhTien -= 65000;
                        lbThanhTien.Text = thanhTien.ToString() + " đ";
                        tienPhaiTra = thanhTien - giamGia;
                        if (tienPhaiTra < 0) tienPhaiTra = 0;
                        lbTienPhaiTra.Text = tienPhaiTra.ToString() + " đ";
                    }
                    else
                    {
                        thanhTien -= 80000;
                        lbThanhTien.Text = thanhTien.ToString() + " đ";
                        tienPhaiTra = thanhTien - giamGia;
                        if (tienPhaiTra < 0) tienPhaiTra = 0;
                        lbTienPhaiTra.Text = tienPhaiTra.ToString() + " đ";
                    }
                    lvThongTin.Items.Remove(item);
                    break;
                }
            }
        }

        string path = Application.StartupPath + @"\Resource\phim\";
        DataTable DataTablePhim;
        private void ChonPhim()
        {
            DataTablePhim = new DataTable();
            string query = "Select * From Phim";

            DataTablePhim = ConnectFun.RunQuery(query);
            for (int i =0; i< DataTablePhim.Rows.Count;i++)
            {
                
                RadioButton button = new RadioButton();
                button.Width = 180;
                button.Height = 260;
                button.Name = DataTablePhim.Rows[i][0].ToString();
                button.Appearance = Appearance.Button;
                button.BackColor = Color.FromArgb(18, 214, 168);
                button.FlatStyle = FlatStyle.Flat;
                button.ForeColor = Color.FromArgb(18, 214, 168);


                PictureBox pc = new PictureBox();
                pc.Width = 180;
                pc.Height = 240;
                pc.Name = DataTablePhim.Rows[i][0].ToString();
                pc.SizeMode = PictureBoxSizeMode.StretchImage;
                pc.MouseHover += Pc_MouseHover;
                pc.MouseMove += Pc_MouseMove;
                pc.MouseClick += Pc_MouseClick;
                pc.Image = Image.FromFile(path + DataTablePhim.Rows[i][8].ToString());

                button.Controls.Add(pc);
                pc.SendToBack();
                button.BringToFront();
                flowLayoutPanel1.Controls.Add(button);
                button.Click += Button_Click;
                pc.Click += Pc_Click;
                pc.MouseDoubleClick += Pc_MouseDoubleClick;
               
                //Thông tin phim
                Label l = new Label();
                l.Dock = DockStyle.Left;
                l.Width = 200;
                l.Font = new Font("Arial", 8, FontStyle.Bold);
                l.ForeColor = Color.White;
                l.Text = string.Format("Phim: {0}" + "\nNăm xuất bản: {1}" + "\nĐạo diễn: {2}", DataTablePhim.Rows[i][1].ToString(), DataTablePhim.Rows[i][3].ToString(),
                DataTablePhim.Rows[i][2].ToString());
                flowLayoutPanel1.Controls.Add(l);
            }
        }
        FormKTSuat ktsuat;
        DataTable choNgoi;

        private void Button_Click(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            ktsuat = new FormKTSuat();
            ktsuat.tenphim = r.Name;
            for (int i = 0; i < DataTablePhim.Rows.Count; i++)
            {
                if (DataTablePhim.Rows[i][0].ToString() == r.Name)
                {

                    ktsuat.pathAnh = path + DataTablePhim.Rows[i][8].ToString();
                }
            }
            ktsuat.ShowDialog();
        }

        private void Pc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           

        }

        private void Pc_Click(object sender, EventArgs e)
        {
          
        }

        private void Pc_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Signal_ValueChanged(object sender, EventArgs e) 
        {
            layThongTin();
            choNgoi = ConnectFun.RunQuery("Select * From ChoNgoi_Rap Where MaSC = '" + MASC + "'");
            for (int i= 0; i<pnCho.Controls.Count; i++)
            {
                if (pnCho.Controls[i].Name.StartsWith("bt"))
                {
                    pnCho.Controls[i].Enabled = true;
                    pnCho.Controls[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(244)))), ((int)(((byte)(217)))));
                }    
            }
            foreach (DataRow item in choNgoi.Rows)
            {
                CheckBox cb = pnCho.Controls.Find("bt" + item[1].ToString() + item[2].ToString(), false).FirstOrDefault() as CheckBox;
                if (cb != null)
                {
                    cb.BackColor = Color.Yellow;
                    cb.Enabled = false;
                }

            }
            Dat = choNgoi.Rows.Count;
            lbDat.Text = Dat.ToString();
            Trong = 94 - Dat;
            lbTrong.Text = Trong.ToString();
        }

        private void layThongTin()
        {
            lbTenPhim.Text = TenPhim;
            lbMaSC.Text = MASC;
            lbRap.Text = Rap;
        }


        private void Pc_MouseMove(object sender, MouseEventArgs e)
        {
            
           
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            maKH = txtMaKH.Text;
            if (maKH == "")
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng");
            }
            else
            {
                string query = "Select * From KhachHang Where MaKH = '" + maKH + "'";
                if (ConnectFun.RunQuery(query).Rows.Count == 0)
                {
                    MessageBox.Show("Mã khách hàng sai!");
                    return;
                }
                query = "Select * From HoaDon_KhachHang Where MaKH = '" + maKH + "' And Month(NgayMua) = "+now.Month.ToString()+" And Year(NgayMua) = "+now.Year.ToString();
                soVeMua += ConnectFun.RunQuery(query).Rows.Count;
                if (soVeMua < 20)
                {
                    query = "Update KhachHang Set SoLanDoi = 0 Where MaKH = '" + maKH + "'";
                    ConnectFun.RunQuery(query);
                }
                query = "Select SoLanDoi From KhachHang Where MaKH = '" + maKH + "'";
                soLanGiamGia = int.Parse(ConnectFun.RunQuery(query).Rows[0][0].ToString());
                soVeMua = soVeMua - soLanGiamGia* 2;
                if (soVeMua >= 20)
                {
                    giamGia += thanhTien * 0.02;
                    btDungGG.Enabled = true;
                }
                lbSoLanMua.Text = soVeMua.ToString();
            }
        }

        private void Pc_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string date = now.Day + "/" + now.Month + "/" + now.Year;
            luuDonHang(MaPhim, date, thanhTien.ToString(), giamGia.ToString(), tienPhaiTra.ToString());
            luuVe();
            luuGhe();
            if (maKH != "") updateKhachHang();
            khoiTao();
            MessageBox.Show("Thanh toán thành công!");
        }

        int index = 0;
        private void btDungGG_Click(object sender, EventArgs e)
        {
            if (index == 0)
            {
                soLanGiamGia++;
                giamGia += giamGia * 0.02;
                lbGiamGia.Text = giamGia.ToString() + " đ";
                tienPhaiTra = thanhTien - giamGia;
                lbTienPhaiTra.Text = tienPhaiTra.ToString() + " đ";
                index++;
            }
        }

        

        public void luuDonHang(string MaPhim, string ngayMua, string thanhTien, string giamGia, string tienPhaiTra)
        {
            string query = "Select * From HoaDon";
            int count = ConnectFun.RunQuery(query).Rows.Count;
            maHD = "HD" + count.ToString();
            query = "Insert Into HoaDon Values ('"+ maHD+"','" + MaPhim +"','" + ngayMua + "','" + thanhTien + "','" + giamGia + "','" + tienPhaiTra + "','" + FormLogin.maNV + "')";
            ConnectFun.RunQuery(query);
        }

        public void luuVe()
        {
            string query = "Select * From Ve";
            int count = ConnectFun.RunQuery(query).Rows.Count;
            int i = 1;
            string maVe;
            DateTime now = DateTime.Now;
            string ngayMua = now.Year.ToString() + "/" + now.Month.ToString() + "/" + now.Day.ToString();
            foreach (ListViewItem item in lvThongTin.Items)
            {
                maVe = "VE" + (count + i).ToString();
                query = "Insert Into Ve Values ('"+ maVe +"','" + MaPhim + "','" + MASC + "','" + item.SubItems[1].Text + "',N'" + item.SubItems[2].Text + "','" + maHD + "')";
                ConnectFun.RunQuery(query);
                if (maKH != "")
                {
                    query = "Insert Into HoaDon_KhachHang Values ('" + maHD + "','" + maKH + "','" + maVe+ "','" + ngayMua +"')";
                    ConnectFun.RunQuery(query);
                }
                i++;
            }
 
        }

        public void luuGhe()
        {
            foreach (ListViewItem item in lvThongTin.Items)
            {
                string[] split = item.Text.Split('-');
                string query = "Insert Into ChoNgoi_Rap Values ('" + MASC + "','" + split[0] + "','" + split[1] + "')";
                ConnectFun.RunQuery(query);
            }
        }

        public void updateKhachHang()
        {
            string query = "Update KhachHang Set SoLanDoi = "+ soLanGiamGia+ "Where MaKH = '"+ maKH +"'";
            ConnectFun.RunQuery(query);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}

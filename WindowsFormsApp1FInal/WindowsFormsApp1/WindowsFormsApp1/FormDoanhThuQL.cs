using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            string Sql = "set dateformat dmy Select hd.MaPhim,p.TenPhim,SUM(CAST(TienTra as int)) as N'Tổng doanh thu' From HoaDon hd, Phim p Where p.MaPhim = hd.MaPhim group by hd.MaPhim,p.TenPhim";
            DataTable thongKe = ConnectFun.RunQuery(Sql);
            DoanhThu.DataSource = thongKe;
            for (int i = 0; i < thongKe.Rows.Count; i++)
            {
                DoanhThu.Series["DoanhThu"].Points.AddXY(thongKe.Rows[i][1].ToString(), thongKe.Rows[i][2].ToString());
            }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }
        string sql1;
        string sqll3;
        double tongtien;
        int soHD;
        private void theothang(string sqll, string sqll1)
        {

            DoanhThu.Series["DoanhThu"].Points.Clear();
            DataTable thongKe2 = ConnectFun.RunQuery(sqll);
            DoanhThu.DataSource = thongKe2;
            for (int i = 0; i < thongKe2.Rows.Count; i++)
            {
                DoanhThu.Series["DoanhThu"].Points.AddXY(thongKe2.Rows[i][0].ToString(), thongKe2.Rows[i][1].ToString());
            }
            datagridvPhim.DataSource = ConnectFun.RunQuery(sqll1);
            for (int i = 0; i < datagridvPhim.Rows.Count - 1; i++)
            {
                tongtien += double.Parse(datagridvPhim.Rows[i].Cells[5].Value.ToString());
                soHD++;
            }
            datagridvPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lbHD.Text = soHD.ToString();
            lbTongTien.Text = tongtien.ToString();
        }
        private void theoNam(string sqltheonam,string sqltheonam1)
        {
            DoanhThu.Series["DoanhThu"].Points.Clear();
            DataTable thongKe3 = ConnectFun.RunQuery(sqltheonam);
            DoanhThu.DataSource = thongKe3;
            for (int i = 0; i < thongKe3.Rows.Count; i++)
            {
                DoanhThu.Series["DoanhThu"].Points.AddXY(thongKe3.Rows[i][0].ToString(), thongKe3.Rows[i][1].ToString());
            }
            datagridvPhim.DataSource = ConnectFun.RunQuery(sqltheonam1);
            for (int i = 0; i < datagridvPhim.Rows.Count - 1; i++)
            {
                tongtien += double.Parse(datagridvPhim.Rows[i].Cells[5].Value.ToString());
                soHD++;
            }
            datagridvPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lbHD.Text = soHD.ToString();
            lbTongTien.Text = tongtien.ToString();
        }
        private void btTimKiem_Click(object sender, EventArgs e)
        {
            tongtien = 0;
            soHD = 0;
            if (cbLoaiTG.Text == "Theongay")
            {
                DoanhThu.Series["DoanhThu"].Points.Clear();
                sql1 = "set dateformat dmy  Select p.TenPhim, SUM(CAST(TienTra as int)) as N'Tổng doanh thu' from HoaDon hd, Phim p Where p.MaPhim = hd.MaPhim and NgayMua between CONVERT(date,'"+dtbNBD.Text+"',103) and CONVERT(date,'"+ dtpNKT.Text+"',103) group by hd.MaPhim,p.TenPhim";
                DataTable thongKe1 = ConnectFun.RunQuery(sql1);
                DoanhThu.DataSource = thongKe1;
                for (int i = 0; i < thongKe1.Rows.Count; i++)
                {
                    DoanhThu.Series["DoanhThu"].Points.AddXY(thongKe1.Rows[i][0].ToString(), thongKe1.Rows[i][1].ToString());
                }
                sqll3 = "set dateformat dmy Select hd.*,p.TenPhim From HoaDon hd, Phim p  Where p.MaPhim = hd.MaPhim and NgayMua between CONVERT(date,'" + dtbNBD.Text + "',103) and CONVERT(date,'"+ dtpNKT.Text + "',103)";
                datagridvPhim.DataSource = ConnectFun.RunQuery(sqll3);
                for (int i = 0; i < datagridvPhim.Rows.Count-1; i++)
                {
                    tongtien += double.Parse(datagridvPhim.Rows[i].Cells[5].Value.ToString());
                    soHD++;
                }
                datagridvPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                lbHD.Text = soHD.ToString();
                lbTongTien.Text =  tongtien.ToString();

            }

            if (cbLoaiTG.Text == "Theothang")
            {
                if (dtbNBD.Text == dtpNKT.Text)
                {
                    theothang("set dateformat dmy  Select p.TenPhim, SUM(CAST(TienTra as int)) as N'Tổng doanh thu' from HoaDon hd, Phim p Where p.MaPhim = hd.MaPhim and MONTH(NgayMua) = MONTH(CONVERT(date,'01/" + dtbNBD.Text + "',103)) and YEAR(NgayMua) = YEAR(CONVERT(date,'01/" + dtbNBD.Text + "',103)) group by hd.MaPhim,p.TenPhim", "set dateformat dmy Select hd.*,p.TenPhim From HoaDon hd, Phim p Where p.MaPhim = hd.MaPhim and MONTH(NgayMua) = MONTH(CONVERT(date,'01/" + dtbNBD.Text + "',103)) and YEAR(NgayMua) = YEAR(CONVERT(date,'01/" + dtbNBD.Text + "',103))");
                }
                else
                {
                    theothang("set dateformat dmy Select p.TenPhim, SUM(CAST(TienTra as int)) as N'Tổng doanh thu' from HoaDon hd, Phim p Where p.MaPhim = hd.MaPhim and NgayMua between CONVERT(date, '01/" + dtbNBD.Text + "', 103) and dateadd(day, -1, (dateadd(month, 1, (CONVERT(date, '01/" + dtpNKT.Text + "', 103))))) group by hd.MaPhim, p.TenPhim", "set dateformat dmy Select hd.*, p.TenPhim from HoaDon hd, Phim p Where p.MaPhim = hd.MaPhim and NgayMua between CONVERT(date, '01/" + dtbNBD.Text + "', 103) and dateadd(day, -1, (dateadd(month, 1, (CONVERT(date, '01/" + dtpNKT.Text + "', 103)))))");

                }

            }
            if (cbLoaiTG.Text == "Theonam")
            {
                if (dtbNBD.Text == dtpNKT.Text)
                {
                    theoNam("set dateformat dmy Select p.TenPhim, SUM(CAST(TienTra as int)) as N'Tổng doanh thu' from HoaDon hd, Phim p Where p.MaPhim = hd.MaPhim and YEAR(NgayMua) = YEAR(CONVERT(date, '01/01/"+dtbNBD.Text+"', 103)) group by hd.MaPhim, p.TenPhim", "set dateformat dmy Select hd.*,p.TenPhim From HoaDon hd, Phim p Where p.MaPhim = hd.MaPhim and YEAR(NgayMua) = YEAR(CONVERT(date, '01/01/" + dtbNBD.Text + "', 103))");
                }
                else
                {
                    theoNam("set dateformat dmy Select p.TenPhim, SUM(CAST(TienTra as int)) as N'Tổng doanh thu' from HoaDon hd, Phim p Where p.MaPhim = hd.MaPhim and NgayMua between CONVERT(date, '01/01/" + dtbNBD.Text + "', 103) and dateadd(day, -1, dateadd(year, 1, (CONVERT(date, '01/01/" + dtpNKT.Text + "', 103)))) group by hd.MaPhim, p.TenPhim", "set dateformat dmy Select hd.*,p.TenPhim From HoaDon hd, Phim p Where p.MaPhim = hd.MaPhim and NgayMua between CONVERT(date,'01/01/" + dtbNBD.Text + "',103) and dateadd(day,-1,dateadd(year,1,(CONVERT(date,'01/01/" + dtpNKT.Text + "',103))))");
                }
            }
        }

        private void cbLoaiTG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiTG.SelectedItem.ToString() == "Theongay")
            {
                dtbNBD.CustomFormat = "dd/MM/yyyy";
                dtpNKT.CustomFormat = "dd/MM/yyyy";
            }
            if (cbLoaiTG.SelectedItem.ToString() == "Theothang")
            {
                dtbNBD.CustomFormat = "MM/yyyy";
                dtpNKT.CustomFormat = "MM/yyyy";
            }
            if (cbLoaiTG.SelectedItem.ToString() == "Theonam")
            {
                dtbNBD.CustomFormat = "yyyy";
                dtpNKT.CustomFormat = "yyyy";
            }
        }

        private void cbLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (datagridvPhim.Rows.Count >0)
            {
                if (cbLoc.SelectedItem.ToString() == "Theo số tiền thấp đến cao")
                {
                    datagridvPhim.Sort(datagridvPhim.Columns[5], ListSortDirection.Ascending);
                }
                if (cbLoc.SelectedItem.ToString() == "Theo số tiền cao đến thấp")
                {
                    datagridvPhim.Sort(datagridvPhim.Columns[5], ListSortDirection.Descending);
                }
                if (cbLoc.SelectedItem.ToString() == "Theo ngày thấp đến cao")
                {
                    datagridvPhim.Sort(datagridvPhim.Columns[2], ListSortDirection.Ascending);
                }
                if (cbLoc.SelectedItem.ToString() == "Theo ngày cao đến thấp")
                {
                    datagridvPhim.Sort(datagridvPhim.Columns[2], ListSortDirection.Descending);
                } 
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter;
            SaveFileDialog saveFileDialog;
            string filename = "";
            //Chọn file lưu
            saveFileDialog = new SaveFileDialog();
            //Có thì lưu trên file
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog.FileName;
            }
            //Không có thì lưu file mặc định
            else
            {
                filename = @"E:\Cau23.txt";
            }


            //Lưu
            if (datagridvPhim.Rows.Count > 0)
            {
                if (!File.Exists(filename))
                {
                    streamWriter = new StreamWriter(filename);
                    streamWriter.WriteLine(String.Format("Ngày lập: {0,20}", DateTime.Now) +String.Format("{0,70}", "BÁO CÁO DOANH THU \n\n")
                      + String.Format("{0,-15}", datagridvPhim.Columns[0].HeaderText)
                      + String.Format("{0,-15}", datagridvPhim.Columns[1].HeaderText)
                      + String.Format("{0,-15}", datagridvPhim.Columns[2].HeaderText)
                      + String.Format("{0,-15}", datagridvPhim.Columns[3].HeaderText)
                      + String.Format("{0,-15}", datagridvPhim.Columns[4].HeaderText)
                      + String.Format("{0,-15}", datagridvPhim.Columns[5].HeaderText)
                      + String.Format("{0,-15}", datagridvPhim.Columns[6].HeaderText)
                      + String.Format("{0,-15}", datagridvPhim.Columns[7].HeaderText));
                    for (int i = 0; i < datagridvPhim.Rows.Count - 1; i++)
                    {
                        streamWriter.WriteLine(String.Format("{0,-15}", datagridvPhim.Rows[i].Cells[0].Value)
                       + String.Format("{0,-15}", datagridvPhim.Rows[i].Cells[1].Value)
                       + String.Format("{0,-15}", datagridvPhim.Rows[i].Cells[2].Value)
                       + String.Format("{0,-15}", datagridvPhim.Rows[i].Cells[3].Value)
                       + String.Format("{0,-15}", datagridvPhim.Rows[i].Cells[4].Value)
                       + String.Format("{0,-15}", datagridvPhim.Rows[i].Cells[5].Value)
                       + String.Format("{0,-15}", datagridvPhim.Rows[i].Cells[6].Value)
                       + String.Format("{0,-15}", datagridvPhim.Rows[i].Cells[7].Value));
                    }
                    streamWriter.WriteLine("\n");
                    streamWriter.Close();
                }
                else
                {
                    streamWriter = File.AppendText(filename);
                    streamWriter.WriteLine(String.Format("Ngày lập: {0,20}\n", DateTime.Now) +  String.Format("{0,70}", "BÁO CÁO DOANH THU \n\n")
                      + String.Format("{0,-15}", datagridvPhim.Columns[0].HeaderText)
                      + String.Format("{0,-15}", datagridvPhim.Columns[1].HeaderText)
                      + String.Format("{0,-15}", datagridvPhim.Columns[2].HeaderText)
                      + String.Format("{0,-15}", datagridvPhim.Columns[3].HeaderText)
                      + String.Format("{0,-15}", datagridvPhim.Columns[4].HeaderText)
                      + String.Format("{0,-15}", datagridvPhim.Columns[5].HeaderText)
                      + String.Format("{0,-15}", datagridvPhim.Columns[6].HeaderText)
                      + String.Format("{0,-15}", datagridvPhim.Columns[7].HeaderText));
                    for (int i = 0; i < datagridvPhim.Rows.Count - 1; i++)
                    {
                        streamWriter.WriteLine(String.Format("{0,-15}", datagridvPhim.Rows[i].Cells[0].Value)
                       + String.Format("{0,-15}", datagridvPhim.Rows[i].Cells[1].Value)
                       + String.Format("{0,-15}", datagridvPhim.Rows[i].Cells[2].Value)
                       + String.Format("{0,-15}", datagridvPhim.Rows[i].Cells[3].Value)
                       + String.Format("{0,-15}", datagridvPhim.Rows[i].Cells[4].Value)
                       + String.Format("{0,-15}", datagridvPhim.Rows[i].Cells[5].Value)
                       + String.Format("{0,-15}", datagridvPhim.Rows[i].Cells[6].Value)
                       + String.Format("{0,-15}", datagridvPhim.Rows[i].Cells[7].Value));
                    }
                    streamWriter.WriteLine("\n");
                    streamWriter.Close();
                }
            }
        }
    }
   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
namespace WindowsFormsApp1
{
    public class TSX
    {
       
        public static void Them(string quer,DataGridView datagrid)
        {
            string q = quer;
            datagrid.DataSource = ConnectFun.RunQuery(q);
        }
        public static void Xoa(DataGridView datagrid,string Ma,string dataTB)
        {
            if (datagrid.Rows.Count > 1)
            {
                string MaNVV = Ma;
                int o = datagrid.CurrentRow.Index;
                string deleteby = datagrid.Rows[o].Cells[0].Value.ToString();
                string a = "Delete From "+dataTB+" Where "+Ma+" = '" + deleteby+ "'";
                datagrid.DataSource = ConnectFun.RunQuery(a);
            }
        }
        public static void Xoa1(DataGridView datagrid, string Ma, string cn_raptb,string sctb,string lctb,string phimtb,string mas,string mal)
        {
            if (datagrid.Rows.Count > 1)
            {
                string MaNVV = Ma;
                int o = datagrid.CurrentRow.Index;
                string deleteby = datagrid.Rows[o].Cells[0].Value.ToString(); 
                string a = "Delete From " + cn_raptb + " Where " + mas + " in (Select MaSC From SuatChieu sc Where MaLC in (Select lc.MaLC From LichChieu lc, Phim p Where lc.MaPhim = p.MaPhim and p.MaPhim ='" + deleteby + "'))" +
                    "Delete From " + sctb + " Where " + mal + " in (Select lc.MaLC From LichChieu lc, Phim p Where lc.MaPhim = p.MaPhim and p.MaPhim = '" + deleteby + "') " +
                    "Delete From " + lctb + " Where " + Ma + " = '" + deleteby + "'"+ "Delete From " + phimtb + " Where " + Ma + " = '" + deleteby + "'";
                datagrid.DataSource = ConnectFun.RunQuery(a);
            }
        }
        public static void Xoa2(DataGridView datagrid, string Ma, string cn_raptb, string sctb, string lctb, string mas, string mal)
        {
            if (datagrid.Rows.Count > 1)
            {
                string MaNVV = Ma;
                int o = datagrid.CurrentRow.Index;
                string deleteby = datagrid.Rows[o].Cells[0].Value.ToString();
                string a = "Delete From " + cn_raptb + " Where " + mas + " in (Select MaSC From SuatChieu sc Where MaLC ='" + deleteby + "')" +
                    "Delete From " + sctb + " Where " + mal + "= '" + deleteby +"'"+
                    "Delete From " + lctb + " Where " + Ma + " = '" + deleteby + "'" ;
                datagrid.DataSource = ConnectFun.RunQuery(a);
            }
        }


    }
}

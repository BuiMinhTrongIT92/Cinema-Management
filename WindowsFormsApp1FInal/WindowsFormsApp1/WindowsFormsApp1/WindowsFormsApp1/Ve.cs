using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Ve
    {
        private CheckBox choNgoi;
        private string loaiVe;
        private int gia;

        public Ve(CheckBox choNgoi, string loaiVe, int gia)
        {
            this.choNgoi = choNgoi;
            this.loaiVe = loaiVe;
            this.gia = gia;
        }
        public CheckBox getChoNgoi
        {
            get
            {
                return choNgoi;
            }
            set
            {
                choNgoi = value;
            }
        }
        public string getLoaiVe
        {
            get
            {
                return loaiVe;
            }
            set
            {
                loaiVe = value;
            }
        }
        public int getGia
        {
            get
            {
                return gia;
            }
            set
            {
                gia = value;
            }
        }
    }
}

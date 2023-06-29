using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    public class Model_SinhVien
    {
        private string maSV;

        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }



        private string tenSV;

        public string TenSV
        {
            get { return tenSV; }
            set { tenSV = value; }
        }

        private string ngaySinh;

        public string NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        private string maLop;

        public string MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }

        public Model_SinhVien(string ma, string ten, string ngaysinh, string malop)
        {
            MaLop = ma;
            TenSV = ten;
            NgaySinh = ngaysinh;
            MaLop = malop;
        }

        public Model_SinhVien()
        {

        }


    }
}

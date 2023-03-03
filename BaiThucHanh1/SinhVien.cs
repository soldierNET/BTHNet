using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh1
{
    public abstract class SinhVien
    {
        protected bool gioiTinh;
        protected string hoTen;
        protected DateTime ngaySinh;

        public SinhVien()
        {
            gioiTinh = false;
            hoTen = "";
            ngaySinh = new DateTime();
        }

        public SinhVien(bool g, string h, DateTime n)
        {
            gioiTinh = g;
            hoTen = h;
            ngaySinh = n;
        }

        public abstract double dtb();

        public override string ToString()
        {
            return $"{hoTen}\n{gioiTinh}\n{ngaySinh.ToString()}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh1
{
    public class SinhVienVan : SinhVien
    {
        private double coDien;
        private double hienDai;

        public SinhVienVan() : base()
        {
            coDien = 0;
            hienDai = 0;
        }

        public SinhVienVan(bool g, string h, DateTime n, double c, double hi) : base(g, h, n)
        {
            coDien = c;
            hienDai = hi;
        }

        public override double dtb()
        {
            return (coDien + hienDai) / 2;
        }
    }
}

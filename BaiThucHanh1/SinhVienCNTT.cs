using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh1
{
    public class SinhVienCNTT : SinhVien
    {
        private double csharp;
        private double pascal;
        private double sql;

        public SinhVienCNTT() : base()
        {
            csharp = 0;
            pascal = 0;
            sql = 0;
        }

        public SinhVienCNTT(bool g, string h, DateTime n, double c, double p, double s) : base(g, h, n)
        {
            csharp = c;
            pascal = p;
            sql = s;
        }

        public override double dtb()
        {
            return (csharp + pascal + sql) / 3;
        }
    }
}

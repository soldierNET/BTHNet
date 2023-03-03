using System;

namespace BaiThucHanh1
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien[] sv = {
                new SinhVienCNTT(true, "Albert Einstein", DateTime.Now, 7, 8, 9),
                new SinhVienVan(true, "Willian Shakesphere", DateTime.Today, 10, 5),
            };

            foreach(var s in sv)
            {
                Console.WriteLine(s.ToString());
            }
        }
    }
}

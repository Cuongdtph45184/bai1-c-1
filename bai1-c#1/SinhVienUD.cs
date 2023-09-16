using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_c_1
{
    internal class SinhVienUD : SinhVien
    {
        public int HocKy;
        public SinhVienUD(string maSV, string ten, int namSinh, double diem, int kihoc) : base(maSV, ten, namSinh, diem)
        {
            this.HocKy = kihoc;
        }
        public override void show()
        {
            base.show();
            Console.WriteLine("Hoc ky: " + this.HocKy);
        }
    }
}


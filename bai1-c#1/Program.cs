using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_c_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int str;
            do
            {
                Console.WriteLine("Sinh viên tham gia HappyBee");
                Console.WriteLine("1.Nhập danh sách đối tượng");
                Console.WriteLine("2.Xuất danh sách đối tượng");
                Console.WriteLine("3.Xuất danh sách sinh viên được tặng vé HappyBee");
                Console.WriteLine("4.Xóa sinh viên không được tham gia HappyBee nếu không được tặng");
                Console.WriteLine("5.Kế Thừa");
                Console.WriteLine("6.Thoát");
                Console.Write("Vui lòng chọn chức năng :");
                str = Convert.ToInt32(Console.ReadLine());
                if(str == 6)
                {
                    break;
                }
                switch (str)
                {
                    case 1:
                        Service.Nhap();
                        break;
                    case 2:
                        Service.XuatDS();
                        break;
                    case 3:
                        Service.DSSVHappyBee();
                        break;
                    case 4:
                        Service.Xoa();
                        break;
                    case 5:
                        kethua();
                        break;
                    default:
                        break;

                }

            } while (str != 0);
        }
        static void kethua()
        {
            SinhVienUD svud = new SinhVienUD("ph45111", "Toan",2004,9,2);
            svud.show();
        }
    }
}

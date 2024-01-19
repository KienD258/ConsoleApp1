using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CungThu nhanVat1 = new CungThu();
            nhanVat1.DiemTanCong = 100;
            nhanVat1.DiemPhongThu = 100;
            nhanVat1.HP = 500;
            nhanVat1.TocDo = 500;

            CungThu nhanVat2 = new CungThu(500, 200, 400, 300);

            nhanVat1.KyNang1();

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int c = 100;
            Console.Write("nhap so thu nhat:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so thu hai:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tong hai so {0} va {1} la: {2}", a, b, a + b);

            if (a + b > c)
            {
                Console.WriteLine("tong hai so lon hon 100");
            }
            if else (a + b = c)
            {
                Console.WriteLine("tong hai so bang 100");
            }
            else
                Console.WriteLine("tong hai so nho hon 100");

            Console.ReadKey();

        }
    }
}

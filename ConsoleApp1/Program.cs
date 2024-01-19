using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            Console.Write("\n Nhap vao so thu nhat: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap vao so thu hai: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap vao so ket thuc: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap vao so ket thuc: ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap vao so ket thuc: ");
            e = Convert.ToInt32(Console.ReadLine());

            if (a >= b && a >= c && a >= d && a >= e )
            {
               Console.WriteLine("\n {0} la so lon nhat.", a);
            }    
            if (b >= a && b >= c && b >= d && b >= e)
                Console.WriteLine("\n {0} la so lon nhat.", b);
            if (c >= b && c >= d && c >= e && c >= a)
                Console.WriteLine("\n {0} la so lon nhat.", c);
            if (d >= b && d >= e && d >= a && d >= c)
                Console.WriteLine("\n {0} la so lon nhat.", d);
            else 
                Console.WriteLine("\n {0} la so lon nhat.", e);

            Console.ReadKey();
        }
    }
}

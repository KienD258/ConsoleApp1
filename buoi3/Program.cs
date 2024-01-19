using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*for (int i = 0; i <= 10; i++)
            {
                if (i == 3)
                    continue;
                Console.WriteLine();
            }*/

            /*for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine(so + "x" + i + "=" + so * i);
            }

            int[] diem = new int[5];*/

            /*float[] diemSo = new float[] { 6.5f, 7.0f, 4, 10, 9.5f };
            float trungBinhCong, tong = 0;

            for (int i = 0; i < diemSo.Length; i++)
            {
                tong = tong + diemSo[i];
            }
            trungBinhCong = tong / diemSo.Length;

            Console.WriteLine("Trung binh cong la " + trungBinhCong);*/

            //var soTien = new int[] { 3, 4, 23, 18, 50, 99 };
            //Array.Reverse(soTien);
              //  Console.WriteLine(Array.IndexOf(soTien, 23));

            /*foreach (int i in soTien)
            {
                //Console.WriteLine(i + "");
            }*/

            var arrayList1 = new ArrayList();
            var arrayList2 = new ArrayList();
            

            arrayList1.Add(1);
            arrayList1.Add("");
            arrayList1.Add(true);

            arrayList2.Add(300);

            arrayList2.AddRange(arrayList1);
            Console.WriteLine();

            foreach (var i in arrayList1)
            {
                Console.WriteLine(i);
            }


            Console.ReadKey();
        }
    }
}

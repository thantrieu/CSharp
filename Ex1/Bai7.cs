using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises1
{
    class Bai7
    {
        static void Main()
        {
            int a, b;
            Console.WriteLine("Nhap canh a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap canh b: ");
            b = Convert.ToInt32(Console.ReadLine());

            if(a > 0 && b > 0)
            {
                int chuVi = 2 * (a + b);
                int dienTich = a * b;
                Console.WriteLine("Chu vi = " + chuVi);
                Console.WriteLine("Dien tich = " + dienTich);
            } else
            {
                Console.WriteLine("Canh hinh chu nhat phai > 0");
            }
        }
    }
}

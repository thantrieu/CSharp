using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises1
{
    class Bai10
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap c: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a == 0) // giai pt bac nhat
            {
                if (b == 0 && c == 0)
                {
                    Console.WriteLine("Phuong trinh vo so nghiem");
                }
                else if (b == 0 && c != 0)
                {
                    Console.WriteLine("Phuong trinh khong co nghiem");
                }
                else
                {
                    float x = -c * 1.0f / b;
                    Console.WriteLine("Phuong trinh co nghiem x = " + x);
                }
            }
            else
            {
                int delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh khong co nghiem");
                }
                else if (delta == 0)
                {
                    Console.WriteLine("Phuong trinh co nghiem kep x = " + (-b * 1.0f / (2 * a)));
                }
                else
                {
                    float x1 = (float)(-b - Math.Sqrt(delta)) / (2 * a);
                    float x2 = (float)(-b + Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine("Nghiem phuong trinh la:");
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                }
            }
        }
    }
}

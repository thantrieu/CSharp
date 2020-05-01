using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercises
{
    class Bai58
    {
        static void Main()
        {
            // x + y = 36
            // 2x + 4y = 100
            int a1, a2, b1, b2, c1, c2;
            nhapHeSo(out a1, out a2, out b1, out b2, out c1, out c2);
            hienThKQ(a1, a2, b1, b2, c1, c2);
        }

        private static void hienThKQ(int a1, int a2, int b1, int b2, int c1, int c2)
        {
            if(a1 * b2 - a2 * b1 != 0)
            {
                float x = (c1 * b2 - b1 * c2) / (a1 * b2 - a2 * b1);
                float y = (a1 * c2 - c1 * a2) / (a1 * b2 - a2 * b1);
                Console.WriteLine($"So ga: {x}");
                Console.WriteLine($"So cun: {y}");
            } else
            {
                Console.WriteLine("He phuong trinh vo nghiem");
            }
            
        }

        private static void nhapHeSo(out int a1, out int a2, out int b1, 
            out int b2, out int c1, out int c2)
        {
            Console.WriteLine("Nhap a1: ");
            a1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap a2: ");
            a2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap b1: ");
            b1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap b2: ");
            b2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap c1: ");
            c1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap c2: ");
            c2 = Convert.ToInt32(Console.ReadLine());
        }
    }
}

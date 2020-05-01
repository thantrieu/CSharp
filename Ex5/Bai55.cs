using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercises
{
    class Bai55
    {
        static void Main()
        {
            int a, b;
            nhap(out a, out b);
            Console.WriteLine("Ket qua: ");
            hienThi(a, b);
            Console.WriteLine();
        }

        static void hienThi(int a, int b)
        {
            for (int i = a; i <= b; i++)
            {
                if(chinhPhuong(i))
                {
                    Console.Write(i + " ");
                }
            }
        }

        private static bool chinhPhuong(int i)
        {
            int s = (int)Math.Sqrt(i);
            return s * s == i;
        }

        static void nhap(out int a, out int b)
        {
            a = 0;
            b = 0;
            while(a < 1 || b < 1 || a >= b)
            {
                Console.WriteLine("Nhap so nguyen a > 0: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhap so nguyen b > a: ");
                b = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}

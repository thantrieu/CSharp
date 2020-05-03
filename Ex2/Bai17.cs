using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    class Bai17
    {
        static void Main()
        {
            Console.WriteLine("Nhap vao gia tri m > 0: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap vao gia tri n > 0: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if(m > 0 && n > 0)
            {
                while(m != n)
                {
                    if(m > n)
                    {
                        m -= n;
                    } else
                    {
                        n -= m;
                    }
                }
                if (m == 1)
                {
                    Console.WriteLine("Hai so m, n la nguyen to cung nhau");
                }
                else
                {
                    Console.WriteLine("Hai so m, n khong nguyen to cung nhau");
                }
            } else
            {
                Console.WriteLine("Nhap m, b > 0");
            }
        }
    }
}

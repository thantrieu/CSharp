using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    class Bai8
    {
        static void Main()
        {
            Console.WriteLine("Nhap so a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a >= 0 && b >= 0)
            {
                if (a == 0 && b == 0)
                {
                    Console.WriteLine("Khong ton tai UCLN, BCNN");
                }
                else if (a == 0 || b == 0)
                {
                    Console.WriteLine("Khong co BCNN");
                    Console.WriteLine("UCLN = " + (a == 0 ? b : a));
                }
                else
                {
                    int boi = a * b;
                    //while (a != b)
                    //{
                    //    if (a > b)
                    //    {
                    //        a -= b;
                    //    }
                    //    else
                    //    {
                    //        b -= a;
                    //    }
                    //}

                    // cach 2:
                    while(b != 0)
                    {
                        int x = b;
                        b = b % a;
                        a = x;
                    }
                    Console.WriteLine("UCLN = " + a);
                    Console.WriteLine("BCNN = " + boi / a);
                }
            }
            else
            {
                Console.WriteLine("Nhap a, b la so nguyen duong");
            }
        }
    }
}

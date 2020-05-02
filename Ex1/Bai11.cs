using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises1
{
    class Bai11
    {
        static void Main()
        {
            float a, b, c;
            Console.WriteLine("Nhap canh a: ");
            a = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Nhap canh b: ");
            b = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Nhap canh c: ");
            c = Convert.ToSingle(Console.ReadLine());

            if(a + b > c && b + c > a && c + a > b)
            {
                // deu:
                if(a == b && b == c)
                {
                    Console.WriteLine("Tam giac deu");
                } else if(a == b || a == c || c == b)
                {
                    if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (a * a == b * b + c * c))
                    {
                        Console.WriteLine("Tam giac vuong can");
                    } else
                    {
                        Console.WriteLine("Tam giac can");
                    }
                } else if((a*a + b*b == c*c) || (a*a + c*c == b*b) || (a*a == b*b + c*c))
                {
                    Console.WriteLine("Tam giac vuong");
                } else
                {
                    Console.WriteLine("Tam giac thuong");
                }
            } else
            {
                Console.WriteLine("Ba canh tren khong lap thanh tam giac");
            }
        }
    }
}

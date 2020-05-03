using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    class Bai9
    {
        static void Main()
        {
            Console.WriteLine("Nhap so nguyen n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n < 2)
            {
                Console.WriteLine("Khong phai so nguyen to");
            } else
            {
                bool laSoNT = true;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if(n % i == 0)
                    {
                        laSoNT = false;
                        break;
                    }
                }
                if(laSoNT)
                {
                    Console.WriteLine($"{n} la so nguyen to");
                } else
                {
                    Console.WriteLine($"{n} khong phai so nguyen to");
                }
            }
        }
    }
}

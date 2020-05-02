using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    class Bai2
    {
        static void Main()
        {
            Console.WriteLine("Nhap so tu nhien n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n > 0)
            {
                int sum = default;
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }
                Console.WriteLine("Tong 1 + 2 + ... + n = " + sum);
            } else
            {
                Console.WriteLine("Hay nhap n > 0");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    class Bai6
    {
        static void Main()
        {
            Console.WriteLine("Nhap so tu nhien n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            if (k <= 0)
            {
                Console.WriteLine("Gia tri k khong hop le. Nhap lai k.");
            }
            else
            {
                int sum = default;
                for (int i = 1; i <= n; i++)
                {
                    if (i % k == 0)
                    {
                        sum += i;
                    }
                }
                Console.WriteLine("KQ = " + sum);
            }
        }
    }
}

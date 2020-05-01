using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercises
{
    class Bai54
    {
        static void Main()
        {
            // k = 2, 10^(k-1) = 10, 10 ^ k - 1
            // 10 - > 99
            int k;
            nhap(out k);
            hienThi(k);
            Console.WriteLine();
        }

        private static void hienThi(int k)
        {
            for (int i = (int)Math.Pow(10, k - 1); i <= (int)Math.Pow(10, k) - 1; i++)
            {
                if(thuanNghich(i))
                {
                    Console.Write(i + " ");
                }
            }
        }

        private static bool thuanNghich(int i)
        {
            int dao = 0;
            int m = i;
             while(m > 0)
            {
                dao = dao * 10 + m % 10;
                m /= 10;
            }
            return dao == i;
        }

        private static void nhap(out int k)
        {
            k = 0;
            while(k < 2 || k > 9)
            {
                Console.WriteLine("Nhap gia tri k: 1 < k < 10");
                k = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}

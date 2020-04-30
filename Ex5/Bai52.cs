using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercises
{
    // 1234321
    class Bai52
    {
        static void Main()
        {
            int n = nhapN();
            hienThiKQ(n);
            Console.WriteLine();
        }

        static void hienThiKQ(int n)
        {
            int count = 0;
            int i = 2;
            while(count < n)
            {
                if(ktraNgto(i))
                {
                    count++;
                    Console.Write(i + " ");
                }
                i++;
            }
        }

        static bool ktraNgto(int n)
        {
            if(n < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static int nhapN()
        {
            int n = 0;
            while(n <= 0)
            {
                Console.WriteLine("Nhap n > 0: ");
                n = Convert.ToInt32(Console.ReadLine());
                if(n > 0)
                {
                    break;
                }
            }
            return n;
        }
    }
}

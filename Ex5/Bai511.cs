using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercises
{
    class Bai511
    {
        static void Main()
        {
            int n;
            NhapN(out n);
            LietKeUoc(n);
            LietKeUocNT(n);
            TinhTongUoc(n);
        }

        private static void TinhTongUoc(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Tong cac uoc cua {n} la {sum}");
        }

        private static void LietKeUocNT(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0 && Ngto(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        private static bool Ngto(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static void LietKeUoc(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        private static void NhapN(out int n)
        {
            n = 0;
            while (n <= 0)
            {
                Console.WriteLine("Nhap n > 0: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}

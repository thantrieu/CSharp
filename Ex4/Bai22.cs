using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises4
{
    class Bai22
    {
        static void Main()
        {
            int[,] a, b, s;
            int m = 0, n = 0;
            Console.WriteLine("Nhap so hang: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so cot: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap ma tran A: ");
            Nhap(m, n, out a);

            Console.WriteLine("Nhap ma tran B: ");
            Nhap(m, n, out b);

            Tong(a, b, out s, m, n);
            Console.WriteLine("Ma tran A: ");
            HienThi(a, m, n);
            Console.WriteLine("Ma tran B: ");
            HienThi(b, m, n);
            Console.WriteLine("Ma tran S: ");
            HienThi(s, m, n);
        }

        static void Tong(int[,] a, int[,] b, out int[,] s, int m, int n)
        {
            s = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    s[i, j] = a[i, j] + b[i, j];
                }
            }
        }

        static void HienThi(int[,] arr, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static void Nhap(int m, int n, out int[,] a)
        {
            a = new int[m, n];
            // nhap ma tran a:
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"a[{i}, {j}] = ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}

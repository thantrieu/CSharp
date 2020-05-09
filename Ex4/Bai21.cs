using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises4
{
    class Bai21
    {
        static void Main()
        {
            int[,] a, b;
            int m, n;
            Nhap(out m, out n, out a);
            ChuyenVi(a, out b, m, n);
            Console.WriteLine("Ma tran goc: ");
            HienThi(a, m, n);
            Console.WriteLine("Ma tran chuyen vi: ");
            HienThi(b, n, m);
        }

        private static void ChuyenVi(int[,] a, out int[,] b, int m, int n)
        {
            b = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    b[i, j] = a[j, i];
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

        static void Nhap(out int m, out int n, out int[,] a)
        {
            Console.WriteLine("Nhap so hang: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so cot: ");
            n = Convert.ToInt32(Console.ReadLine());
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

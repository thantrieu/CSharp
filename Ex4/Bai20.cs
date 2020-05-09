using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises4
{
    class Bai20
    {
        static void Main()
        {
            int[,] arr;
            int m, n;
            Nhap(out arr, out m, out n);
            HienThi(arr, m, n);
            MaxTrenHang(arr, m, n);
        }

        static void MaxTrenHang(int[,] arr, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                int max = arr[i, 0];
                for (int j = 0; j < n; j++)
                {
                    if(arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
                Console.WriteLine($"MAX hang {i} = {max}");
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

        static void Nhap(out int[,] arr, out int m, out int n)
        {
            Console.WriteLine("Nhap so hang: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so cot: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"Nhap a[{i}, {j}] = ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises4
{
    class Bai13
    {
        static void Main()
        {
            int[] arr;
            NhapMang(out arr);
            int k;
            NhapK(out k, arr.Length);
            Console.WriteLine("Mang goc: ");
            HienMang(arr, arr.Length);
            Console.WriteLine("Mang sau khi xoa: ");
            Xoa(arr, k);
            HienMang(arr, arr.Length - 1);
        }

        static void Xoa(int[] arr, int k)
        {
            for (int i = k; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i] + 1;
            }
        }

        static void NhapK(out int k, int n)
        {
            k = -1;
            while(k < 0 || k >= n)
            {
                Console.WriteLine($"Nhap 0 <= k < {n}");
                k = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void HienMang(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void NhapMang(out int[] arr)
        {
            Console.WriteLine("Nhap so phan tu mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Phan tu thu {i} = ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("Nhap so phan tu mang > 0");
                arr = null;
            }
        }
    }
}

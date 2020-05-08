using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises4
{
    class Bai12
    {
        static void Main()
        {
            int[] arr;
            int x, k;
            NhapMang(out arr);
            NhapXK(out x, out k, arr.Length);
            Console.WriteLine("Mang truoc khi chen: ");
            HienMang(arr, arr.Length - 1);
            Chen(arr, x, k);
            Console.WriteLine("Mang sau khi chen: ");
            HienMang(arr, arr.Length);
        }

        private static void Chen(int[] arr, int x, int k)
        {
            // dich phai tat ca ptu tu vtri k:
            for (int i = arr.Length - 1; i > k; i--)
            {
                arr[i] = arr[i - 1];
            }
            // chen:
            arr[k] = x;
        }

        static void HienMang(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void NhapXK(out int x, out int k, int n)
        {
            Console.WriteLine("Nhap x: ");
            x = Convert.ToInt32(Console.ReadLine());
            while(true)
            {
                Console.WriteLine($"Nhap k: 0 <= k < {n}");
                k = Convert.ToInt32(Console.ReadLine());
                if(k >= 0 && k < n)
                {
                    break;
                }
            }
        }

        static void NhapMang(out int[] arr)
        {
            Console.WriteLine("Nhap so phan tu mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n > 0)
            {
                arr = new int[n];
                for (int i = 0; i < n-1; i++)
                {
                    Console.WriteLine($"Phan tu thu {i} = ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
            } else
            {
                Console.WriteLine("Nhap so phan tu mang > 0");
                arr = null;
            }
        }
    }
}

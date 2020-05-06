using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises4
{
    class Bai10
    {
        static void Main()
        {
            int[] arr = NhapMang();
            HienMangGoc(arr);
            HienThi(arr);
        }

        static void HienMangGoc(int[] arr)
        {
            Console.WriteLine("Mang goc ban dau: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void HienThi(int[] arr)
        {
            Console.WriteLine("Mang sau khi tinh giam: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if(ChuaXH(arr, i, arr[i]))
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
        }

        static bool ChuaXH(int[] arr, int current, int v)
        {
            for (int i = 0; i < current; i++)
            {
                if(arr[i] == v)
                {
                    return false;
                }
            }
            return true;
        }

        static int[] NhapMang()
        {
            int n = 0;
            while (n <= 0)
            {
                Console.WriteLine("Nhap so phan tu mang: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap phan tu thu {i}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
    }
}

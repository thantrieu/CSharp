using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Exercises4
{
    class Bai3
    {
        static void Main()
        {
            Console.WriteLine("Nhap so phan tu mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n > 0)
            {
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Nhap phan tu thu {i}: ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Mang truoc sap xep: ");
                HienThi(arr);

                Console.WriteLine("Mang sau sap xep tang: ");
                Array.Sort(arr);
                HienThi(arr);

                Console.WriteLine("Mang sau sap xep giam: ");
                Array.Reverse(arr);
                HienThi(arr);
            } else
            {
                Console.WriteLine("Nhap so phan tu mang > 0");
            }
        }

        private static void HienThi(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

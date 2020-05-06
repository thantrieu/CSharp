using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises4
{
    class Bai7
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
                int a, b;
                Console.WriteLine("Nhap a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhap b > a: ");
                b = Convert.ToInt32(Console.ReadLine());

                if (a > b)
                {
                    Console.WriteLine("Nhap a < b");
                } else
                {
                    int sum = 0;
                    for (int i = 0; i < n; i++)
                    {
                        if(arr[i] >= a && arr[i] <= b)
                        {
                            sum += arr[i];
                        }
                    }
                    Console.WriteLine("Cac phan tu mang: ");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(arr[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine($"Tong cac phan tu trong [{a}, {b}] = {sum}");
                }
            } else
            {
                Console.WriteLine("So phan tu mang phai duong");
            }
        } 
    }
}

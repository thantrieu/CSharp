using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises4
{
    class Bai4
    {
        static void Main()
        {
            Console.WriteLine("Nhap so phan tu mang > 0: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n > 0)
            {
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Nhap phan tu thu {i}: ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Nhap x: ");
                int x = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    if(arr[i] == x)
                    {
                        count++;
                    }
                }

                Console.WriteLine("Cac phan tu mang: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine($"\nSo lan xuat hien cua {x} trong mang la {count}");
            }
            else
            {
                Console.WriteLine("So phan tu mang phai duong");
            }
        }
    }
}

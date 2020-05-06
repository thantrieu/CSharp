using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises4
{
    class Bai5
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
                    Console.WriteLine($"Phan tu thu {i} = ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Nhap gia tri x: ");
                int x = Convert.ToInt32(Console.ReadLine());

                int min = Math.Abs(x - arr[0]);
                for (int i = 1; i < n; i++)
                {
                    int tmp = Math.Abs(x - arr[i]);
                    if(tmp < min)
                    {
                        min = tmp;
                    }
                }
                // liet ke vi tri cua phan tu co gia tri gan x nhat:
                Console.WriteLine("Vi tri cac phan tu gan x nhat: ");
                for (int i = 0; i < n; i++)
                {
                    int tmp = Math.Abs(x - arr[i]);
                    if(tmp == min)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            } else
            {
                Console.WriteLine("So phan tu mang phai la nguyen duong");
            }
        }
    }
}

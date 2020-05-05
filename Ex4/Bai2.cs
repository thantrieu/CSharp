using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises4
{
    class Bai2
    {
        static void Main()
        {
            Console.WriteLine("Nhap so phan tu mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                int[] numbers = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Nhap phan tu thu {i}: ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                int min = numbers[0];
                int max = numbers[0];
                int max2, min2;
                // tim max, min
                for (int i = 1; i < n; i++)
                {
                    if(max < numbers[i])
                    {
                        max = numbers[i];
                    }
                    if(min > numbers[i])
                    {
                        min = numbers[i];
                    }
                }

                max2 = min;
                min2 = max;
                // tim max2, min2
                for (int i = 0; i < n; i++)
                {
                    if(max2 < numbers[i] && numbers[i] != max)
                    {
                        max2 = numbers[i];
                    }
                    if(min2 > numbers[i] && numbers[i] != min)
                    {
                        min2 = numbers[i];
                    }
                }
                if(min2 == min)
                {
                    Console.WriteLine("Khong co gia tri nho thu hai");
                } else
                {
                    Console.WriteLine("Gia tri nho thu hai: " + min2);
                }

                if(max2 == max)
                {
                    Console.WriteLine("Khong co gia tri lon thu hai");
                } else
                {
                    Console.WriteLine("Gia tri lon thu hai la: " + max2);
                }
            }
            else
            {
                Console.WriteLine("Nhap so phan tu mang la so duong");
            }
        }
    }
}

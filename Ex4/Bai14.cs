using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises4
{
    class Bai14
    {
        static void Main()
        {
            int[] arr;
            NhapMang(out arr);
            Console.WriteLine("Mang goc: ");
            SapXep(arr);
            HienMang(arr, arr.Length - 1);
            Console.WriteLine("Nhap x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            ChenX(arr, x);
            Console.WriteLine("Mang sau khi chen: ");
            HienMang(arr, arr.Length);
        }

        static void ChenX(int[] arr, int x)
        {
            int pos = -1;
            // b1: tim vi tri de chen
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if(arr[i] > x)
                {
                    pos = i;
                    break;
                }
            }
            // b2: dich phai neu can:
            if(pos == -1)
            {
                arr[arr.Length - 1] = x;
            } else
            {
                for (int i = arr.Length - 1; i > pos; i--)
                {
                    arr[i] = arr[i - 1];
                }
            }
            // b3: gan
            if(pos != -1)
            {
                arr[pos] = x;
            }
        }

        static void SapXep(int[] arr)
        {
            int size = arr.Length - 1;
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = size - 1; j > i; j--)
                {
                    if(arr[j] < arr[j - 1])
                    {
                        int t = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = t;
                    }
                }
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
                for (int i = 0; i < n - 1; i++)
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

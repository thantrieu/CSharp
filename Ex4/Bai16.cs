using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises4
{
    class Bai16
    {
        static void Main()
        {
            int[] arr, start, end;
            int n, size;
            NhapMang(out arr, out n);
            HienMang(arr);
            TimViTri(arr, out start, out end, out size);
            KetLuan(arr, start, end, size);
        }

        static void KetLuan(int[] arr, int[] start, int[] end, int size)
        {
            if(size == arr.Length)
            {
                Console.WriteLine("Khong co duong chay max");
            } else
            {
                int max = TimMax(start, end, size);
                for (int i = 0; i < size; i++)
                {
                    int len = end[i] - start[i] + 1;
                    if(len == max)
                    {
                        HienKQ(arr, start[i], max);
                    }
                }
            }
        }

        static void HienKQ(int[] arr, int v, int max)
        {
            Console.WriteLine($"Vi tri bat dau: {v}, do dai: {max}");
            Console.WriteLine("Cac phan tu cua duong chay: ");
            for (int i = v; i < v + max; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        static int TimMax(int[] start, int[] end, int size)
        {
            int max = end[0] - start[0] + 1;
            for (int i = 1; i < size; i++)
            {
                int len = end[i] - start[i] + 1;
                if(len > max)
                {
                    max = len;
                }
            }
            return max;
        }

        static void TimViTri(int[] arr, out int[] start, out int[] end, out int size)
        {
            size = 0;
            start = new int[arr.Length];
            end = new int[arr.Length];
            start[0] = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if(arr[i] > arr[i + 1])
                {
                    end[size++] = i;
                    start[size] = i + 1;
                }
            }
            end[size++] = arr.Length - 1;
        }

        static void HienMang(int[] arr)
        {
            Console.WriteLine("Mang goc: ");
            if(arr == null)
            {
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void NhapMang(out int[] arr, out int n)
        {
            Console.WriteLine("Nhap so phan tu mang: ");
            n = Convert.ToInt32(Console.ReadLine());
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
                n = 0;
                Console.WriteLine("Nhap so phan tu mang > 0");
                arr = null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises4
{
    class Bai11
    {
        static void Main()
        {
            int[] arr;
            SinhMang(out arr);
            HienMang(arr);
        }

        static void SinhMang(out int[] arr)
        {
            Console.WriteLine("Nhap so phan tu mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                arr = new int[n];
                Random rand = new Random();
                int i = 0;
                while (i < n)
                {
                    int x = rand.Next(100, 500);
                    if (ChuaXuatHienX(arr, i, x))
                    {
                        arr[i++] = x;
                    }
                }
            }
            else
            {
                Console.WriteLine("So phan tu mang phai nguyen duong");
                arr = null;
            }

        }

        static bool ChuaXuatHienX(int[] arr, int size, int x)
        {
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == x)
                {
                    return false;
                }
            }
            return true;
        }

        static void HienMang(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

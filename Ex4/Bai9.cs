using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises4
{
    class Bai9
    {
        static void Main()
        {
            int[] arr = NhapMang();
            bool[] b = PhanLoai(arr);
            HienThiMang(arr);
            KetQua(arr, b);
        }

        static void HienThiMang(int[] arr)
        {
            Console.WriteLine("Cac phan tu trong mang: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void KetQua(int[] arr, bool[] b)
        {
            Console.WriteLine("Ket qua: ");
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if(b[i])
                {
                    int dem = Dem(arr, arr[i]);
                    Console.WriteLine($"{arr[i]} xuat hien {dem} lan");
                }
            }
        }

        static int Dem(int[] arr, int x)
        {
            int dem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(x == arr[i])
                {
                    dem++;
                }
            }
            return dem;
        }

        static bool[] PhanLoai(int[] arr)
        {
            bool[] a = new bool[arr.Length];
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                bool x = true;
                for (int j = 0; j < i; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        x = false;
                        break;
                    }
                }
                a[i] = x;
            }
            return a;
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

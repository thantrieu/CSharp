using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises1
{
    class Bai3
    {
        static void Main()
        {
            Console.WriteLine("Nhap so nguyen a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap so nguyen b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int tong = a + b;
            int hieu = a - b;
            int tich = a * b;

            Console.WriteLine($"Tong {a} + {b} = {tong}");
            Console.WriteLine($"Hieu {a} - {b} = {hieu}");
            Console.WriteLine($"Tich {a} * {b} = {tich}");

            if (b != 0)
            {
                float thuong = (float)a / b;
                int du = a % b;
                Console.WriteLine($"Thuong {a} / {b} = {thuong}");
                Console.WriteLine($"Phan du {a} % {b} = {du}");
            } else
            {
                Console.WriteLine("Khong thuc hien duoc phep chia va phep lay du");
            }
            
        }
    }
}

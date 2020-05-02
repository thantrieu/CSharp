using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises1
{
    class Bai8
    {
        static void Main()
        {
            Console.WriteLine("Nhap ban kinh r > 0: ");
            float r = Convert.ToSingle(Console.ReadLine());
            if (r > 0)
            {
                float chuVi = (float)(2 * Math.PI * r);
                float s = (float)(Math.PI * r * r);
                Console.WriteLine($"Chu vi duong tron ban kinh {r} la {chuVi}");
                Console.WriteLine($"Dien tich duong tron ban kinh {r} la {s}");
            } else
            {
                Console.WriteLine("Ban kinh duong tron phai duong");
            }
        }
    }
}

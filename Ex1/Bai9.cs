using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercises1
{
    class Bai9
    {
        static void Main()
        {
            int a, b;
            Console.WriteLine("Nhap he so a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap he so b: ");
            b = Convert.ToInt32(Console.ReadLine());

            if(a == 0 && b == 0)
            {
                Console.WriteLine("Phuong trinh vo so nghiem");
            } else if(a == 0 && b != 0)
            {
                Console.WriteLine("Phuong trinh khong co nghiem");
            }
            else
            {
                float x = -b*1.0f / a;
                Console.WriteLine("Phuong trinh co nghiem x = " + x);
            }
        }
    }
}

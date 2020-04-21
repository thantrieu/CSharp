using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class RefModifier
    {
        static void Main()
        {
            // reference parameter
            // ref
            string name = "";
            int age = default; // 0
            float mark = 8.0f;

            ShowResult(name, age, mark);

            Console.WriteLine("============================");
            GetUserInfo(ref name, ref age, ref mark);

            ShowResult(name, age, mark);
        }

        private static void ShowResult(string name, int age, float mark)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Mark: " + mark);
        }

        private static void GetUserInfo(ref string name, ref int age, ref float mark)
        {
            Console.WriteLine("Nhap ten: ");
            name = Console.ReadLine();

            Console.WriteLine("Nhap tuoi cua ban: ");
            age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Nhap diem cua ban: ");
            //mark = Convert.ToSingle(Console.ReadLine());
        }
    }
}

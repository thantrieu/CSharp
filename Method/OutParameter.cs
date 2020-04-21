using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class OutParameter
    {
        static void Main()
        {
            // output parameter
            GetUserInfo(out string name, out int age, out float mark);
            ShowResult(name, age, mark);
        }

        private static void ShowResult(string name, int age, float mark)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Mark: " + mark);
        }

        private static void GetUserInfo(out string name, out int age, out float mark)
        {
            Console.WriteLine("Nhap ten: ");
            name = Console.ReadLine();

            Console.WriteLine("Nhap tuoi cua ban: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap diem cua ban: ");
            mark = Convert.ToSingle(Console.ReadLine());
        }
    }
}

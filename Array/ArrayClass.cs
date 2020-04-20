using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClass
{
    class ArrayClass
    {
        static void Main(string[] args)
        {
            // Tìm hiểu lớp Array trong C#
            int[] numbers = { 1, 2, 5, 4, 3, 2, 5, 9, 8, 5, 4, 1, 0, 2, 3, 6 };
            string[] names = { "Hung", "Loan", "Ha", "Mai", "Linh", "Anh", "Tung" };

            //Array.Sort(numbers); // tang dan cac gia tri trong mang
            //Array.Reverse(numbers); // dao cac phan trong mang
            //Array.Clear(numbers, 0, numbers.Length);

            Array.Sort(names);
            //int indexOfMai = Array.IndexOf(names, "Mai");
            foreach (var name in names)
            {
                Console.Write(name + ", ");
            }
            Console.WriteLine();
            //Console.WriteLine("Vi tri trong mang: " + indexOfMai);

        }
    }
}

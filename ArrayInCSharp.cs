using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class ArrayInCSharp
    {
        static void Main(string[] args)
        {
            /* - Mảng là gì? dùng làm cái gì?
             * - Khai báo, khởi tạo mảng
             * - Sử dụng mảng
             * - Độ dài của mảng
             * - Duyệt mảng
             * - Vòng lặp foreach
             * - Sắp xếp mảng
             */
            int a, b, c;
            int[] numbers = new int[] { 5, 6, 8, 9, 7, 4, 5, 1, 2, 0, 3, 6, 5, 8, 9 };
            //type[] name;
            //string[] cars = new string[900];


            string[] friends = new string[] { "Lan", "Hung", "Anh", "Linh", "Nam", "Trung", "Hoang", "Khanh" };
            //friends[2] = "Loan";
            /*
            Console.WriteLine("============ DANH SACH BAN CUA TOI ===========");
            for (int i = 0; i < friends.Length; i++)
            {
                Console.WriteLine(friends[i]);
            }

            Console.WriteLine("============= SU DUNG FOREACH =============");
            foreach (var friend in friends)
            {
                Console.WriteLine(friend);
            }
            */
            Console.WriteLine("============== SAU SAP XEP ===============");
            // sap xep mang
            Array.Sort(numbers);
            // hien thi cac phan tu mang
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}

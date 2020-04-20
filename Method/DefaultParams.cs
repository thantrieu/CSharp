using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class DefaultParams
    {
        // tham số mặc định, gọi phương thức theo tên tham số
        static void Main()
        {
            ShowInfo(mid: "Trung", last:"Tran", first: "Kien");
        }

        static void ShowInfo(string first = "No name", string last = "Nguyen", string mid = "")
        {
            Console.WriteLine("First name: " + first);
            Console.WriteLine("Mid name: " + mid);
            Console.WriteLine("Last name: " + last);
        }
    }
}

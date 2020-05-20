using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor myInstructor = new Instructor("ABC123");
            Console.WriteLine(myInstructor.InsId);

            Employee e = new Employee();
            e.Password = "my password";

            //Student nam = new Student("B24DCCN123", "Nam", "nam@xmail.com", 20);
            //Console.WriteLine("Tuoi goc: " + nam.Age);
            //nam.Age = 25;
            //Console.WriteLine("Tuoi moi: " + nam.Age);
            //nam.Id = "B24DCCN124";
            //Console.WriteLine("Ma sinh vien: " + nam.Id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Test
    {
        static void Main()
        {
            // tim hieu automatic properties
            Instructor myInstructor = new Instructor("INS123456")
            {
                Name = "Tran Van Hung",
                Salary = 50,
                Age = 30,
                Subject = new Subject
                {
                    Name = "C++"
                }
            };
            //myInstructor.Subject = new Subject();
            Console.WriteLine("Instructor id: " + myInstructor.Id);
            Console.WriteLine("Name: " + myInstructor.Name);
            Console.WriteLine("Age: " + myInstructor.Age);
            Console.WriteLine("Salary: " + myInstructor.Salary);
            Console.WriteLine("He teaches " + myInstructor.Subject.Name);
        }
    }
}

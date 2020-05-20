using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Student
    {
        private string id;
        private string firstName;
        //private string email;
        private int age;

        public Student()
        {

        }

        public Student(string id, string first, string email, int age)
        {
            Id = id;
            FirstName = first;
            Email = email;
            Age = age;
        }

        public string Id
        {
            get => id;
            set
            {
                if (value.Length > 0 && value.Length <= 20)
                {
                    id = value;
                }
                else
                {
                    Console.WriteLine("Ma sv khong hop le.");
                }
            }
        }

        public string Email
        {
            get;// => email;
            set;// => email = value;
        }

        public int Age
        {
            get => age;
            set
            {
                if (value < 0 || value > 200)
                {
                    Console.WriteLine("Tuoi ban cung cap khong hop le");
                }
                else
                {
                    age = value;
                }
            }
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                if (value.Length > 0 && value.Length <= 15)
                {
                    firstName = value;
                }
                else
                {
                    Console.WriteLine("Ten khong hop le");
                }
            }
        }
    }
}

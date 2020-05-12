using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Dog
    {
        public string name;
        public int age;
        public string color;

        //public Dog() : this("", 0, "")
        //{
        //}

        //public Dog(string name) : this(name, 0, "")
        //{
        //}

        //public Dog(string name, int age, string color)
        //{
        //    this.age = age;
        //    this.name = name;
        //    this.color = color;
        //}

        public Dog(string name = "Bob", int age = 3, string color = "Black")
        {
            //Console.WriteLine(this.GetHashCode());
            this.name = name;
            this.age = age;
            this.color = color;
        }
    }
}

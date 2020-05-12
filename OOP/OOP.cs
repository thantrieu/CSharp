using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class OOP
    {
        static void Main(string[] args)
        {
            /* - Hướng đối tượng là gì?
             * - Lớp là gì?
             * - Đối tượng là gì?
             * - Biểu diễn thông tin trong lớp như nào?
             * - Cách tạo ra đối tượng ra làm sao?
             * 
             */

            Cat tom = new Cat();
            tom.Eat();
            tom.Move();
            tom.petName = "Meow";
            Console.WriteLine("new name of the cat: " + tom.petName);
            Fish fell = new Fish();
            Dog bob = new Dog();
            Dog d = new Dog();
        }
    }
}

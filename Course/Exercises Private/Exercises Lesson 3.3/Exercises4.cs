/**
 * <author>Branium Academy</author>
 * <version>2022.03.01</version>
 * <seealso cref="Home" href="https://braniumacademy.net"/>
 */

using System;

namespace ExercisesLesson33
{
    class Exercises4
    {
        static void Main()
        {
            char grade = char.Parse(Console.ReadLine());
            switch (grade)
            {
                case 'F':
                case 'f':
                    Console.WriteLine("Liet");
                    break;
                case 'D':
                case 'd':
                    Console.WriteLine("Yeu");
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine("Trung binh");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("Kha");
                    break;
                case 'A':
                case 'a':
                    Console.WriteLine("Gioi");
                    break;
                default:
                    Console.WriteLine("INVALID");
                    break;
            }
        }
    }
}

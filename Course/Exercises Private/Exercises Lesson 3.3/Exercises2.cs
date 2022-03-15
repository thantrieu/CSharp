/**
 * <author>Branium Academy</author>
 * <version>2022.03.01</version>
 * <seealso cref="Home" href="https://braniumacademy.net"/>
 */

using System;

namespace ExercisesLesson33
{
    class Exercises2
    {
        static void Main()
        {
            int dayOfWeek = int.Parse(Console.ReadLine());
            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("INVALID");
                    break;
            }
        }
    }
}

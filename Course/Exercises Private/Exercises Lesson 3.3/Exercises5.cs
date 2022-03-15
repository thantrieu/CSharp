/**
 * <author>Branium Academy</author>
 * <version>2022.03.01</version>
 * <seealso cref="Home" href="https://braniumacademy.net"/>
 */

using System;

namespace ExercisesLesson33
{
    class Exercises5
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var data = input.Split(' ');
            var day = int.Parse(data[0]);
            var month = int.Parse(data[1]);
            switch (month)
            {
                case 1: // xét tháng trước
                    if (1 <= day && day <= 19) // sau đó xét ngày
                    {
                        Console.WriteLine("Ma Ket");
                    }
                    else if (20 <= day && day <= 31)
                    {
                        Console.WriteLine("Bao Binh");
                    }
                    else
                    {
                        Console.WriteLine("INVALID DAY");
                    }
                    break;
                case 2:
                    if (1 <= day && day <= 18)
                    {
                        Console.WriteLine("Bao Binh");
                    }
                    else if (19 <= day && day <= 29)
                    {
                        Console.WriteLine("Song Ngu");
                    }
                    else
                    {
                        Console.WriteLine("INVALID DAY");
                    }
                    break;
                case 3:
                    if (1 <= day && day <= 20)
                    {
                        Console.WriteLine("Song Ngu");
                    }
                    else if (21 <= day && day <= 31)
                    {
                        Console.WriteLine("Bach Duong");

                    }
                    else
                    {
                        Console.WriteLine("INVALID DAY");
                    }
                    break;
                case 4:
                    if (1 <= day && day <= 20)
                    {
                        Console.WriteLine("Bach Duong");
                    }

                    else if (21 <= day && day <= 30)
                    {
                        Console.WriteLine("Kim Nguu");
                    }

                    else
                    {
                        Console.WriteLine("INVALID DAY");
                    }
                    break;
                case 5:
                    if (1 <= day && day <= 20)
                    {
                        Console.WriteLine("Kim Nguu");
                    }

                    else if (21 <= day && day <= 31)
                    {
                        Console.WriteLine("Song Tu");
                    }
                    else
                    {
                        Console.WriteLine("INVALID DAY");
                    }
                    break;
                case 6:
                    if (1 <= day && day <= 21)
                    {
                        Console.WriteLine("Song Tu");
                    }
                    else if (22 <= day && day <= 30)
                    {
                        Console.WriteLine("Cu Giai");
                    }
                    else
                    {
                        Console.WriteLine("INVALID DAY");
                    }
                    break;
                case 7:
                    if (1 <= day && day <= 22)
                    {
                        Console.WriteLine("Cu Giai");
                    }

                    else if (23 <= day && day <= 31)
                    {
                        Console.WriteLine("Su Tu");
                    }
                    else
                    {
                        Console.WriteLine("INVALID DAY");
                    }
                    break;
                case 8:
                    if (1 <= day && day <= 22)
                    {
                        Console.WriteLine("Su Tu");
                    }
                    else if (23 <= day && day <= 31)
                    {
                        Console.WriteLine("Xu Nu");
                    }
                    else
                    {
                        Console.WriteLine("INVALID DAY");
                    }
                    break;
                case 9:
                    if (1 <= day && day <= 22)
                    {
                        Console.WriteLine("Xu Nu");

                    }
                    else if (23 <= day && day <= 30)
                    {
                        Console.WriteLine("Thien Binh");
                    }
                    else
                    {
                        Console.WriteLine("INVALID DAY");
                    }
                    break;
                case 10:
                    if (1 <= day && day <= 23)
                    {
                        Console.WriteLine("Thien Binh");
                    }
                    else if (24 <= day && day <= 31)
                    {
                        Console.WriteLine("Bo Cap");
                    }
                    else
                    {
                        Console.WriteLine("INVALID DAY");
                    }
                    break;
                case 11:
                    if (1 <= day && day <= 22)
                    {
                        Console.WriteLine("Bo Cap");
                    }
                    else if (23 <= day && day <= 30)
                    {
                        Console.WriteLine("Nhan Ma");
                    }
                    else
                    {
                        Console.WriteLine("INVALID DAY");
                    }
                    break;
                case 12:
                    if (1 <= day && day <= 21)
                    {
                        Console.WriteLine("Nhan Ma");
                    }
                    else if (22 <= day && day <= 31)
                    {
                        Console.WriteLine("Ma Ket");
                    }
                    else
                    {
                        Console.WriteLine("INVALID DAY");
                    }
                    break;
                default:
                    Console.WriteLine("INVALID_MONTH");
                    break;
            }
        }
    }
}

/**
 * <author>Branium Academy</author>
 * <version>2022.03.01</version>
 * <seealso cref="Home" href="https://braniumacademy.net"/>
 */

using System;

namespace ExercisesLesson33
{
    class Exercises1
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var data = input.Split(' ');
            float a = float.Parse(data[0]); // lấy số a
            float b = float.Parse(data[2]); // lấy số b
            string op = data[1]; // lấy phép toán
            switch (op)
            {
                case "+":
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    break;
                case "-":
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case "*":
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;
                case "/":
                    if (b == 0) // nếu mẫu số bằng 0 -> lỗi chia cho 0
                    {
                        Console.WriteLine("ERROR");
                    }
                    else
                    {
                        Console.WriteLine($"{a} / {b} = {a / b}");
                    }
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}

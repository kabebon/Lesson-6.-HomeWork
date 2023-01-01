using System;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson6
{
    class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("1.Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
                Console.WriteLine("2.Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
                Console.Write("Выбери номер задания:");
                if (TryGetUserInput(out int value))
                {
                    switch (value)
                    {
                        case 1: Task41.Task41Main(); break;
                        case 2: Task43.Task43Main(); break;
                        default: Console.WriteLine("Извини, такой задачи нет :(. Попробуй еще раз!"); break;
                    }
                }
            }

        }

        private static bool IsString(string input)
        {
            return !int.TryParse(input, out _);
        }

        private static bool TryGetUserInput(out int value)
        {
            string input = Console.ReadLine();
            if (IsString(input))
            {
                value = 0;
                Console.WriteLine("Введи число, а не букву!");
                return false;
            }

            else
            {
                value = int.Parse(input);
                return true;
            }
        }
    }

    class Task41
    {
        public static void Task41Main()
        {
            Console.WriteLine("Привет! Введи несколько чисел через пробел :)");
            int[] numbers = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
            PrintPositiveNumbers(numbers);
            Console.WriteLine();
            CountPositiveNumbers(numbers);
            Console.ReadKey();

        }
        private static void PrintPositiveNumbers(int[] numbers)
        {
            Console.WriteLine("Положительные числа из твоего ввода: ");
            foreach (int number in numbers)
            {
                if (number > 0)

                {
                    Console.Write(number + " ");
                }
            }
        }


        private static void CountPositiveNumbers(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                    count++;
            }
            Console.WriteLine("Количество положительных чисел из твоего ввода: ");
            Console.WriteLine(count);
        }
    }

    class Task43
    {
        public static void Task43Main()
        {
            Console.Write("Введите k1: ");
            double k1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b1: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите k2: ");
            double k2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b2: ");
            double b2 = Convert.ToDouble(Console.ReadLine());


            double x = -(b1 - b2) / (k1 - k2);
            double y = k1 * x + b1;

            x = Math.Round(x, 3);
            y = Math.Round(y, 3);

            Console.WriteLine($"Пересечение в точке: ({x};{y})");

        }
    }
}
using System;
using System.Collections.Generic;

namespace ex34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandExit = "exit";
            const string CommandSum = "sum";

            int integer;
            bool isOpen = true;
            List<int> numbers = new List<int>();

            while (isOpen)
            {
                Console.SetCursorPosition(0, 15);
                Console.WriteLine($"Введенные числа: ");

                foreach (var number in numbers)
                {
                    Console.WriteLine(number);
                }

                Console.SetCursorPosition(0, 0);
                Console.Write($"{CommandSum} - суммировать все введеные числа\n{CommandExit} - выход из программы\n\n" +
                    $"Введите число или команду: ");
                var input = Console.ReadLine();

                if (input == CommandExit)
                {
                    isOpen = false;
                }
                else if (input == CommandSum)
                {
                    SumNumbers(numbers);
                }
                else if(int.TryParse(input, out integer))
                {
                    numbers.Add(integer);
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        static void SumNumbers(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine($"Сумма введенных чисел равна: {sum}");
        }
    }
}

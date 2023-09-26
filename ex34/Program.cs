using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandExit = "exit";
            const string CommandSum = "sum";

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
                Console.Write("Введите число, команду sum или exit: ");
                string input = Console.ReadLine();

                if (input != CommandExit && input != CommandSum)
                {
                    numbers.Add(Convert.ToInt32(input));
                }
                else if (input == CommandSum)
                {
                    int sum = 0;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }

                    Console.WriteLine($"Сумма введенных чисел равна: {sum}");
                }
                else if (input == CommandExit)
                {
                    isOpen = false;
                }
                else
                {
                    Console.WriteLine("Неверный ввод...");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

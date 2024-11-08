using System;
using System.Collections.Generic;

namespace Exercise3ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            HashSet<int> numbers = new HashSet<int>();

            while (true)
            {
                Console.Write("Введите число (или пустую строку для выхода): ");
                string input = Console.ReadLine();

                // Проверка на пустую строку для завершения программы
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                // Попытка преобразования ввода в целое число
                if (int.TryParse(input, out int number))
                {
                    // Проверка, присутствует ли число в HashSet
                    if (numbers.Add(number))
                    {
                        Console.WriteLine("Число успешно сохранено.");
                    }
                    else
                    {
                        Console.WriteLine("Число уже вводилось ранее.");
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                }
            }
        }
    }
}

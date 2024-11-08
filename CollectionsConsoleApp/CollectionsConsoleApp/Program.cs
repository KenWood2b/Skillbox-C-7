using System;
using System.Collections.Generic;

namespace CollectionsConsoleApp
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>();

            // Заполнение листа 100 случайными числами
            FillList(numbers);
            Console.WriteLine("Исходный список чисел:");
            DisplayList(numbers);

            // Удаление чисел, которые больше 25, но меньше 50
            RemoveNumbersInRange(numbers, 25, 50);
            Console.WriteLine("\nСписок после удаления чисел в диапазоне от 26 до 49:");
            DisplayList(numbers);
        }

        // Метод для заполнения листа 100 случайными числами в диапазоне от 0 до 100
        static void FillList(List<int> list)
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                list.Add(random.Next(0, 101)); // Генерация случайного числа от 0 до 100 включительно
            }
        }

        // Метод для удаления чисел из листа, которые больше min и меньше max
        static void RemoveNumbersInRange(List<int> list, int min, int max)
        {
            list.RemoveAll(number => number > min && number < max);
        }

        // Метод для вывода чисел из листа на экран
        static void DisplayList(List<int> list)
        {
            foreach (int number in list)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine(); // Переход на новую строку после вывода всех чисел
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;

namespace Exercise2ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            // Ввод номеров телефонов и ФИО
            Console.WriteLine("Введите номер телефона и ФИО владельца (для завершения оставьте строку пустой):");
            CollectPhoneNumbers(phoneBook);

            // Поиск владельца по номеру телефона
            Console.WriteLine("\nПоиск владельца по номеру телефона:");
            SearchOwnerByPhoneNumber(phoneBook);
        }

        // Метод для ввода номеров телефонов и ФИО владельцев
        static void CollectPhoneNumbers(Dictionary<string, string> phoneBook)
        {
            while (true)
            {
                Console.Write("Введите номер телефона: ");
                string phoneNumber = Console.ReadLine();

                // Проверка на пустую строку для завершения ввода
                if (string.IsNullOrEmpty(phoneNumber))
                {
                    break;
                }

                Console.Write("Введите ФИО владельца: ");
                string ownerName = Console.ReadLine();

                // Добавляем номер телефона и ФИО в словарь
                if (!phoneBook.ContainsKey(phoneNumber))
                {
                    phoneBook[phoneNumber] = ownerName;
                    Console.WriteLine("Запись добавлена.");
                }
                else
                {
                    Console.WriteLine("Этот номер телефона уже существует в книге. Попробуйте другой номер.");
                }
            }
        }

        // Метод для поиска владельца по номеру телефона
        static void SearchOwnerByPhoneNumber(Dictionary<string, string> phoneBook)
        {
            Console.Write("Введите номер телефона для поиска: ");
            string searchNumber = Console.ReadLine();

            if (phoneBook.TryGetValue(searchNumber, out string ownerName))
            {
                Console.WriteLine($"Владелец номера {searchNumber}: {ownerName}");
            }
            else
            {
                Console.WriteLine("Владелец с таким номером телефона не найден.");
            }
        }
    }
}

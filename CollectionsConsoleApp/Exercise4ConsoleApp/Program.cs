using System;
using System.Xml.Linq;

namespace Exercise4ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            // Запрос данных у пользователя
            Console.Write("Введите ФИО: ");
            string fullName = Console.ReadLine();

            Console.Write("Введите улицу: ");
            string street = Console.ReadLine();

            Console.Write("Введите номер дома: ");
            string houseNumber = Console.ReadLine();

            Console.Write("Введите номер квартиры: ");
            string flatNumber = Console.ReadLine();

            Console.Write("Введите мобильный телефон: ");
            string mobilePhone = Console.ReadLine();

            Console.Write("Введите домашний телефон: ");
            string flatPhone = Console.ReadLine();

            // Создание XML структуры с помощью XElement
            XElement contact = new XElement("Person",
                new XAttribute("name", fullName),
                new XElement("Address",
                    new XElement("Street", street),
                    new XElement("HouseNumber", houseNumber),
                    new XElement("FlatNumber", flatNumber)
                ),
                new XElement("Phones",
                    new XElement("MobilePhone", mobilePhone),
                    new XElement("FlatPhone", flatPhone)
                )
            );

            // Сохранение XML файла
            string fileName = "contact.xml";
            contact.Save(fileName);

            Console.WriteLine($"Данные о контакте сохранены в файл {fileName}");
        }
    }
}

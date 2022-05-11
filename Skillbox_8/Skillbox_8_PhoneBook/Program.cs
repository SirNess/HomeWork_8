using System;
using System.Collections.Generic;

namespace Skillbox_8_PhoneBook
{
    internal class Program
    {
        /// <summary>
        /// Метод заполнения колекции
        /// </summary>
        /// <param name="PhoneBook"></param>
        public static void Filing(Dictionary<string, string> PhoneBook)
        {
            string key;
            string name;
            do
            {
                Console.WriteLine("Введите номер телефна");
                key = Console.ReadLine();
                if (key == "")
                {
                    break;
                }
                Console.WriteLine("Введите ФИО");
                name = Console.ReadLine();
                PhoneBook.Add(key, name);

            } while (true);
        }
        /// <summary>
        /// Метод поиска по номеру телефона
        /// </summary>
        /// <param name="PhoneBook"></param>
        public static void Search(Dictionary<string, string> PhoneBook)
        {
            string name;
            Console.WriteLine("Найти пользователя по номеру телефона");
            string Search = Console.ReadLine();
            if (PhoneBook.TryGetValue(Search, out name))
            {
                Console.WriteLine($"{Search} : {name}");
            }
            else
            {
                Console.WriteLine($"{Search} - не найден пользователй с таким номером");
            }
        }

        static void Main(string[] args)
        {
            
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
            Filing(PhoneBook); //Создание колекции
            Search(PhoneBook); //Поиск по номеру телефона
            

        }
    }
}

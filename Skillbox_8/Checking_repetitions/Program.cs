using System;
using System.Collections.Generic;

namespace Checking_repetitions
{
    internal class Program
    {
        /// <summary>
        /// Метод заполения коллекции
        /// </summary>
        /// <param Коллекция="vs"></param>
        public static void Create(HashSet<int> vs)
        {
            while (true)
            {
                Console.WriteLine("Введите число: ");
                string number = Console.ReadLine();
                if (number == "") //Для окончания ввода. Введите пустую строку
                {
                    break;
                }
                if (vs.Contains(Convert.ToInt32(number)) == true) // Проверка наличия вводимого числа в коллекции
                {
                    Console.WriteLine("Данное число уже содержится в коллекции.");
                }
                else
                {
                    vs.Add(Convert.ToInt32(number));//Добавление числа в HashSet
                }

            }
        }
        /// <summary>
        /// Метод вывода коллекции в консоль
        /// </summary>
        /// <param Коллекция="vs"></param>
        public static void PrintToConsole(HashSet<int> vs)
        {
            foreach (var item in vs)
            {
                Console.WriteLine(item);

            }
        }
        static void Main(string[] args)
        {
            HashSet<int> vs = new HashSet<int>();
            Create(vs); //Создание колекции
            PrintToConsole(vs); //Вывод колекции в консоль
        }
    }
}

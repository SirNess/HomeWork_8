using System;
using System.Collections.Generic;

namespace Skillbox_8
{
    internal class Program
    {
        /// <summary>
        /// Метод заполения коллекции рандомными числами
        /// </summary>
        /// <param name="number"></param>
        public static void  CreateNumber(List<int> number)
        {
            for (int i = 0; i < 100; i++)
            {
                Random r = new Random();
                number.Add(r.Next(101));
            }
        }
        /// <summary>
        /// Вывод всей коллекции в консоль
        /// </summary>
        /// <param name="number"></param>
        public static void PrintNumber(List<int> number)
        {
            for (int i = 0; i < number.Count; i++)
            {
                Console.WriteLine($"{i + 1} = {number[i]}");
            }
        }
        /// <summary>
        /// Метод удаления чисел от 25 до 50
        /// </summary>
        /// <param name="number"></param>
        public static void DeleteNumber(List<int> number)
        { 
            for (int i = 0; i < number.Count; i++)
            {
                if (number[i] >25 & number[i]<50)
                {
                    number.Remove(number[i]);
                }
            }
            PrintNumber(number);
        }
        static void Main(string[] args)
        {
            List<int> number = new List<int>();
            CreateNumber(number); //Заполенине листа
            PrintNumber(number); //Вывод листа на экран
            Console.ReadKey(); //Пауза
            DeleteNumber(number); // Удаление всех чисел по условию и вывод нового листа на экран
            

        }
    }
}

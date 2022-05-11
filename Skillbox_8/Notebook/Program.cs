using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace Notebook
{
    internal class Program
    {
        /*<Person name =”ФИО человека” >
               <Address>
                   <Street>Название улицы</Street>
                   <HouseNumber>Номер дома</HouseNumber>
                   <FlatNumber>Номер квартиры</FlatNumber>
               </Address>
               <Phones>
                   <MobilePhone>89999999999999</MobilePhone>
                   <FlatPhone>123-45-67<FlatPhone>
               </Phones>
           </Person>*/
        static void Main(string[] args)
        {
            People people = new People(); //Создание объекта
            Console.WriteLine("Введите ФИО");
            people.Name = Console.ReadLine();
            XElement PersonName = new XElement("Person", new XAttribute("name", people.Name)); //Создание элемента Person с атрибутами
            XElement Adress = new XElement("Address"); //Создание элемента адрес
            Console.WriteLine("Введите улицу");
            people.Street = Console.ReadLine();
            XElement Street = new XElement("Street", people.Street);//Создание элемента улица
            Console.WriteLine("Введите номер дома");           
            people.Numberhome = Console.ReadLine();
            XElement HouseNumber = new XElement("HouseNumber", people.Numberhome);//Создание элемента номер дома
            Console.WriteLine("Введите номер квартиры");
            people.Numberflat = Console.ReadLine();
            XElement FlatNumber = new XElement("FlatNumber", people.Numberflat); //Создание элемента номер квартиры
            Adress.Add(Street, HouseNumber, FlatNumber);//Добавление в элемент адрес - улицу, номер дома, номер квартиры.
            XElement Phones = new XElement("Phones"); // Создание элемента Телефоны
            Console.WriteLine("Введите номер мобильного телефона");
            people.Mobilephone = Console.ReadLine();
            XElement MobilePhone = new XElement("MobilePhone", people.Mobilephone); //Создание элемента мобильный телефон
            Console.WriteLine("Введите номер домашнего телефона");
            people.Homephone = Console.ReadLine();
            XElement FlatPhone = new XElement("FlatPhone", people.Numberflat); // Создание эелемента домашний телефон
            Phones.Add(MobilePhone, FlatPhone); // Добавление в элемент Телефоны - мобильный и домашний номера
            PersonName.Add(Adress, Phones);
            PersonName.Save("test.xml");

            

        }
    }
}

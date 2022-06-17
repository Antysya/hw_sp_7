using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Collections;


namespace hw_sp_7
{

    class Program
    {
        static void Main(string[] args)
        {
            Country book = new Country();

            try
            {
                book.Country_City.Add("Москва", "Россия");
                book.Country_City.Add("Тверь", "Россия");
                book.Country_City.Add("Пекин", "Китай");
                book.Country_City.Add("Томск", "Россия");
                book.Country_City.Add("Шанхай", "Китай");
                book.Country_City.Add("Нью-Йорк", "США");
                book.Country_City.Add("Вашингтон", "США");
                book.Country_City.Add("Майами", "США");
                book.Country_City.Add("Париж", "Франция");
                book.Country_City.Add("Леон", "Франция");

            }
            catch (ArgumentException e)
            {
                WriteLine("\n\nУже существует:", e.Message);
            }
            while (true)
            {
                WriteLine("\nВыберите необходимое действие:\n1. По названию страны – определить города, входящие в эту страну;\n" +
                "2. По названию города – определить к какой стране он принадлежит;\n3. Добавить город в библиотеку.\n" +
                "4. Весь справочник.\n5. Выход");
                string pos = ReadLine();
                switch (pos)
                {
                    case "1":
                        {
                            WriteLine("по названию страны – определить города, входящие в эту страну");
                            WriteLine("Введите название страны: \n");
                            string country = ReadLine();
                            book.TransCountry(country);
                        }
                        break;

                    case "2":
                        {
                            WriteLine("по названию города – определить к какой стране он принадлежит");
                            WriteLine("Введите название города:");
                            string city = ReadLine();
                            book.TransCity(city);
                        }
                        break;
                    case "3":
                        {
                            WriteLine("Добавить город в библиотеку");
                            WriteLine("Введите название города:");
                            string city = ReadLine();
                            WriteLine("Введите название страны, к которй относится город:");
                            string country = ReadLine();
                            try
                            {
                                book.Country_City.Add(city, country);

                            }
                            catch (ArgumentException e)
                            {
                                WriteLine("\n\nУже существует", e.Message);
                            }
                        }
                        break;

                    case "4":
                        {
                            WriteLine("Весь справочник:\n");
                            book.PrintDictionary();
                        }
                        break;

                    case "5":
                        return;

                    default:
                        WriteLine("Вы выбрали несуществующий пункт меню. Выберите снова.");
                        continue;
                }

            }

        }
    }
}

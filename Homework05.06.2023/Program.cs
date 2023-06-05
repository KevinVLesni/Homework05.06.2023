using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework05._06._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            string[,] books =
            {
                { "Александр Пушкин", "Михаил Лермонтов", "Сергей Есенин" },
                { "Роберт Мартин", "Джесси Шелл", "Сергей Тепляков" },
                { "Стивен Кинг", "Говард Лавкрафт", "Брем Стокер" }
            };

            while (isOpen)
            {
                Console.SetCursorPosition(0, 20);
                Console.WriteLine("\nВесь список авторов:\n");
                for (int j = 0; j < books.GetLength(0); j++)
                {
                    for (int i = 0; i < books.GetLength(1); i++)
                    {
                        Console.Write(books[j, i] + " | ");
                    }
                    Console.WriteLine();
                }
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Библиотека.");
                Console.WriteLine("\n1 - Узнать имя автора по индексу книги. " +
                                  "\n\n2 - Найти книгу по автору. \n\n3 - Выход из программы.");
                Console.Write("Выберите пункт меню: ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int line, colume;
                        Console.Write("Введите номер полки: ");
                        line = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.Write("Введите номер столбца: ");
                        colume = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("Это автор: " + books[line, colume]);
                        break;
                    case 2:
                        string author;
                        bool authorIsFound = false;
                        Console.Write("Введите автора: ");
                        author = Console.ReadLine();
                        for (int i = 0; i < books.GetLength(0); i++);
                        {
                            for (int j = 0; j  < books.GetLength(1); j ++)
                            {
                                    int i = 0; //
                                if(author == books[j, i])
                                {
                                    Console.Write($"Автор {books[j, i]} находится по адресу полка | столбец;  " +
                                        (i + 1), (j + 1));
                                    authorIsFound = true;
                                }
                            }
                        }
                        if (authorIsFound == false)
                        {
                            Console.WriteLine("Такого автора нет в нашей библиотеке!");
                        }

                            break;
                    case 3:
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("Введена некорректная команда!");
                        break;
                }

                if (isOpen)
                {
                    Console.WriteLine("\nНажмите любую клавишу для перезагрузки окна консоли.");
                }

                Console.ReadKey();
            }
        }
    }
}

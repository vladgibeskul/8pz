using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _82
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод количества изданий (n)
            Console.Write("Введите количество изданий: ");
            int n = int.Parse(Console.ReadLine());

            // Создаём массив (по условию именно массив, не List)
            Publication[] catalog = new Publication[n];

            // Заполнение массива
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nИздание #{i + 1}");
                Console.WriteLine("Выберите тип: 1-Книга, 2-Статья, 3-Ресурс");
                int type = int.Parse(Console.ReadLine());

                Console.Write("Название: ");
                string title = Console.ReadLine();

                Console.Write("Фамилия автора: ");
                string author = Console.ReadLine();

                // В зависимости от типа создаём нужный объект
                if (type == 1)
                {
                    Console.Write("Год: ");
                    int year = int.Parse(Console.ReadLine());

                    Console.Write("Издательство: ");
                    string publisher = Console.ReadLine();

                    catalog[i] = new Book(title, author, year, publisher);
                }
                else if (type == 2)
                {
                    Console.Write("Журнал: ");
                    string journal = Console.ReadLine();

                    Console.Write("Номер: ");
                    int number = int.Parse(Console.ReadLine());

                    Console.Write("Год: ");
                    int year = int.Parse(Console.ReadLine());

                    catalog[i] = new Article(title, author, journal, number, year);
                }
                else if (type == 3)
                {
                    Console.Write("Ссылка: ");
                    string link = Console.ReadLine();

                    Console.Write("Аннотация: ");
                    string annotation = Console.ReadLine();

                    catalog[i] = new ElectronicResource(title, author, link, annotation);
                }
            }

            /////////////////////////////////////////////////////////////
            // Вывод всей информации из каталога
            /////////////////////////////////////////////////////////////
            Console.WriteLine("\n--- Каталог ---");
            foreach (var item in catalog)
            {
                item.PrintInfo(); // Полиморфизм
            }

            // Поиск по фамилии автора
            /////////////////////////////////////////////////////////////
            Console.Write("\nВведите фамилию автора для поиска: ");
            string search = Console.ReadLine();

            Console.WriteLine("\n--- Результаты поиска ---");

            bool found = false;

            foreach (var item in catalog)
            {
                if (item.AuthorSurname.Equals(search, StringComparison.OrdinalIgnoreCase))
                {
                    item.PrintInfo();
                    found = true;
                }
            }

            // Если ничего не найдено
            if (!found)
            {
                Console.WriteLine("Ничего не найдено.");
            }
        }
    }
}

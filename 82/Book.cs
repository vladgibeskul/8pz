using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _82
{
    public class Book : Publication
    {
        public int Year;
        public string Publisher;

        public Book(string title, string author, int year, string publisher)
            : base(title, author)
        {
            Year = year;
            Publisher = publisher;
        }

        // Реализация метода вывода
        public override void PrintInfo()
        {
            Console.WriteLine($"Книга: {Title}, Автор: {AuthorSurname}, Год: {Year}, Издательство: {Publisher}");
        }
    }
}

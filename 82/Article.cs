using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _82
{
    public class Article : Publication
    {
        public string Journal;
        public int Number;
        public int Year;

        public Article(string title, string author, string journal, int number, int year)
            : base(title, author)
        {
            Journal = journal;
            Number = number;
            Year = year;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Статья: {Title}, Автор: {AuthorSurname}, Журнал: {Journal}, №{Number}, Год: {Year}");
        }
    }
}

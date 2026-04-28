using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _82
{
    public abstract class Publication
    {
        public string Title;          // Название
        public string AuthorSurname;  // Фамилия автора

        // Конструктор
        public Publication(string title, string author)
        {
            Title = title;
            AuthorSurname = author;
        }

        // Абстрактный метод (обязан быть реализован в наследниках)
        public abstract void PrintInfo();
    }
}

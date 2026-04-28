using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _82
{
     public class ElectronicResource : Publication
    {
        public string Link;
        public string Annotation;

        public ElectronicResource(string title, string author, string link, string annotation)
            : base(title, author)
        {
            Link = link;
            Annotation = annotation;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Ресурс: {Title}, Автор: {AuthorSurname}, Ссылка: {Link}, Описание: {Annotation}");
        }
    }
}

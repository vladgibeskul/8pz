using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _81
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ПРОГРАММА: ЗЕМЕЛЬНЫЙ УЧАСТОК И ПОЛЕ ===");
            Console.WriteLine();

            // ========== ВВОД ДАННЫХ ДЛЯ БАЗОВОГО КЛАССА ==========
            Console.WriteLine("--- Введите данные для ЗЕМЕЛЬНОГО УЧАСТКА ---");

            Console.Write("Введите длину участка (м): ");
            double length1 = double.Parse(Console.ReadLine());

            Console.Write("Введите ширину участка (м): ");
            double width1 = double.Parse(Console.ReadLine());

            // Создание объекта базового класса
            LandPlot участок = new LandPlot(length1, width1);
            Console.WriteLine();

            // Вывод информации об участке
            участок.PrintInfo();
            Console.WriteLine("Площадь участка: " + участок.GetArea() + " кв.м");
            Console.WriteLine();

            // ========== ВВОД ДАННЫХ ДЛЯ ПРОИЗВОДНОГО КЛАССА ==========
            Console.WriteLine("--- Введите данные для ПОЛЯ ---");

            Console.Write("Введите длину поля (м): ");
            double length2 = double.Parse(Console.ReadLine());

            Console.Write("Введите ширину поля (м): ");
            double width2 = double.Parse(Console.ReadLine());

            Console.Write("Введите название посеянной культуры: ");
            string crop = Console.ReadLine();

            Console.Write("Введите урожайность (кг/кв.м): ");
            double yield = double.Parse(Console.ReadLine());

            // Создание объекта производного класса
            Field поле = new Field(length2, width2, crop, yield);
            Console.WriteLine();

            // Вывод информации о поле
            поле.PrintInfo();
            Console.WriteLine();

            // ========== ДОПОЛНИТЕЛЬНАЯ ПРОВЕРКА МЕТОДОВ ==========
            Console.WriteLine("--- Дополнительная проверка ---");
            Console.WriteLine("Площадь поля (метод базового класса): " + поле.GetArea() + " кв.м");
            Console.WriteLine("Урожай со всего поля (метод потомка): " + поле.GetTotalHarvest() + " кг");
            Console.WriteLine();

            // ========== ДЕМОНСТРАЦИЯ ПОЛИМОРФИЗМА ==========
            Console.WriteLine("--- Демонстрация полиморфизма ---");
            Console.WriteLine("Создадим еще одно поле через указатель на базовый класс");

            Console.Write("Введите длину второго поля (м): ");
            double length3 = double.Parse(Console.ReadLine());

            Console.Write("Введите ширину второго поля (м): ");
            double width3 = double.Parse(Console.ReadLine()); ;

            Console.Write("Введите название культуры для второго поля: ");
            string crop2 = Console.ReadLine();

            Console.Write("Введите урожайность для второго поля (кг/кв.м): ");
            double yield2 = double.Parse(Console.ReadLine());

            // Полиморфизмнная: переме базового класса ссылается на объект производного
            LandPlot полиморфныйОбъект = new Field(length3, width3, crop2, yield2);
            Console.WriteLine();

            // Вызовется метод PrintInfo() из класса Field
            полиморфныйОбъект.PrintInfo();
            Console.WriteLine();

            // ========== МАССИВ ОБЪЕКТОВ ==========
            Console.WriteLine("--- Создание массива объектов ---");
            Console.Write("Сколько объектов вы хотите создать? ");
            int count = Convert.ToInt32(Console.ReadLine());

            LandPlot[] объекты = new LandPlot[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Объект " + (i + 1) + ":");
                Console.Write("Какой объект создать? (1 - Земельный участок, 2 - Поле): ");
                int type = int.Parse(Console.ReadLine());

                if (type == 1)
                {
                    Console.Write("Введите длину: ");
                    double l = double.Parse(Console.ReadLine());
                    Console.Write("Введите ширину: ");
                    double w = double.Parse(Console.ReadLine());
                    объекты[i] = new LandPlot(l, w);
                }
                if (type == 2)
                {
                    Console.Write("Введите длину: ");
                    double l = double.Parse(Console.ReadLine());
                    Console.Write("Введите ширину: ");
                    double w = double.Parse(Console.ReadLine());
                    Console.Write("Введите название культуры: ");
                    string c = Console.ReadLine();
                    Console.Write("Введите урожайность: ");
                    double y = double.Parse(Console.ReadLine());
                    объекты[i] = new Field(l, w, c, y);
                }
                else {
                    Console.WriteLine("Вы вели некоректное число");
                    
                
                }
            }

            // Вывод всех объектов из массива
            Console.WriteLine();
            Console.WriteLine("=== ВЫВОД ВСЕХ ОБЪЕКТОВ ИЗ МАССИВА ===");
            for (int i = 0; i < объекты.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Объект " + (i + 1) + ":");
                объекты[i].PrintInfo();
            }

            Console.WriteLine();
            Console.WriteLine("Программа завершена. Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}

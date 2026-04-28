using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _81
{
    class Field : LandPlot
    {
        private string cropName;
        private double yieldPerUnit;

        // Конструктор производного класса
        public Field(double length, double width, string cropName, double yieldPerUnit)
            : base(length, width)
        {
            this.cropName = cropName;
            this.yieldPerUnit = yieldPerUnit;
        }

        // Новый метод: Найти урожай со всего поля
        public double GetTotalHarvest()
        {
            return GetArea() * yieldPerUnit;
        }

        // Переопределенный метод вывода информации
        public override void PrintInfo()
        {
            Console.WriteLine("=== Поле ===");
            Console.WriteLine("Длина: " + length + " м");
            Console.WriteLine("Ширина: " + width + " м");
            Console.WriteLine("Площадь: " + GetArea() + " кв.м");
            Console.WriteLine("Посеянная культура: " + cropName);
            Console.WriteLine("Урожайность: " + yieldPerUnit + " кг/кв.м");
            Console.WriteLine("Урожай со всего поля: " + GetTotalHarvest() + " кг");
        }


    }
}


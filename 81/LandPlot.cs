using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _81
{
    class LandPlot
    {
        protected double length;
        protected double width;

        // Конструктор с параметрами
        public LandPlot(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        // Метод: Площадь участка
        public double GetArea()
        {
            return length * width;
        }

        // Виртуальный метод вывода информации
        public virtual void PrintInfo()
        {
            Console.WriteLine("=== Земельный участок ===");
            Console.WriteLine("Длина: " + length + " м");
            Console.WriteLine("Ширина: " + width + " м");
            Console.WriteLine("Площадь: " + GetArea() + " кв.м");
        }

    }
}

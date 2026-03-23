using System;

namespace Reka
{
    class River
    {
        public string name;
        public double area;
        public double length;
        public River()
        {
            name = "";
            area = 0;
            length = 0;
        }
        public River(string name, double area, double length)
        {
            this.name = name;
            this.area = area;
            this.length = length;
        }
        public void Print()
        {
            Console.WriteLine($"Название: {name}");
            Console.WriteLine($"Площадь бассейна: {area} кв.км.");
            Console.WriteLine($"Протяженность: {length} км.");
            Console.WriteLine();
        }
        public override string ToString()
        {
            return $"Река: {name} имеет площадь бассейна : {area} km2 с протяженностью: {length} km";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            River r1 = new River();
            r1.name = "Нил";
            r1.area = 3400000;
            r1.length = 6650;
            r1.Print();
            River r2 = new River("Амазонка", 7050000, 6400);
            r2.Print();
            Console.ReadLine();
        }
    }
}
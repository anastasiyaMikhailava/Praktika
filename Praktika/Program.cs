using System;

namespace Reka
{
    class River
    {
        public string name;
        public double basinArea;
        public double length;
        public River()
        {
            name = "";
            basinArea = 0;
            length = 0;
        }
        public River(string name, double basinArea, double length)
        {
            this.name = name;
            this.basinArea = basinArea;
            this.length = length;
        }
        public void Print()
        {
            Console.WriteLine($"Название: {name}");
            Console.WriteLine($"Площадь бассейна: {basinArea} кв.км.");
            Console.WriteLine($"Протяженность: {length} км.");
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            River r1 = new River();
            r1.name = "Нил";
            r1.basinArea = 3400000;
            r1.length = 6650;
            r1.Print();
            River r2 = new River("Амазонка", 7050000, 6400);
            r2.Print();
            Console.ReadLine();
        }
    }
}
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
            name = "Not specified";
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
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Basin area: {basinArea} km2");
            Console.WriteLine($"Length: {length} km");
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            River r1 = new River();
            r1.name = "Nile";
            r1.basinArea = 3400000;
            r1.length = 6650;
            r1.Print();
            River r2 = new River("Amazon", 7050000, 6400);
            r2.Print();
            Console.ReadLine();
        }
    }
}
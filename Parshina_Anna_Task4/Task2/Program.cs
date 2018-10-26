using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task2
{
    class Round
    {
        public double X { get; set; }
        public double Y { get; set; }
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Радиус не может быть отрицательным");
                }
                else radius = value;
            }
        }

        public Round(double x, double y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public double Length()
        {
            return 2 * Math.PI * radius;
        }

        public double Square()
        {
            return Math.PI * radius * radius;
        }


    };

    class Program
    {
        static bool Chack(string str)
        {
            string pattern = @"(\d)+(.\d)*";
            Regex value = new Regex(pattern);
            if (value.IsMatch(str)) return true;
            return false;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                double x = 0, y = 0, R = 0;
                Console.WriteLine("Введите X: ");
                string input = Console.ReadLine();
                if (Chack(input)) x = double.Parse(input);
                Console.WriteLine("Введите Y: ");
                input = Console.ReadLine();
                if (Chack(input)) y = double.Parse(input);
                Console.WriteLine("Введите радиус: ");
                input = Console.ReadLine();
                if (Chack(input)) R = double.Parse(input);
                Round round = new Round(x, y, R);
                Console.WriteLine("Длина окружности = " + round.Length());
                Console.WriteLine("Площадь окружности = " + round.Square());
                ConsoleKeyInfo end = new ConsoleKeyInfo();
                Console.WriteLine("Для выхода нажмите Esc...");
                end = Console.ReadKey();
                if (end.Key == ConsoleKey.Escape)
                    break;
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task6
{
    class Program
    {
        static void ChackValue(string values)
        {
            string pattern1 = @"(\d|-)+(.\d)*";
            string pattern2 = @"(\d|.)+e(\d|-)+";
            string pattern3 = @"[^e,0-9,.,-]+";
            Regex value1 = new Regex(pattern1);
            Regex value2 = new Regex(pattern2);
            Regex value3 = new Regex(pattern3);
            if (value2.IsMatch(values))
            {
                Console.WriteLine("Это число в научной нотации");
                return;
            }
            if (value1.IsMatch(values))
            {
                Console.WriteLine("Это число в обычной нотации");
                return;
            }
            if (value3.IsMatch(values))
            {
                Console.WriteLine("Это не число");
                return;
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите число:");
                string str = Console.ReadLine();
                ChackValue(str);
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

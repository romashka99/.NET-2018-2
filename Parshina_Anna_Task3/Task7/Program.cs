using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task7
{
    class Program
    {
        static int Amount(string str)
        {
            string pattern1 = @"([1-9]|[1][0-9]|[2][0-3])[:]([0-5][0-9])";
            Regex time = new Regex(pattern1);
            return time.Matches(str).Count;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите текст:");
                string str = Console.ReadLine();
                Console.WriteLine("Время в тексте присутствует " + Amount(str) + " раз");
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

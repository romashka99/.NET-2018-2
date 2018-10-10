using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task5
{
    class Program
    {
        static string Change(ref string str)
        {
            string pattern1 = @"<[^>]+>";
            Regex tag = new Regex(pattern1);
            str = tag.Replace(str, "_");
            return str;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите HTML текст:");
                string str = Console.ReadLine();
                Console.WriteLine("Результат замены:" + Change(ref str));
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

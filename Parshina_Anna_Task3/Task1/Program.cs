using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static bool Chack(string str)
        {
            if (str != String.Empty)
                return true;
            return false;
        }
        static int AverageLength(ref string[] words)
        {
            int length = 0;
            int n = 0;
            for (uint i = 0; i < words.Length; i++)
            {
                if (words[i] != String.Empty)
                {
                    n++;
                    length = length + words[i].Length;
                }  
            }
            return length / n;
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Введите строку:");
                string userstr = Console.ReadLine();
                if (Chack(userstr))
                {
                    string[] words = userstr.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
                    Console.WriteLine("Средняя длина слова во введенной строке = " + AverageLength(ref words));
                    ConsoleKeyInfo end = new ConsoleKeyInfo();
                    Console.WriteLine("Для выхода нажмите Esc...");
                    end = Console.ReadKey();
                    if (end.Key == ConsoleKey.Escape)
                        break;
                    Console.WriteLine();
                }
                Console.WriteLine("Некорректный ввод. Повторите попытку.");
            }
        }
    }
}

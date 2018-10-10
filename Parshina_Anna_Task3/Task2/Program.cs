using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static bool Chack(string str)
        {
            if (str != String.Empty)
                return true;
            return false;
        }

        static bool Affiliation(char symbol, string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == symbol)
                {
                    return true;
                }
            }
            return false;
        }

        static string ResultStr(string str1, string str2)
        {
            string str = String.Empty;
            for (int i = 0; i < str1.Length; i++)
            {
                if (Affiliation(str1[i], str2))
                {
                    str = str + str1[i] + str1[i];
                }
                else
                {
                    str += str1[i];
                }
            }
            return str;
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Введите первую строку:");
                string firststr = Console.ReadLine();
                Console.WriteLine("Введите вторую строку:");
                string secondstr = Console.ReadLine();
                if (Chack(firststr) & Chack(secondstr))
                {
                    Console.WriteLine("Результирующая строка:" + ResultStr(firststr, secondstr));
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

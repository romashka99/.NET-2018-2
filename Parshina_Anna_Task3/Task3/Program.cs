using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace Task3
{
    class Program
    {
        static void Table(string culture1, string culture2)
        {
            DateTime dt = new DateTime(2018, 10, 10, 13, 25, 15);
            double value = 2.05;
            int number = 12349565;
            decimal money = 20;
            Console.Write("\t" + culture1 + "\t" + culture2);
            Console.WriteLine();
            Console.Write("{0}\t{1}\t{2}", "Формат отображения даты и времени:", dt.ToString("N", new CultureInfo(culture1)), dt.ToString("N", new CultureInfo(culture2)));
            Console.WriteLine();
            Console.Write("{0}\t{1}\t{2}", "Разделитель дробной и целой части:", value.ToString("N", new CultureInfo(culture1)), value.ToString("N", new CultureInfo(culture2)));
            Console.WriteLine();
            Console.Write("{0}\t{1}\t{2}", "Разделитель групп разрядов:", number.ToString("N", new CultureInfo(culture1)), number.ToString("N", new CultureInfo(culture2)));
            Console.WriteLine();
            Console.Write("{0}\t{1}\t{2}", "Формат отображения денежных средств:", money.ToString("N", new CultureInfo(culture1)), money.ToString("N", new CultureInfo(culture2)));
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите культуру:");
                string culture1 = Console.ReadLine();
                string culture2 = Console.ReadLine();
                Table(culture1, culture2);
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

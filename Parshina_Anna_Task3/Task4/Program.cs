using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Task4
{
    class Program
    {
        static void Comp(int n)
        {
            string str = String.Empty;
            StringBuilder sb = new StringBuilder();
            DateTime one = DateTime.Now;
            Thread.Sleep(3000);
            for (int i = 0; i < n; i++)
            {
                str += "*";
            }
            DateTime two = DateTime.Now;
            TimeSpan result = two - one;
            Console.WriteLine("Результирующее время класса String для операции сложения = " + result);
            one = DateTime.Now;
            Thread.Sleep(3000);
            for (int i = 0; i < n; i++)
            {
                sb.Append("*");
            }
            two = DateTime.Now;
            result = two - one;
            Console.WriteLine("Результирующее время класса StringBuilder для операции сложения = " + result);
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Введите N:");
                int N = int.Parse(Console.ReadLine());
                Comp(N);
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

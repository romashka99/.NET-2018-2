using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkMass;

namespace Task3
{
    class Program
    {
        static int Sum(int[] elements, int n)
        {
            int Sum = 0;
            for (uint i = 0; i < n; i++)
            {
                if (elements[i] >= 0) Sum = Sum + elements[i];
            }
            return Sum;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo end = new ConsoleKeyInfo();
            while (true)
            {
                Console.WriteLine("Введите число элементов массива:");
                string count = Console.ReadLine();
                if (Mass.Check(count))
                {
                    int n = Convert.ToInt16(count);
                    int[] mass = new int[n];
                    int SumElements = 0;
                    Console.WriteLine("Введите значение элементов массива:");
                    Mass.ShapeInput(ref mass, n);
                    SumElements = Sum(mass, n);
                    Console.WriteLine("Сумма неотрицательных элементов одномерного массива = " + SumElements);
                    Console.WriteLine("Для выхода нажмите Esc...");
                    end = Console.ReadKey();
                    if (end.Key == ConsoleKey.Escape)
                        break;
                    Console.WriteLine();
                }
                else Console.WriteLine("Некорректный ввод. Значениe n не должно быть отрицательными или пустым. Повторите попытку.");
            }
        }
    }
}

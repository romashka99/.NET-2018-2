using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkMass;

namespace Task4
{
    class Program
    {

        static int SumMass(int[][] elements, int n, int m)
        {
            int Sum = 0;
            for (uint i = 0; i < n; i++)
            {
                for (uint j = 0; j < m; j++)
                {
                    if ((i + j) % 2 == 0) Sum = Sum + elements[i][j];
                }
            }
            return Sum;
        }


        static void Main(string[] args)
        {
            ConsoleKeyInfo end = new ConsoleKeyInfo();
            while (true)
            {
                Console.WriteLine("Введите число элементов массива:");
                string countN = Console.ReadLine();
                string countM = Console.ReadLine();
                if (Mass.Check(countN) & Mass.Check(countM))
                {
                    int n = Convert.ToInt16(countN);
                    int m = Convert.ToInt16(countM);
                    int[][] mass = new int[n][];
                    int SumElements = 0;
                    Console.WriteLine("Введите элементы массива:");
                    for (uint i = 0; i < n; i++)
                    {
                        Console.WriteLine("i = " + (i + 1));
                        mass[i] = new int[m];
                        Mass.ShapeInput(ref mass[i], m);
                    }
                    SumElements = SumMass(mass, n, m);
                    Console.WriteLine("Сумма элементов, стоящих на четных позициях массива = " + SumElements);
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

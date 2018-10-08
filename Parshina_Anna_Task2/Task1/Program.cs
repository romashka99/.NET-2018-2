using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkMass;

namespace Task1
{
    class Program
    {
        static int Max(int[] mass, int n)
        {
            int max = mass[0];
            int maxIndex = 0;
            for(int i = 0; i < n; i++)
                if (max < mass[i])
                {
                    max = mass[i];
                    maxIndex = i;
                }
            return max;
        }

        static int Min(int[] mass, int n)
        {
            int min = mass[0];
            int minIndex = 0;
            for (int i = 0; i < n; i++)
                if (min > mass[i])
                {
                    min = mass[i];
                    minIndex = i;
                }
            return min;
        }

        static void Sort(ref int[] mass, int n)
        {
            int temp;
            for(int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (mass[i] > mass[j])
                    {
                        temp = mass[i];
                        mass[i] = mass[j];
                        mass[j] = temp;
                    }
        }

        static void Main(string[] args)
        {
            int n = 10;
            while(true)
            {
                int[] mass = new int[n];
                Mass.ShapeRandom(ref mass, n);
                Console.WriteLine("Массив из " + n + " элементов:");
                Mass.Print(mass, n);
                Console.WriteLine("Максимальный элемент = " + Max(mass,n));
                Console.WriteLine("Максимальный элемент = " + Min(mass, n));
                Sort(ref mass, n);
                Console.WriteLine("Отсортированный массив:");
                Mass.Print(mass, n);
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

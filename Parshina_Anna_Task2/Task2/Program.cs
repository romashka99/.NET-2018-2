using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkMass;

namespace Task2
{
    class Program
    {

        static void ShapeMass(ref int[,,] elements, int n, int m,int k)
        {
            Console.WriteLine("Введите элементы массива:");
            for (uint i = 0; i < n; i++)
            {
                for(uint j = 0; j < m; j++)
                {
                    for (uint z = 0; z < k; z++)
                    {
                        Console.Write("Mass[" + (i + 1) + "," + (j + 1) + "," + (z + 1) + "]= ");
                        elements[i,j,z] = int.Parse(Console.ReadLine());
                    }
                }
            }
        }

        static void ChangeMass(ref int[,,] elements, int n, int m, int k)
        {
            for (uint i = 0; i < n; i++)
            {
                for (uint j = 0; j < m; j++)
                {
                    for (uint z = 0; z < k; z++)
                    {
                        if (elements[i,j,z] > 0) elements[i,j,z] = 0;
                    }
                }
            }
        }

        static void PrintMass(int[,,] elements, int n, int m, int k)
        {
            Console.WriteLine("Измененный массив:");
            for (uint i = 0; i < n; i++)
            {
                for (uint j = 0; j < m; j++)
                {
                    for (uint z = 0; z < k; z++)
                    {
                        Console.WriteLine("Mass[" + (i + 1) + "," + (j + 1) + "," + (z + 1) + "]= " + elements[i,j,z]);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            ConsoleKeyInfo end = new ConsoleKeyInfo();
            while (true)
            {
                Console.WriteLine("Введите число элементов массива:");
                string countN = Console.ReadLine();
                string countM = Console.ReadLine();
                string countK = Console.ReadLine();
                if (Mass.Check(countN) & Mass.Check(countM) & Mass.Check(countK))
                {
                    int n = Convert.ToInt16(countN);
                    int m = Convert.ToInt16(countM);
                    int k = Convert.ToInt16(countK);
                    int[,,] mass = new int[n,m,k];
                    ShapeMass(ref mass, n, m, k);
                    ChangeMass(ref mass, n, m, k);
                    PrintMass(mass, n, m, k);
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

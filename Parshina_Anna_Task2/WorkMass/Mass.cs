using System;

namespace WorkMass
{
    
    public class Mass
    {
        public static bool Check(string values)
        {
            if (values == string.Empty)
            {
                Console.WriteLine("Некорректный ввод. Повторите попытку.");
                return false;
            }
            for (int i = 0; i < values.Length; i++)
            {
                if (!Char.IsNumber(values[i]))
                {
                    Console.WriteLine("Некорректный ввод. Значениe N не должны быть отрицательными. Повторите попытку.");
                    return false;
                }
            }
            return true;
        }

        static Random rn = new Random();
        public static void ShapeRandom(ref int[] mass, int n)
        {
            for (uint i = 0; i < n; i++)
                mass[i] = rn.Next(-100, 100);
        }

        public static void ShapeInput(ref int[] mass, int n)
        {
            for (uint i = 0; i < n; i++)
            {
                Console.Write("Mass [" + (i + 1) + "] = ");
                mass[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void Change(ref int[] elements, int n)
        {
            for (uint i = 0; i < n; i++)
                if (elements[i] > 0) elements[i] = 0;
        }

        public static void Print(int[] mass, int n)
        {
            for (uint i = 0; i < n; i++)
            {
                Console.Write(String.Format("{0,4}", mass[i]));
            }
            Console.WriteLine();
        }

    }
}

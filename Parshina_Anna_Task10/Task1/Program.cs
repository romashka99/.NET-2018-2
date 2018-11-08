using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Function.Factorial(5));
            Console.WriteLine(Function.Exponentiation(5,2));
            Console.WriteLine(Function.Exponentiation(5.1, 2));
        }
    }
}

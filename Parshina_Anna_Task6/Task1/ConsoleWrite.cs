using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class ConsoleWrite : IPrinter
    {
        public void Print(double x, double y, string figure)
        {
            Console.Write(figure + $"{x}, {y}");
        }
    }
}

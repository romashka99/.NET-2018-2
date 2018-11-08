using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        static string IntChangeToSquare(string namber)
        {
            int n = int.Parse(namber);
            n *= n;
            return n.ToString();
        }

        static string DoubleChangeToSquare(string namber)
        {
            double n = double.Parse(namber);
            n *= n;
            return n.ToString();
        }

        static string Replace(string text)
        {
            string intPattern = @"(^|\r|\n(?<=\s))(-|)[0-9]*((?=\s)|$|\r|\n)";
            Regex intNumber = new Regex(intPattern);
            string doublePattern = @"(^|\r|\n(?<=\s))(-|)[0-9]*(,)[0-9]*((?=\s)|$|\r|\n)";
            Regex doubleNumber = new Regex(doublePattern);
            text = intNumber.Replace(text, String.Empty);
            text = doubleNumber.Replace(text, String.Empty);
            return text;
        }
        static void Main(string[] args)
        {
            string NameFile = "C:\\Users\\пы\\source\\repos\\Parshina_Anna_Task11\\Task1\\disposable_task_file.txt";
            string text = File.ReadAllText(NameFile);
            Console.WriteLine(Replace(text));
        }
    }
}

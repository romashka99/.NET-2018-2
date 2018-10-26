
using System.Linq;
using System.Text;
using System;
using System.Threading;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Office office = new Office();
            DateTime time = new DateTime(2018,9,20,15,0,0);
            office.CameEmployee("Олег",time);
            office.CameEmployee("Вася", time);
            office.CameEmployee("Юля", time);
            office.CameEmployee("Жора", time);
            office.BackEmployee("Вася");
            office.BackEmployee("Юля");
            Console.ReadKey();
        }
    }
}

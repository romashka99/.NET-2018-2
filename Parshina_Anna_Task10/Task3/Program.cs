using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            Random random = new Random();
            List<TwoDPointWithHash> listPoint = new List<TwoDPointWithHash>();
            List<int> listHashCode = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                x = random.Next(100);
                y = random.Next(100);
                listPoint.Add(new TwoDPointWithHash(x, y));
                listHashCode.Add(listPoint[i].GetHashCode());
            }
            var distinctItems = listPoint.GroupBy(c => new { c.x, c.y }).Select(c => c.First()).ToList();
            var distinctHashCode = listHashCode.GroupBy(a => a).Select(b => b.First()).ToList();
            Console.WriteLine("Количество точек {0} и количество уникальных хэш-кодов {1}", distinctItems.Count, distinctHashCode.Count);
        }
    }
}

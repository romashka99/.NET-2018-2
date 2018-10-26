using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Task3
{
    class Program
    {
        public delegate bool Filter(string i, string j);

        public delegate void Message();

        static public event Message Stop;

        static bool Condition(string i, string j)
        {
            if (i.Length > j.Length)
            {
                return true;
            }
            if (String.Compare(i, j) < 0)
            {
                return true;
            }
            return false;
        }

        static public void Swap(ref string[] array, int i)
        {
            string temp;
            temp = array[i];
            array[i] = array[i - 1];
            array[i - 1] = temp;
        }

        static public void Sort(ref string[] array, Filter filter)
        {

            int Left, Right, i;
            Left = 0;
            Right = array.Length - 1;
            while (Left <= Right)
            {
                for (i = Right; i >= Left; i--)
                    if (filter(array[i - 1], array[i])) Swap(ref array, i);
                Left++;
                for (i = Left; i <= Right; i++)
                    if (filter(array[i - 1], array[i])) Swap(ref array, i);
                Right--;
            }
            Stop();
        }

        static public void onSort()
        {
            Thread tArray = Thread.CurrentThread;
            tArray.Start();
            Stop += tArray.Suspend;
            string[] array = new string[] { "dhughdug", "sgrgr", "dsvvwe", "hbvkhv" };
            Sort(ref array, Condition);
            Console.WriteLine("Сортировка окончена, поток приостовлен");
        }

        static void Main(string[] args)
        {
            Thread thread = Thread.CurrentThread;
            thread.Start();
            onSort();
            Console.WriteLine("Осовной поток");
        }
    }
}

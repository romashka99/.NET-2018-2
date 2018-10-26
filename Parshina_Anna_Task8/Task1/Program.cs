using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {

        public delegate bool IntFilter(int i);

        static public void RemoveEachSecondItem(ref IHuman list, IntFilter filter)
        {
            while(list.Length() == 1)
            {
                for (int i = 1; i <= list.Length(); i++)
                {
                    if (filter(i))
                    {
                        list.Remove(i);
                    }
                }
            } 
        }

        static public void Print(IHuman list)
        {
            for(int i = 0; i < list.Length; i++)
                Console.WriteLine(list[i]);
        }

        static void Main(string[] args)
        {
            IHuman List = new HumanList(13);
            RemoveEachSecondItem(ref List, i => (i & 2) == 0);
            
        }
    }
}

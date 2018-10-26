using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Task1
{
    public class HumanList : IHuman
    {
        public List<int> human;

        HumanList(int n)
        {
            human = new List<int>(n);
            for (int i = 1; i <= n; i++)
            {
                human.Add(i);
            }
        }

        public void Remove(int item)
        {
            human.Remove(item);
        }

        public int Length()
        {
            return human.Count;
        }

    }
}

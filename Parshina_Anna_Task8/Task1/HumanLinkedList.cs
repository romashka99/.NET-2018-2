using System.Collections.Generic;

namespace Task1
{

    public class HumanLinkedList : IHuman
        {
            public LinkedList<int> human;
            HumanLinkedList(int N)
            {
                human = new LinkedList<int>() { };
                for (int i = 1; i <= N; i++)
                {
                    human.AddLast(i);
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

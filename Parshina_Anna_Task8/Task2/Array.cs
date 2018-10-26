using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class DynamicArray<T>
    {
        class MyArray : IEnumerable
        {
            T[] array;
            public IEnumerator GetEnumerator()
            {
                return array.GetEnumerator();
            }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class DynamicArray<T>
    {
        T[] array;

        private int length;
        public int Length
        {
            get
            {
                return length;
            }
            private set
            {
                if (value < 0)
                {
                    throw new Exception("length не может быть отрицательным");
                }
                else length = value;
            }
        }

        public int Capacity
        {
            get
            {
                return array.Length;
            }

        }

        public T this[int index]
        {
            get
            {
                if (index > Capacity)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else return array[index];
            }
        }

        public DynamicArray()
        {
            T[] array = new T[8];
            Length = 0;
        }

        public DynamicArray(int n)
        {
            T[] array = new T[n];
            Length = 0;
        }

        public DynamicArray(T[] ar)
        {
            Length = ar.Length;
            array = ar;
        }

        public DynamicArray(IEnumerable<T> ar)
        {
            Length = ar.Count();
            foreach (T item in ar)
            {
                Add(item);
            }
        }

        public void Add(T item)
        {
            Insert(item, Length + 1);
        }

        public void AddRange(T[] ar)
        {
            Array.Resize(ref array, ar.Length);
            for (int i = 0; i < ar.Length; i++)
                Add(ar[i]);
        }

        public bool Remove(T item)
        {
            bool status = false;
            for (int i = 0; i < Length; i++)
            {
                if (item.Equals(array[i]))
                {
                    for (int j = i; j < Length; j++)
                    {
                        T temp = array[j + 1];
                        array[j] = temp;
                    }
                    Length -= 1;
                    status = true;
                }
            }
            return status;
        }

        public void Insert(T item, int i)
        {
            if (i > Capacity)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                if (Length == Capacity)
                {
                    Array.Resize(ref array, Capacity);
                }
                T temp = array[i];
                array[i] = item;
                T jtemp;
                for (int j = i + 1; j <= Length; j++)
                {
                    jtemp = array[j];
                    array[j] = temp;
                    temp = array[j + 1];
                }
                Length += 1;
            }
        }
    }

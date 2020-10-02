using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {


        public int count;
        public int capacity;

        private T[] items;


        public CustomList()
        {
            count = 0;
            capacity = 4;

            items = new T[capacity];
        }
        public T this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }

        public void Add(T value)
        {
            if (count == capacity)
            {
                capacity *= 2;
                T[] newArray = new T[capacity];
                for (int i = 0; i < items.Length; i++)
                {
                    newArray[i] = items[i];
                }
                items = newArray;

            }

            items[count] = value;
            count++;

        }
        public bool Remove(T value)
        {
            T[] temporaryArray = new T[items.Length];
            bool output = true;  

            for (int i = 0, b = 0; i < items.Length; i++, b++)
            {
                temporaryArray[b] = items[i];

                if (items[i].Equals(value))
                {

                    items[i] = items[i + 1]; 
                }
                else
                {
                    temporaryArray[b] = items[i];
                }
            }
            items = temporaryArray; 
            count--;
            return output; 

        }

    }
}
    
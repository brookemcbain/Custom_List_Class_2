using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace CustomList
{
    public class CustomList<T>
    {


        public int count;
        public int capacity;
        public string result;

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
        public string ToString(T value)
        {
            return base.ToString() + " " + value.ToString();
        }

        public static CustomList<T> operator +(CustomList<T> a, CustomList<T> b)
        {
            CustomList<T> newList = new CustomList<T>();
            newList = a + b;
            return newList;

        }
        public static CustomList<T> operator -(CustomList<T> a, CustomList<T> b)
        {
            CustomList<T> newList = new CustomList<T>();
            newList = a - b;
            return newList;
        }

    }
}
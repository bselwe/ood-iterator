using Game;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.CustomCollections
{
    class ReversedArrayList<T> : ICustomCollection<T>
    {
        private T[] values;
        private int length = 0;

        public ReversedArrayList()
        {
            this.values = new T[10];
        }

        public int Size
        {
            get
            {
                return length;
            }
        }

        public void Add(T value)
        {
            values[length] = value;
            if (++length == values.Length)
            {
                T[] newValues = new T[values.Length * 2];
                Array.Copy(values, 0, newValues, 0, values.Length);
                values = newValues;
            }
        }

        public T Get(int n)
        {
            if (n < 0)
            {
                // throw new Exception here
            }

            return values[length - n - 1];
        }
    }
}

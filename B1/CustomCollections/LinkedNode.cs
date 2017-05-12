using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.CustomCollections
{
    class LinkedNode<T>
    {
        private readonly T _value;

        internal LinkedNode<T> Prev { get; set; }
        internal LinkedNode<T> Next { get; set; }

        internal T Value { get { return _value; } }

        internal LinkedNode(T value)
        {
            this._value = value;
        }
    }
}

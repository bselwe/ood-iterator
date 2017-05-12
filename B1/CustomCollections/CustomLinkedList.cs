using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.CustomCollections
{
    class CustomLinkedList<T> : ICustomCollection<T>
    {
        private LinkedNode<T> head;
        private LinkedNode<T> tail;
        private int length = 0;
        
        private LinkedNode<T> it;
        private int index = 0;

        public void Add(T value)
        {
            LinkedNode<T> newNode = new LinkedNode<T>(value);
            if (head == null)
            {
                head = newNode;
                tail = head;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
            length++;
        }

        public T Get(int n)
        {
            if (n < 0 || n > length)
                throw new IndexOutOfRangeException();

            if (it == null)
                it = head;

            while (index != n)
            {
                if (n < index)
                {
                    it = it.Prev;
                    index--;
                }
                else
                {
                    it = it.Next;
                    index++;
                }
            }

            return it.Value;
        }

        public int Size
        {
            get
            {
                return length;
            }
        }
    }
}

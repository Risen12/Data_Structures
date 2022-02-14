using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Model
{
    public class ArrayQueue<T>
    {
        public T[] Items { get; set; }
        public int Count => Items.Length;

        public T Head { get; set; }
        public T Tail => Items[0];

        public int current { get; set; }
        public ArrayQueue(int length = 10)
        {
            Items = new T[length];
            current = 0;
        }

        public ArrayQueue(T data, int length = 10)
        {
            Items = new T[length];
            Items[current] = data;
            current++;
            Head = Items[current - 1];
        }

        public void Enqueue(T data)
        {
            if (current == 0)
            {
                Items[current] = data;
                current++;
                Head = Items[current - 1];
                return;
            }
            if (Items[0].Equals(default(T)))
            {
                Items[0] = data;
                return;
            }
            var index = current;
            while (index != 0)
            {
                Items[index] = Items[index - 1];
                Items[index - 1] = data;
                index--;
            }
            if (current + 1 >= Count)
                return;
            else
                current++;

        }

        public T Decqueue()
        {
            if (Head == null)
                throw new NullReferenceException("Array is empty");
            var Head_index = Array.IndexOf(Items, Head);
            var item = Head;
            Head = Items[Head_index - 1];
            var index = current - 1;
            while (index != 0)
            {
                Items[index] = Items[index - 1];
                if (index - 2 >= 0)
                {
                    Items[index - 1] = Items[index - 2];
                }
                else
                {
                    Items[index - 1] = default(T);
                }
                index--;
            }
            current--;
            return item;
        }

        public T Peek()
        {
            return Head;
        }

    }
}

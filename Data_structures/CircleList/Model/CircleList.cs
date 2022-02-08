using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleList.Model
{
    public class CircleList<T>
    {
        public int Count { get; private set; }
        public Item<T> Head { get; set; }

        public Item<T> Tail { get; set; }


        public CircleList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public CircleList(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public void Add(T data)
        {
            var item = new Item<T>(data);
            if (Tail != null)
            {
                Tail.Next = item;
                Tail = item;
                Tail.Next = Head;
                Count++;
            }
            else
            {
                Head = item;
                Tail = item;
                Count = 1;
            }
        }

        public void Remove(T data)
        {
            if (Head != null)
            {

                if (Head.Data.Equals(data))
                {
                    Tail.Next = Head.Next;
                    Head = Head.Next;
                    Count--;
                }
                else
                {
                    var previous = Head;
                    var current = Head.Next;
                    while (!current.Data.Equals(data))
                    {
                        previous = current;
                        current = current.Next;
                    }
                    if (current == Tail)
                        Tail = previous;
                    previous.Next = current.Next;
                    Count--;
                }
            }
            else
            {
                throw new NullReferenceException("List is empty");
            }
        }
    }
}

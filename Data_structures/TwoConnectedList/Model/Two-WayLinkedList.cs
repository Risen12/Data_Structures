using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoConnectedList.Model
{
    public class Two_WayLinkedList<T>
    {
        public Item<T> Head { get; private set; }
        public Item<T> Tail { get; private set; }
        public int Count { get; set; }

        public Two_WayLinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public Two_WayLinkedList(T data)
        {
            Head.Data = data;
            Tail = null;
            Tail.Previous = Head;
            Count = 1;
        }

        public void Add(T data)
        { 
            var item = new Item<T>(data);

            if (Tail != null)
            {
                Tail.Next = item;
                Tail.Next.Previous = Tail;
                Tail.Next.Next = null;
                Tail = item;
                Count++;
            }
            else
            {
                Head = item;
                Tail = item;
                Head.Next = Tail;
                Tail.Next = null;
                Tail.Previous = Head;
                Head.Previous = null;
                Count = 1;
            }
        }

        public void Remove(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head.Next.Previous = null;
                    Head = Head.Next;
                    Count--;
                }
                else
                {
                    var current = Head.Next;
                    while (!current.Data.Equals(data))
                    {
                        current = current.Next;
                    }
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    Count--;
                }
            }
            else
            {
                throw new NullReferenceException("Список пуст");
            }
        }

    }
}

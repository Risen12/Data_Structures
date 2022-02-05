using System.Collections;

namespace Data_structures.Model
{
    public class LinkiedList<T> : IEnumerable
    {
        public Item<T> Head { get; private set; }
        public Item<T> Tail { get; private set; }

        public int Count { get; private set; }

        public LinkiedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        public LinkiedList(T data)
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
                    Head = Head.Next;
                    Count--;
                    return;
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
                    previous.Next = current.Next;
                    Count--;
                    return;
                }
            }
            else
            {
                return;
            }
        }

        public void InsertToHead(T data)
        {
            var item = new Item<T>(data);
            item.Next = Head;
            Head = item;
            Count++;
        }

        public void Insert(T target, T data)
        {
            if (Head != null)
            {
                var item = new Item<T>(data);
                if (Head.Data.Equals(target))
                {
                    item.Next = Head.Next;
                    Head.Next = item;
                    Count++;
                    return;
                }
                else
                {
                    var current = Head.Next;
                    var previous = Head;
                    while (!current.Data.Equals(target))
                    {
                        previous = current;
                        current = current.Next;
                    }
                    item.Next = current.Next;
                    current.Next = item;
                    Count++;
                    return;
                }
            }
            else
            {
                var item = new Item<T>(data);
                Head = item;
                Tail = item;
                Count = 1;
                return;
            }
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

    }
}

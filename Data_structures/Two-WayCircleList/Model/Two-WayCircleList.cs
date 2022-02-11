using System.Collections;

namespace Two_WayCircleList
{
    public class Two_WayCircleList<T> : IEnumerable
    {
        public int Count { get; set; }

        public Item<T> Head { get; set; }

        public Item<T> Tail { get; set; }

        public Two_WayCircleList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public Two_WayCircleList(T data)
        {
            SetHead(data);
        }

        public void Add(T data)
        {
            if (Head == null)
            {
                SetHead(data);
                return;
            }

            var item = new Item<T>(data);
            item.Previous = Tail;
            item.Next = Head;
            Tail.Next = item;
            Tail = item;
            Count++;
        }

        public void Remove(T data)
        {
            if (Head == null)
            {
                throw new NullReferenceException("List is empty");
            }

            if (Head.Data.Equals(data))
            {
                Head.Previous.Next = Head.Next;
                Head.Next.Previous = Head.Previous;
                Head = Head.Next;
                Count--;
                return;
            }

            var current = Head.Next;
            while (!current.Data.Equals(data))
            {
                current = current.Next;
            }
            current.Previous.Next = current.Next;
            current.Next.Previous = current.Previous;
            current = current.Next;
            Count--;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            for (int i = Count; i > 0; i--)
            { 
                yield return current;
                current = current.Next;
            }
        }

        private void SetHead(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Tail.Next = Head;
            Head.Previous = Tail;
            Head.Next = Tail;
            Count = 1;
        }
    }
}

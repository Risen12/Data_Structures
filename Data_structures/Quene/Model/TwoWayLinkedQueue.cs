using System.Collections;


namespace Quene.Model
{
    public class TwoWayLinkedQueue<T> : IEnumerable
    {
        public int Count { get; set; }

        public Item<T> Head { get; set; }

        public Item<T> Tail { get; set; }

        public TwoWayLinkedQueue()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        public TwoWayLinkedQueue(T data)
        {
            SetHead(data);
        }

        public void SetHead(T data)
        { 
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Tail.Previous = Head;
            Head.Next = Tail;
            Head.Previous = null;
            Count = 1;
        }

        public void Enqueue(T data)
        {
            if (Head == null)
            {
                SetHead(data);
                return;
            }

            var item = new Item<T>(data);
            item.Previous = Tail;
            Tail.Next = item;
            item.Next = null;
            Tail = item;
            Count++;
        }

        public T Dequeue()
        {
            if (Head == null)
                throw new NullReferenceException("List is empty");
            Head.Next.Previous = null;
            var result = Head;
            Head = Head.Next;
            return result.Data;
            
        }

        public T Peek()
        {
            return Head.Data;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }
    }
}

using System.Collections;

namespace Queue.Model
{
    public class LinkedQueue<T> :IEnumerable
    {
        public LinkedItem<T> Head { get; set; }
        public LinkedItem<T> Tail { get; set; }

        public int Count { get; set; }

        public LinkedQueue() { }

        public LinkedQueue(T data)
        {
            SetHead(data);
        }
        private void SetHead(T data)
        {
            var item = new LinkedItem<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public void Enqueue(T data)
        {
            if (Head == null)
            {
                SetHead((T)data);
                return;
            }

            var item = new LinkedItem<T>(data);
            item.Next = Tail;
            Tail = item;
            Count++;
        }

        public T Decqueue()
        {
            var result = Head.Data;
            if (Count == 1)
            {
                Head = null;
                Tail = null;
                Count--;
                return result;
            }

            var current = Tail.Next;
            var previous = Tail;
            while (current != Head)
            { 
                previous = current;
                current = current.Next;
            }
            previous.Next = null;
            Head = previous;
            Count--;
            return result;
        }

        public T Peek()
        { 
            return Head.Data;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Tail;
            while (current != null)
            { 
                yield return current;
                current = current.Next;
            }
        }
    }
}

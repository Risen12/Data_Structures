using System.Collections;

namespace Queue.Model
{
    public class EasyQueue<T>
    {
        public List<T> items = new List<T>();

        public T Head => items.Last();

        public T Tail => items.First();
        public int Count => items.Count;

        public EasyQueue() { }

        public EasyQueue(T data)
        {
            items.Add(data);
        }

        public void Enqueue(T data)
        {
            items.Insert(0, data);
        }

        public T Dequeue()
        {
            var item = Head;
            items.Remove(item);
            return item;
        }

        public T Peek()
        {
            return Head;
        }

    }
}

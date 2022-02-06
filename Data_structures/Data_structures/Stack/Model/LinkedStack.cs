namespace Stack.Model
{
    public class LinkedStack<T>
    {
        public Item<T> Head { get; set; }

        public int Count { get; set; }

        public LinkedStack()
        {
            Head = null;
            Count = 0;
        }

        public LinkedStack(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Count = 1;
        }

        public void Push(T data)
        {
            if (Head != null)
            {
                var item = new Item<T>(data);
                item.Previous = Head;
                Head = item;
                Count++;
            }
            else
            { 
                Head = new Item<T>(data);
                Count++;
            }
        }

        public T Pop()
        {
            if (Head != null)
            {
                var item = Head;
                Head = Head.Previous;
                Count--;
                return item.Data;
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }

        public T Peek()
        {
            if (Head != null)
            {
                return Head.Data;
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }
    }
}

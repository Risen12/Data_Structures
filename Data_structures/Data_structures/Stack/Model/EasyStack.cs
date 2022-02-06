using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Model
{
    public class EasyStack<T>
    {
        private List<T> Items = new List<T>();
        public int Count  => Items.Count;

        public bool IsEmpty => Items.Count == 0;

        public void Push(T item)
        {
            Items.Add(item);
        }

        public T Pop()
        {
            if (!IsEmpty)
            {
                var item = Items.LastOrDefault();
                Items.Remove(item);
                return item;
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }

        public T Peek()
        {
            if (!IsEmpty)
            {
                return Items.LastOrDefault();
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }

        public override string ToString()
        {
            return $"Stack has a {Count} elements";
        }
    }
}

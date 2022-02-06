using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Model
{
    public class ArrayStack<T>
    {
        T[] items;
        public int Size { get; set; }
        public int current = -1;

        public ArrayStack(int size = 10)
        { 
            items = new T[size];
            Size = size;
        }
        public ArrayStack(T data,int size = 10)
        {
            items = new T[size];
            Size = size;
            current = 0;
            items[current] = data;           
        }

        public void Push(T data)
        {
            if (current > Size)
            {
                throw new StackOverflowException("Stack is full");
            }
            else
            {
                current++;
                items[current] = data;
            }
        }

        public T Pop()
        { 
            var item = items[current];
            current--;
            return item;
        }

        public T Peek()
        {
            if (current > Size)
            {
                throw new StackOverflowException("Stack is full");
            }
            else
            {
                return items[current];
            }
        }
    }
}

using Stack.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EasyStack <int> stack = new EasyStack<int> ();
            stack.Push (1);
            stack.Push (2);
            stack.Push (3);

            Console.WriteLine(stack.Peek());
            var pop_item = stack.Pop ();
            Console.WriteLine (pop_item);
            Console.WriteLine(stack.Peek());
            Console.WriteLine("----------------------------------------------");

            LinkedStack<int> linkedStack = new LinkedStack<int> ();
            linkedStack.Push (1);
            linkedStack.Push (2);
            linkedStack.Push (3);
            linkedStack.Push (4);

            Console.WriteLine(linkedStack.Peek());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Peek());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Peek());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Peek());
            Console.WriteLine("----------------------------------------------");


            ArrayStack<int> arrayStack = new ArrayStack<int>(5);
            arrayStack.Push (1);
            arrayStack.Push (2);
            arrayStack.Push (3);
            arrayStack.Push (4);
            arrayStack.Push (5);


            Console.WriteLine(arrayStack.Peek());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Peek());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Peek());
            Console.ReadLine();




        }
    }
}
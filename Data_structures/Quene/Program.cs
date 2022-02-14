

using Quene.Model;
using Queue.Model;

namespace Queue // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            LinkedQueue<int> linkedQueue = new LinkedQueue<int>();
            linkedQueue.Enqueue(1);
            linkedQueue.Enqueue(2);
            linkedQueue.Enqueue(3);
            linkedQueue.Enqueue(4);
            linkedQueue.Enqueue(5);

            foreach (var item in linkedQueue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine(linkedQueue.Decqueue());
            Console.WriteLine(linkedQueue.Peek());
            Console.WriteLine(linkedQueue.Decqueue());
            Console.WriteLine(linkedQueue.Peek());

            Console.WriteLine();

            foreach (var item in linkedQueue)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();


            // ------------------------------------------

            //Linked Queue 

            var queue = new TwoWayLinkedQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            // ------------------------------------------

            //EasyQueue by List



            var easyqueue = new EasyQueue<int>();
            easyqueue.Enqueue(1);
            easyqueue.Enqueue(2);
            easyqueue.Enqueue(3);
            easyqueue.Enqueue(4);
            easyqueue.Enqueue(5);

            easyqueue.items.ForEach(item => Console.WriteLine(item));

            Console.WriteLine();

            easyqueue.Dequeue();
            easyqueue.Dequeue();
            easyqueue.Dequeue();

            easyqueue.items.ForEach(item => Console.WriteLine(item));




            ArrayQueue<int> Arrayqueue = new ArrayQueue<int>(5);
            Arrayqueue.Enqueue(1);
            Arrayqueue.Enqueue(2);
            Arrayqueue.Enqueue(3);
            Arrayqueue.Enqueue(4);
            Arrayqueue.Enqueue(5);

            for (int i = 0; i < Arrayqueue.Count; i++)
            {
                Console.WriteLine(Arrayqueue.Items[i]);
            }

            Console.WriteLine();

            Console.WriteLine(Arrayqueue.Decqueue());

            Console.WriteLine();

            for (int i = 0; i < Arrayqueue.Count; i++)
            {
                Console.WriteLine(Arrayqueue.Items[i]);
            }

            Console.WriteLine();

            Arrayqueue.Enqueue(1);
            Arrayqueue.Enqueue(7);
            Arrayqueue.Enqueue(3);
            for (int i = 0; i < Arrayqueue.Count; i++)
            {
                Console.WriteLine(Arrayqueue.Items[i]);
            }

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

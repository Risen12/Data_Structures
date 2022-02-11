using System.Collections;
using Two_WayCircleList;

namespace Data_structures
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new Two_WayCircleList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            list.Remove(1);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            list.Remove(3);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            list.Remove(5);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            Console.ReadLine();
        }
    }
}

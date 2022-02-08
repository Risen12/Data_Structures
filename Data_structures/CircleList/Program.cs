using System;
using CircleList.Model;

namespace Data_structures
{
    class Program
    {
        static void Main(string[] args)
        {
            CircleList<int> circleList = new CircleList<int>();
            circleList.Add(10);
            circleList.Add(20);
            circleList.Add(30);
            circleList.Add(40);
            circleList.Add(50);

            circleList.Remove(50);

            Console.ReadLine();

        }
    }
}

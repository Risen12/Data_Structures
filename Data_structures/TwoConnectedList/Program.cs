using TwoConnectedList.Model;
namespace Data_structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Two_WayLinkedList<int> list = new Two_WayLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);


            list.Remove(1);
            list.Remove(3);

            Console.ReadLine();
        }
    }
}

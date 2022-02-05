namespace Data_structures
{
    class Program
    {
        static void Main(string[] args)
        { 
            var list = new Model.LinkiedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            list.Insert(4, 7);

           // foreach (var item in list)
           // {
           //     Console.WriteLine(item);
           // }

           // Console.ReadLine();

           //list.Remove(3);
           // list.Remove(1);
           // list.Remove(8);

            Console.ReadLine();
        }
    }
}
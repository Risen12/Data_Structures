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

            list.Remove(5);

            Console.ReadLine();
        }
    }
}
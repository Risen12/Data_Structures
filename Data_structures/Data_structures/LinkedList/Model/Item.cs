namespace Data_structures.Model
{
    public class Item<T>
    {
        private T data = default(T);
        public T Data
            {
            get { return data; }
            set
            {
                data = value == null ? throw new ArgumentNullException(nameof(value)) : value;
            }
        }

        public Item<T> Next { get; set; }

        public Item(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}

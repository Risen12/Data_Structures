using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleList.Model
{
    public class Item<T>
    {
        public T Data { get; set; }

        public Item<T> Next { get; set; }

        public Item()
        {
            Data = default(T);
        }

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

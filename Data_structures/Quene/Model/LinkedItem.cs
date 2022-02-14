using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Model
{
    public class LinkedItem<T>
    {
        public LinkedItem<T> Next { get; set; }

        public T Data { get; set; }

        public LinkedItem(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}

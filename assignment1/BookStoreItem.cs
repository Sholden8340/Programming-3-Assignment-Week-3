using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    abstract class BookStoreItem
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

        public double TotalPrice => Count * Price;

        public abstract override string ToString();
    }
}
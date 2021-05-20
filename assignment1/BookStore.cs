using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class BookStore
    {
        private List<BookStoreItem> BookStoreItemList = new List<BookStoreItem>();

        public void Add(BookStoreItem b)
        {
            BookStoreItemList.Add(b);
        }

        public void PrintCompleteStock()
        {
            double total = 0;
            foreach (BookStoreItem b in BookStoreItemList)
            {
                Console.WriteLine(b.ToString());
                total += b.TotalPrice;
            }

            Console.WriteLine("\nTotal sales price: {0:##.00}", total);
        }
    }
}
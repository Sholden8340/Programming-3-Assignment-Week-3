using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{

    class Magazine : BookStoreItem
    {

        public string ReleaseDay { get; set; }

        public Magazine(string title, double price, string releaseDay, int count) : base(title, price)
        {
            this.ReleaseDay = releaseDay;
            this.Count = count;
        }

        public override string ToString()
        {
            return $"[Magazine] {this.Title} - release day:{this.ReleaseDay}, {this.Price:##.00} ({this.Count}x)";
        }
    }
}

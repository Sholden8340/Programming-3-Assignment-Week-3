﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{

    class Magazine : BookStoreItem
    {

        public string ReleaseDay { get; set; }

        public Magazine(string title, double price, string releaseDay)
        {
            this.Title = title;
            this.Price = price;
            this.ReleaseDay = releaseDay;
        }

        public override string ToString()
        {
            return $"{this.Title} - release day:{this.ReleaseDay}, {this.Price:##.00}";
        }
    }
}

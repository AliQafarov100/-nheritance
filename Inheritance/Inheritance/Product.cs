using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Product
    {
        public string Price;
        public string ReleaseDate;
        public int Count;

        public Product(string price, string releaseDate, int count)
        {
            Price = price;
            ReleaseDate = releaseDate;
            Count = count;
        }
    }
}

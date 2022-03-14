using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class NewsPaper : Product
    {
        public string Advertisement;
        public string Article;

        public NewsPaper(string advertisement, string article, string price, string releaseDate, int count) : base
            (price, releaseDate, count)
        {
            Advertisement = advertisement;
            Article = article;
        }

        public void Sell()
        {
            int i = 0;
            while (i <= Count)
            {
                if (Count == 0)
                {
                    Console.WriteLine("The product sell failed");
                }
                else if (Count > 0)
                {
                    Count--;
                }
                break;
            }
        }
    }
}

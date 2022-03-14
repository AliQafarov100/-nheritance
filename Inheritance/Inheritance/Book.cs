using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Book : Product
    {
        public string Autor;
        public string Genre;

        public Book(string autor,string genre,string price,string releaseDate,int count = 0) : base(price, releaseDate, count)
        {
            Autor = autor;
            Genre = genre;
        }

        public void Sell()
        {
            int i = 0;
            while(i <= Count)
            {
                if(Count == 0) 
                {
                    Console.WriteLine("The product sell failed");
                }
                else if(Count > 0)
                {
                    Count--;
                }
                break;
            }
        }

    }
}

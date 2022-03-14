using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Book book = new Book("Victor Hugo", "Roman", "20$", "15 March 1862",135);
            book.Sell();
            Console.WriteLine("~~~~~~~~~~~~~~~");
            Console.WriteLine($"Autor: {book.Autor}\nGenre: {book.Genre}Price: {book.Price}\nRelease Date: {book.ReleaseDate}\nCount: {book.Count}");

            Console.WriteLine();

            NewsPaper newsPaper = new NewsPaper("Vacancy announcement", "About IT", "6$", "15 March 3022", 150);
            newsPaper.Sell();
            Console.WriteLine("~~~~~~~~~~~~~~~");
            Console.WriteLine($"Advertisement: {newsPaper.Advertisement}\nArticle: " +
            $"{newsPaper.Article}\nPrice: {newsPaper.Price}\nRelease Date: {newsPaper.ReleaseDate}\nCount: {newsPaper.Count}");
            
        }
    }
}

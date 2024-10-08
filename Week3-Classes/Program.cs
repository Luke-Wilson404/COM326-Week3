using System;

namespace Program
{
    class Book
    {
        string Title;
        string Author;
        string ISBN;
        int NoOfPages;

        void DisplayInfo()
        {
            //Output the book information to the console
            Console.WriteLine("Book Information: ");
            Console.WriteLine("------------------");
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine($"Book Pages: {NoOfPages}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //Create a new instance of the book class
            Book book1 = new Book();

            book1.Title = "C# for Beginners";
            book1.Author = "Bill Gates";
            book1.ISBN = "123748920";
            book1.NoOfPages = 200;

            //Create a new instance of the book class
            Book book2 = new Book();

            book2.Title = "Ultimate C#";
            book2.Author = "Microsoft";
            book2.ISBN = "123748921";
            book2.NoOfPages = 50;

            //Output book information to the console
            book1.DisplayInfo();
            book2.DisplayInfo();

        }
    }
}
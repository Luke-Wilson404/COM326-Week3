using System;
using System.Net.Cache;

namespace Program
{
    class Book
    {
        //Properties
        string Title;
        string Author;
        string ISBN;
        int NoOfPages;

        //Constructor for book object
        public Book(string bookTitle, string bookAuthor, string bookISBN, int bookPages)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
            NoOfPages = bookPages;
        }

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
            Book book1 = new Book("C# for Beginners", "Bill Gates", "122", 200);
            Book book2 = new Book("Visual Studio 2022", "Microsoft", "123", 70);

            //Output book information to the console
            book1.DisplayInfo();
            book2.DisplayInfo();

            Student student1 = new Student();
            Student student2 = new Student();

        }
    }
}
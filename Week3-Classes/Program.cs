class Book
{
    string Title;
    string Author;
    string ISBN;

    static void Main( string[] args)
    {
        //Create a new instance of the book class
        Book book1 = new Book();
        
        book1.Title = "C# for Beginners";
        book1.Author = "Bill Gates";
        book1.ISBN = "123748920";

        //Output the book information to the console
        Console.WriteLine($"Book title: {book1.Title}");
        Console.WriteLine($"Book author: {book1.Author}");
        Console.WriteLine($"Book ISBN: {book1.ISBN}");

        //Create a new instance of the book class
        Book book2 = new Book();

        book2.Title = "Ultimate C#";
        book2.Author = "Microsoft";
        book2.ISBN = "123748921";

        //Output the second book information to the console
        Console.WriteLine($"Book title: {book2.Title}");
        Console.WriteLine($"Book author: {book2.Author}");
        Console.WriteLine($"Book ISBN: {book2.ISBN}");
    }
}
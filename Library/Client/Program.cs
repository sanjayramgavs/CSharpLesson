using LIbrary;

Book book = new Book();
book.OpenBook();
book.Title = "The C# Programming Language";
book.Author = "Anders Hejlsberg";
book.ISBN = "0-7356-1448-2";
book.DatePublished = new DateTime(2003, 8, 1);
book.BookPrice = 49;
book.TotalPages = 1000;
book.BookmarkPage(125);
System.Console.WriteLine(
    $"Book {book.Title} by {book.Author} was published on {book.DatePublished:D}"
);
System.Console.WriteLine($"Current page is {book.GetCurrentPage()}");

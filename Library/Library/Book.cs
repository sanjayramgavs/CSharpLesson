using System.Security.Cryptography;

namespace LIbrary;

public class Book
{
    public string Title = String.Empty;
    public string Author = String.Empty;
    public string ISBN = String.Empty;
    public DateTime DatePublished;
    public int BookPrice;

    public int TotalPages = 100;

    public void OpenBook()
    {
        System.Console.WriteLine("Book is open");

    }
    public void BookmarkPage(int PageNumber)
    {
        System.Console.WriteLine($"Page No. {PageNumber} is bookmarked");

    }
    public int GetCurrentPage()
    {


        return RandomNumberGenerator.GetInt32(TotalPages);
    }



}


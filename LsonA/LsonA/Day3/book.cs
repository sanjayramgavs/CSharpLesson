using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LsonA.Day3
{
    public abstract class Book
    {
       public Book() {
        System.Console.WriteLine("Book Constructor");

       }
       public abstract void OpenBook();
    //    public abstract void OpenBook(){
        
    //    } //if an class has an abstract  then the class must be marked as abstract method
    //abstract method should be overriden by child method 
    // abstract class must be overriden by child class
     
    }
    internal class Ebook:Book{
        public Ebook(){
            System.Console.WriteLine("Ebook Constructor");
        }
        public override void OpenBook()
        {
            System.Console.WriteLine("Ebook is open");
        }
    }
    class Booktester{
        public static void TestOne()
        {
            Book book = new Ebook();
            book.OpenBook();

        }
    }
}
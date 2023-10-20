using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LsonA.Day2
{

    //class which is static cannt be instantiated
    /// <summary>
    /// constructor dont have return type 
    /// Static classes dont have constructors
    /// Static classs can have only static variables
    /// Static class cannt have inheritence, no polymorphism 
    /// static constructor doesnt support Access specifier
    /// Class with private constructor cannot be inheritated
    /// Sealed class cannot be inheritated similar to final
    /// 
    /// </summary>
    public class Constructorr
    {
        public void Open(){
            Console.WriteLine("Book is Open");
        }
         public void Close(){
            Console.WriteLine("Book is Closed");
        }
    }
    public class BookTester{
        public static void BookTesterFun(){
            Constructorr book = new Constructorr();
            book.Open();
            book.Close();
        }
    }
}
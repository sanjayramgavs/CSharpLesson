using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LsonA.Day2
{
    /// <summary>
    /// object consist of  Identifier , state and behavior
    /// Access point is Identifier
    /// identifier of object  is know as reference
    /// object without any identifier known as garbage
    /// Singleton object
    /// </summary>
    internal sealed class Invoice
    {
        private Invoice(){
            System.Console.WriteLine(" Invoice constructor");
        }
    }
    public class Bill
    {
        private Bill(){
            System.Console.WriteLine(" Bill constructor");
        }
        public static Bill CreateBill(){
            return new Bill();
        }
    }
    public class BillTester{
        public static void TestOne(){
           // Bill bill = new Bill(); no obj for private constructor
           Bill bill = Bill.CreateBill();

          
        }
    }
}
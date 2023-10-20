using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Practice.WeekTwoPractice
{
    public class Trycatchwhen
    {
        public static void TryCatchFunc(){
            try
            {
                int a = 10;
                int b = 0;
                int c = a/b;
            }
            catch (Exception e) when (e.Message.Contains("zero"))
            {
                Console.WriteLine("You cannot divide by zero");
            }
           
        }
    }
}
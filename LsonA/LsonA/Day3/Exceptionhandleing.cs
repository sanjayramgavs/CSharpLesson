using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LsonA.Day3
{
    /// <summary>
    /// on runtime error 
    /// appliaction logics
    /// expetion handleing - try catch
    /// Application Exception(buissness logic fails),System Exception (Hardware,software,netwrok error)
    /// System.Exception is the base class for all exceptions in the .NET Framework class library.
    /// System.ApplicationException is a base class for all application-specific exceptions.
    /// Exception Manager - part of VM, 
    /// current load on stack- moniter the stack- catch error and move to safe block,
    /// try is used to moniter code under execution
    /// catch - error is encontered catch block is executed
    /// finally - block used to clean up resources - realease costly blocky resour
    /// single try can have multiple catch block on one finally
    /// try must have atleast one catch or finally block
    /// members  of the catch
    /// members of the exception
    /// 1)Message - error description - only readonly
    /// 2) StackTrace - Normalyy at runtime,list the method call that led to the exception ,gives the error path
    /// 3) TargetSite - actual method that threw the exception
    /// 4) InnerException - exception that caused inside another exception object
    /// 5) source - will return the name of the assembly where the exception is raised
    /// exception not caught by inner try block will be caught by outer try block
    /// 
    /// throw - used to throw exception outside all try catch block
    /// when exception catch from child exception and throw to parent exception,reverse order of exception is maintained
    /// Exception doesnt have any methods
    /// 
    /// try{

     /// 
    /// </summary>
    public class ExceptionHandleing
    {
        public static void DemoException(){
            Console.WriteLine("\tEnter a no for X");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("\tEnter a no Y");
            int y = int.Parse(Console.ReadLine());
            Calculator c1 = new Calculator();
            int z = c1.Divide(x, y);
            Console.WriteLine("Result in M3 " + z);
        }
        public static void TestDivide()
{
     Calculator c1 = null;
     int v1 = 0;
     int v2 = 0;
     int v3 = 0;
     try
     {
        //  Console.WriteLine("Enter a no X");
        //  v1 = int.Parse(Console.ReadLine());
        //  Console.WriteLine("Enter another no Y");
        //  v2 = int.Parse(Console.ReadLine());
         c1 = new Calculator();
         v3 = c1.Divide(0, 0);
         Console.WriteLine("Result of {0}/{1}={2}", v1, v2, v3);
     }
     catch (Exception err)
     {
         Console.WriteLine("Error1 Type " + err.GetType().FullName);
         Console.WriteLine("Error1 Message " + err.Message);
         Console.WriteLine("Error1 SOURCE " + err.Source);
         Console.WriteLine("Error1 TargetSite " + err.TargetSite.Name);
     }
}
        
    }
    class Calculator
{
     public int Divide(int x, int y)
     {
         return x / y;
     }
     public int Add(int x,int y)
     {
         return x + y;
     }
     public int Multiply(int x, int y)
     {
         return x * y;
     }
     public int Subtract(int x, int y)
     {
         return x - y;
     }


     public int DivideA(int x, int y)
     {
         //if (y == 0)
         //    throw new ZeroValueException();
        //  if (y == 0)
        //      throw new ZeroValueException("ERROR!!! Value for Y is " + y);
         return x / y;
     }
     public static void TestCatchFinally()
  {
      Console.WriteLine("Before Try");
      int v1 = 0;
     // return;
      try
      {
          Console.WriteLine("Inside Try");
          Console.WriteLine("Enter a no");
          v1 = int.Parse(Console.ReadLine()); // throw exception at runtime when input is not a number
      }
      catch (Exception err)
      {
          Console.WriteLine("Inside Catch " + err.Message);
      }
       finally // try will always execute ,except when there is a return statement and not enter the try block
      {
          Console.WriteLine("Inside  Finally");
      }
      Console.WriteLine("After  Finally");
  }
}
}
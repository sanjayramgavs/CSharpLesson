using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


/*
pointer to the method is called pointer
data types look like method 
strongly typed functional poiters are called delegates
delegate is the type name to create a delegate
signature of method and delegate should be same

delegates  two types
1. single cast delegate -- deleigate can point to only one method
2. multi cast delegate -- delegate can point to multiple methods

methods have return type not suitable for multi cast delegate
multi cast delegate is suitable for void return type
all events are multi cast delegate
event is a keyword in which raised at the time of action


*/
public delegate void MethodhandlerA(); //parameter less method vois return type
public delegate int MethodhandlerB(int x, int y); // parameterized method with return type int
namespace LsonA.Day6
{
    public class Pointer
    {
        public void Dotask()
        {
            System.Console.WriteLine("I am doing task");
        }
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Multiply(int x, int y)
        {
            return x * y;
        }
        public double Divide(double x, double y)
        {
            return x / y;
        }
        public String GetMode()
        {
            return "X500";
        }

    }
    public class DelegateDemmo
    {
        

        public static void TestOne()
        {
            Pointer pointer = new Pointer();
            MethodhandlerA methodhandlerA = new MethodhandlerA(pointer.Dotask);
            MethodhandlerB methodhandlerB = new MethodhandlerB(pointer.Add);
            MethodhandlerB methodhandlerC = pointer.Multiply; //new MethodhandlerB(pointer.Multiply); // short cut for above line 
            // MethodhandlerB methodhandlerD = new MethodhandlerB(pointer.Divide); // error
            methodhandlerA();
            int result = methodhandlerB(10, 20);
            System.Console.WriteLine(result);
            result = methodhandlerC(10, 20);
            System.Console.WriteLine(result);
    
        }
        public static void Testtwo(){
            Pointer pointer = new Pointer();
            MethodhandlerB methodhandlerB = pointer.Add;
            methodhandlerB += pointer.Multiply;
            methodhandlerB(100,50);
        }
    }

}
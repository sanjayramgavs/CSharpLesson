using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*having variable inside namespace not outside the namespace so, 
on declaring namespace the value should be declared inside the class that is called memeber variable 
or also called as Field
the virtual boundary that is created in the boundary to do execution
name space can have unique class and with 1 or more classes in it to execute

class can be have same name in the class that present on it 
Method that can be declared only inside the class 
Name of the local varaible and global varaible can be same
Static methods cannt access non static methods that is declared in globally 
Similarly we can access the non static variable cannot be accessed in static method

to call an non static method(class.method) is not possible , so we are creating the object to call the 
method in the static funtion to call it
"ClassB demo_obj = new ClassB();

demo_obj.SecondMethod();"
new - it is called factory becoz it is an  create an obj for the class required and loaded on heap
address of the is stored in the name of the object name - it is called as an reference that holds the address 
of the obj


*/
namespace LsonA.Day2 
{

    public class ClassA
    {
        int GlobalVariable = 100; // Global declaration
        static int Var_y= 100;
        public static void FirstMethod(){
            int Local_varible =100; //Local Variable
            Console.WriteLine(Local_varible);
            int Var_y = 105;
            Console.WriteLine(Var_y); //Local Variable
            Console.WriteLine(ClassA.Var_y); //Global Varible

            //on Accessing varaible that is called inside the function is alwasys the local variable
                
        }
    }
    public class ClassB
    {
        static int var_x = 18;
        public void SecondMethod(){  //on non static method can able to access the static and non static varible
            System.Console.WriteLine(var_x);
        }
                         
    }
}

namespace LsonA.hello
{
    public class DemoA
    {
         public static void Printfuntion(){
            System.Console.WriteLine(" print demo A");
        }
    }
}
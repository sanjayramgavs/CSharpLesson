using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
static member of the class can be accessed without the object reference
static 
non static
const
*/
namespace LsonA.Day2
{
    internal class Box
    {
        public static int height= 892;
        public int width = 123;
        public const String type = "Wooden"; //on declaring the constant value should be assigned 
        public const String name = "Kevin"; //when the value is assigned it cant be changed at any time of the program execution
        
        public int GetHeight(){ //an non static method can return the static method variables
            return height;
        }
    }
    internal class TestBox
    {
        public static void TestOne(){
            
            var box= new Box();
            var box2 = new Box();
            Box.height= 10000;
            box.width=789;
            box2.width=8902;
            System.Console.WriteLine($"First box= {box.width} {box.GetHeight()}");  // an accessesin an non static funtion
            System.Console.WriteLine($"Second box ={box2.width},{Box.height}");
            Box.height= 2000;
            System.Console.WriteLine($"First box= {box.width} {box.GetHeight()}");  // an accessesin an non static funtion
            System.Console.WriteLine($"Second box ={box2.width},{Box.height}");
        
        }
    }
}
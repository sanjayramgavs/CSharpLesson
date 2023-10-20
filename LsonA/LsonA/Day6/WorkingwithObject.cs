using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LsonA.Day6
{
    public class WorkingwithObject
    {
        public static void TestOne(){
    Object objectOne=new object();
     Console.WriteLine($"ToString: {objectOne.ToString()}");
     Console.WriteLine($"HashCode: {objectOne.GetHashCode()}");
     Type typeOne = objectOne.GetType();
     Console.WriteLine($"Type: {typeOne.FullName}");

 

     String stringData = "WorldCup 2023";
     Console.WriteLine($"ToString: {stringData.ToString()}");
     Console.WriteLine($"HashCode: {stringData.GetHashCode()}");
     Type typeTwo = stringData.GetType();
     Console.WriteLine($"Type: {typeTwo.FullName}");
        }
    }
}
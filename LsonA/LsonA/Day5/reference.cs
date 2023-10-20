using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace LsonA.Day5
{
    public class reference
    {
        public static void DoTask(int x){
            int i = x+2000;
            x= i;
            System.Console.WriteLine("x = {0}",x);
        }
        public static void DoTask(ref int x){
            int i = x+2000;
            x= i;
            System.Console.WriteLine("x = {0}",x);
        }
    }

    class Printer{
        public static void Print(){
            int v1 =1000;
            System.Console.WriteLine("v1 = {0}",v1); //v1 = 1000
            reference.DoTask(v1); //value of v1 is passed to the method
            System.Console.WriteLine("v1 = {0}",v1); //v1 = 1000
            reference.DoTask(ref v1); //address of x is mentioned as ref, so the value of v1 is changed
            System.Console.WriteLine("v1 = {0}",v1); //v1 = 3000
        }
    }
}
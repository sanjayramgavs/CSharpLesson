using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LsonA.Day3
{
    public class Timechecker
    {
        public static void Checker(){
               int begin = DateTime.Now.Millisecond;
            double x = 100;
             for (int i = 1; i < 1000000; i++)
             {
                i+=1;
            }
     int after = DateTime.Now.Millisecond;
     Console.WriteLine(after - begin);
     Console.WriteLine(x);

        }
        public static void AssignSameStringMultipleTimes()
{
     int begin = DateTime.Now.Millisecond;
     String s1 = "Abcd";
     for (int i = 1; i < 1000000; i++)
     {
        //String s2 ="Hello";
        s1 = "Hello";

     }
     int after = DateTime.Now.Millisecond;
     Console.WriteLine(after - begin);
     Console.WriteLine(s1 + " ms");
}
public static void ModifyStringMultipleTimes()
{
     int begin = DateTime.Now.Millisecond;
     String s1 = "Abcd";
     for (int i = 1; i < 1000000; i++)
     {
         s1 += i;
     }
     int after = DateTime.Now.Millisecond;
     Console.WriteLine(after - begin);
     Console.WriteLine(s1 + " ms");
}
    }
}
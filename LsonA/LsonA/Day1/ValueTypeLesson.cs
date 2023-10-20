using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LsonA.Day1
{
    internal class ValueTypeLesson
    {
        public static void TestValueType()
        {
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);

            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);

            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            float f1 = 45.82f;
            Console.WriteLine(f1);

            long l1 = int.MaxValue + 1000L;
            Console.WriteLine(l1);

            double d1 = 791282123d; //d is used
            Console.WriteLine(d1);

            decimal dec1 = 213.45M;
            Console.WriteLine(dec1);

            char c1 = 'a';
            Console.WriteLine(c1);
            Console.WriteLine(char.MaxValue);
            Console.WriteLine(char.MinValue);

            int x = c1;

            Console.WriteLine(x);

            String s1 = " hello worls";
            Console.WriteLine(s1);

            int x2 = 69;
            char c2 = (char)x2;
            Console.WriteLine(c2);

            bool flag = true;
            Console.WriteLine(flag); //boolean default is 0

            TestMethod();

         
        }
        internal static void TestMethod() //funtion declarion -- static methods -- set of codes execute without objects --- header of the method
        {
            Console.WriteLine("test"); // body of the method 
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LsonA.Day1
{
    internal class calculator
    {
        public static void Calculator()
        {
            Console.WriteLine("enter the number1 : \n");

            float n1 = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the number2 : \n");

            float n2 = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" enter the operation that 1.Add 2.Subtract 3.Multiply 4.Divide");

            int o1 = Convert.ToInt32(Console.ReadLine());

            switch (o1)
            {
                case 1: { Console.WriteLine(calculator.Add(n1, n2)); break; }
                case 2: { Console.WriteLine(calculator.Subtract(n1, n2)); break; }
                case 3: { Console.WriteLine(calculator.Multiply(n1, n2)); break; }
                case 4: { Console.WriteLine(calculator.Divide(n1, n2)); break; }
            }
        }
        public static float Add(float a, float b) {  return a + b; }
        public static float Subtract(float a,float b) {  return a - b; }
        public static float Multiply(float a,float b) { return a * b; }
        public static float Divide(float a,float b) { return a / b; }      
    }
}

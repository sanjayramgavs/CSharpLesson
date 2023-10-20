using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace LsonA.Day7
{
    public class Lambada_Demo
    {
        public static void DemoA(){
            /*
            dynamic funtion
            one int for input and one int for output
            => is the arrow function
            the last type is the return type

            */
        
            Func<int, int> square = x =>  x*2;
            /*
            public int foo(int x){
                return x*2;
            }
            */

            int i =100;
            int result = square(i);
            System.Console.WriteLine(result);


        }
        public static void DemoB(){
            Func<int> foo = () => 100;
            System.Console.WriteLine(foo());
            
        }
        public static void DemoC(){
            Func<float, float, float> foo = (x,y) => x/y;
            System.Console.WriteLine(foo(10.02f,221.08f));
        }
        public static void DemoD(){
            Func<int, int,double> foo = (x,y) => {
                double result = (double)x/(double)y;
                return result;
            };
            System.Console.WriteLine(foo(10,441));
        }
        public static void DemoE(){
            Func<int, int, int> foo = (x,y) => x+y;
            System.Console.WriteLine(foo(10,20));
        }
        static void Echo(Func<String> foo){
            string str = foo();
            System.Console.WriteLine(str);
        }
        public static void TestEcho(){
            Echo(() => "Hello World");
        }
        public static Double DoTrans(Func<int, int,double> foo){
         return foo(100,200);
        }
        public static void TestDoTrans(){
            Func<int,int,double> Multiply = (x,y) => x*y;
            double d = DoTrans(Multiply);
            System.Console.WriteLine(d);
            Func<int,int,double> Divide = (x,y) => {
               if(y==0){
                   return 0;
               }
                return (double)x/y;
            };
            d = DoTrans(Divide);
            System.Console.WriteLine(d);

        }
    }
}
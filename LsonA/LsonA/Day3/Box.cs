using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LsonA.Day3
{
    public class Box
    {
        public int height;
        public int width;
        public int length;
        /// <summary>
        /// parameterize the 
        /// child class expect the parameterized less constructor so it cause error
        /// so we use :base(1)
        /// except the calling parameterized constructor on exceplicity called
        /// child can have extra properties
        /// parent cant access the new childs properties
        /// and what ever belongs to parent can be accesible to child
        /// </summary>
    
        public Box(int x){ //Construcrtor //add parametrized constructore
            System.Console.WriteLine("Box is Created");

        }
        public void Open(){
            System.Console.WriteLine("Box is Opened");

        }
        public void Close(){
            System.Console.WriteLine("Box is Closed");
        }
        public override String ToString(){
            return $"Height:{height},Length:{length},:Width:{width}";
        }
    }
    // End of Box
    internal class WoodenBox : Box
    { //inheritance by : childclass: parenclass
        public int Area;
        public WoodenBox() :base(1) //exceplicity calling parameterize constructor
        {
            System.Console.WriteLine("Woodox box Created");
        }
        public WoodenBox(int x) :base(x) 
        {
            System.Console.WriteLine("Woodox box Created x");
        }
        public WoodenBox(int x, int y): base(x)
        {
            System.Console.WriteLine("Woodox box Created y");
        }
        public void Move(){
            System.Console.WriteLine("Wooden Box Shifted");
        }
         public override String ToString(){
            return "hello child classs";
        }
    }
   // End of WoodenBox
    internal class BoxTester
    {
        public static void TestOne()
        {
            Box box = new Box(3);
            box.height = 123;
            box.width = 345;
            box.width = 781;
            box.Open();
            box.Close();
            String output = box.ToString();
            System.Console.WriteLine(output);
            //box.Area =300;  parent object cant access the childs property


        }
        public static void Testtwo()
        {
            WoodenBox box = new WoodenBox();
            WoodenBox box1 = new WoodenBox(5);
            WoodenBox box2 = new WoodenBox(3,4);

            box.height = 123;
            box.width = 345;
            box.width = 781;
            box.Open();
            box.Close();
            String output = box.ToString();
            System.Console.WriteLine(output);
            box.Move();

        }
         public static void TestThree(){
                Box box = new WoodenBox(); // child can upcast the parent class
                box.height = 123;
                box.width= 345;
                box.width= 781;
                box.Open();
                box.Close();
                String output = box.ToString();
                System.Console.WriteLine(output);
                 
            }
    }
    // End of Tester
}
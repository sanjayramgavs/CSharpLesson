using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LsonA.Day3
{
    public class StringAndStringBuilder
    {
          // string is an class, it is reference type, instace of string is object, array of characters.
     //string data is always in heap,intern pool is a special area in heap, where string data is stored.
     //strings are treated like value type,
     //string alias as String
     // String can set null value,but not for Int
     // String(class) reference = "OBJECT"
     // if the string has two object have same name they will be shared
     // String are immutable , on intern pool, address of the reference will be changed when new value is assigned in String,
     // sharable,less memory,fast

    
    }
    public class StringLesson{
        public static void DemoA(){
            String firstString = "Hello";
            char[] data = {'H','e','l','l','o'};
            String secondString = new String(data);
            Console.WriteLine(firstString+" "+secondString);
            String thirdString = String.Empty;
            // Local variable need to inalized , Global variable will be inalized by default constructor


        }
        public static void DemoB(){
            String s1 ="Tom and Jerry are friends";
            System.Console.WriteLine(s1.Length);
            Char[] data = s1.ToCharArray(); // convert string to char array
            foreach(char c in data){
                System.Console.WriteLine(c);
            }
        }
        // string has method has Split,Substring,Trim,Replace,Contains,IndexOf,
        public static void DemoC(){
            String s1 ="Tom and Jerry are friends";
            String[] data = s1.Split(' '); // convert string to char array split by space
            foreach(string s in data){
                System.Console.WriteLine(s);
            }
            System.Console.WriteLine(data.Count()); // count the number of words
        }
        public static void DemoD(){
            //ToUpper and ToLower method
            String s1 ="Tom and Jerry are friends";
            System.Console.WriteLine(s1.ToUpper()); //
            System.Console.WriteLine(s1);
            System.Console.WriteLine(s1.ToLower()); 
        }
        //Trims in c# in strings
        public static void DemoE(){
            String s1 ="         Tom and Jerry are friends       ";
            System.Console.WriteLine(s1.Trim()); // remove the space from the start and end of the string
            System.Console.WriteLine(s1.TrimStart()); // remove the space from the start of the string
            System.Console.WriteLine(s1.TrimEnd()); // remove the space from the end of the string 
        }
        public static void DemoF(){
            //three strings
            String s1 ="Tom";
            String s2 ="Tom";
            String s3 = "Jerry";

            bool firstResult =(s1==s2); // true
            bool secondResult =(s1==s3); // false
            bool thirdResult = s1.Equals(s2); // true
            bool fourthResult = s1.Equals(s3); // false
            System.Console.WriteLine(firstResult);
            System.Console.WriteLine(secondResult);
            System.Console.WriteLine(thirdResult);
            System.Console.WriteLine(fourthResult);

            String fifthResult = new String(new char[]{ 'T','o','m'}); // string is create in cronstructor and it is not in intern pool
            // string is stored in heap .
            bool sixthResult = s1.Equals(fifthResult); // true
        }
        // substring the string
        public static void DemoG(){
            String s1 ="Tom and Jerry are friends";
            String s2 = s1.Substring(4); // and Jerry are friends //index start from 0
            String s3 = s1.Substring(4,5); // and J
            System.Console.WriteLine(s2);
            System.Console.WriteLine(s3);
        }
        public static void TestCampareTo(){
            String s1 ="Tom";
            String s2 ="Tom";
            String s3 = "Jerry";
            int firstResult = s1.CompareTo(s2); // 0
            int secondResult = s1.CompareTo(s3); // -1
            int thirdResult = s3.CompareTo(s1); // 1
            System.Console.WriteLine(firstResult);
            System.Console.WriteLine(secondResult);
            System.Console.WriteLine(thirdResult);

            //contains
            String s4 ="Tom and Jerry are friends";
            bool firstContains = s4.Contains("Tom"); // true
            //Insert 
            String s5 ="Tom and Jerry are friends";
            String s6 = s5.Insert(4,"is"); // Tom is and Jerry are friends
            //string.reverse
            String s7 ="Tom and Jerry are friends";
            char[] data = s7.ToCharArray();
            Array.Reverse(data);
            String s8 = new String(data);
            //string.replace
            String s9 ="Tom and Jerry are friends";
            String s10 = s9.Replace("Tom","Jerry"); // Jerry and Jerry are friends
            //string.indexof
            
            //bubble sort 

        }
    }
        
    }
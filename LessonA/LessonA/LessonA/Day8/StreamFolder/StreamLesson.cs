﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAConsoleApp.DayEight
{
    internal class StreamLesson
    {
        public static void TestOne()
        {
            char ch;
            Console.WriteLine("Press a key followed by ENTER: ");
            int x = Console.Read();
            ch = (char)x;//get a char
            Console.WriteLine("\n" + x + " Your Key is: " + ch);
        }
        public static void TestTwo()
        {
            char ch=' ';
            Console.WriteLine("Press a key q to exit ");
            while (ch != 'q'){
                ch = (char)Console.Read();//get a char
                Console.WriteLine("Your Key is: " + ch); 
            }
        }
        public static void TestNullableTypes() 
        {
            int? x = 0;
            x = null;
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
                Console.WriteLine(x.GetValueOrDefault());
        }
        public static void TestThree() 
        {
            Console.Out.WriteLine("Enter a sentence");
            string? str = Console.ReadLine();
            Console.Out.WriteLine(str);
        }
    }
}

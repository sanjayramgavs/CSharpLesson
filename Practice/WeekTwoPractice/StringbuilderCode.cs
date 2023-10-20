using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Practice.WeekTwoPractice
{
    public class StringbuilderCode
    {
        internal static void PrintStringBuilder(StringBuilder sb)
        {
            Console.WriteLine(sb.ToString());
        }
        public static void SBFuntion(){
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder("Hello World",50);
            for(int i = 0; i < 5; i++){
                sb.Append(i).Append(" ");
            }
            String result = sb.ToString(); //converts the stringbuilder to a string
            sb.AppendFormat("This is a string {0} and {1}", "Hello", "World");
            PrintStringBuilder(sb);
            sb.Insert(0, "Hello"); //inserts the string at the index
            PrintStringBuilder(sb);
            sb.Remove(0, 5); //removes the string from the index to the length
            PrintStringBuilder(sb);
            sb.Replace("World", "Universe"); //replaces the string with another string
            PrintStringBuilder(sb);
            sb.Clear(); //clears the stringbuilder
        }
    }
}
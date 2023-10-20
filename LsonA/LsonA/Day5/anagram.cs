using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LsonA.Day5
{
    public class anagram
    {
        public static void anagramMethod()
        {
            String str1 = "He was at the 24 floor of the building. He saw 42 pots of flowers there. He stop to check if the pots are watered."; // random anagram text
            str1.Replace(".", " ").ToLower();
            
            String[] strings = str1.Split(" ");
            for (int i = 0; i < strings.Length - 1; i++)
            {
                for (int j = 0; j < strings.Length - i - 1; j++)
                {
                    if (strings[j].Length > strings[j + 1].Length)
                    {
                        string temp = strings[j];
                        strings[j] = strings[j + 1];
                        strings[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < strings.Length - 1; i++)
            {
                char[] a1 = strings[i].ToCharArray();
                char[] a2 = strings[i + 1].ToCharArray();
                
                Array.Sort(a1);
                Array.Sort(a2);
                if (a1.SequenceEqual(a2))
                {
                    System.Console.WriteLine(strings[i] + " " + strings[i + 1]);
                }
            }
        }
    }
}
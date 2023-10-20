using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LsonA.Day1
{
    internal class grapeprob
    {
        public static void dowork()
        {
            for(int i = 1;i<=100;i++)
            {
                if(i%3==0 && i%5 == 0)
                {
                    Console.WriteLine("Grapes");
                }
                else if( i%3==0)
                {
                    Console.WriteLine("Apple");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Orange");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

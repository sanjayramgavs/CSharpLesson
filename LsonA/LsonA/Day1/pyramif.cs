using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LsonA.Day1
{
    internal class pyramif
    {
        public static void pyramid()
        {
            int n = 9;

            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= 1; j--)
                {
                    if (j > i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(j);
                    }
                }
                for (int k = 2; k <=i; k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine("");
            }

        }
    }
}

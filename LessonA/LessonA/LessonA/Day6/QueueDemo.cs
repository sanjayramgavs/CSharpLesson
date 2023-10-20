﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAConsoleApp.DaySix
{
    internal class QueueDemo
    {
        public static void TestQueue()
        {
            Queue q = new Queue();
            Random r = new Random();
            int x = 0;
            q.Enqueue("Deva");
            Console.Write(2590 + " ");
            for (int i = 0; i < 10; i++)
            {
                x = r.Next(100);
                q.Enqueue(x);
                Console.Write(x+"");
            }
            Console.WriteLine("");
            int count = q.Count;
            Console.WriteLine("Count=" + count);
            for (int i = 0; i < count; i++)
            {
                Console.Write(q.Peek() + " ");
                // Peek reads the first object in the queue 
                // without removing the object
                // Peek will read the only the first object in n times
            }
            Console.WriteLine("");
            count = q.Count;
            Console.WriteLine("Count After Peek =" + count);
            Console.WriteLine("Contains 25-" + q.Contains(25));
            for (int i = 0; i < 5; i++)
            {
                Console.Write(q.Dequeue() + " ");
            }
            Console.WriteLine("");
            count = q.Count;
            Console.WriteLine("Count After Dequeue=" + count);
        }
    }
}

using System;

using System.Collections.Generic;

using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;



namespace Frame1.Day7

{

    public class Threads_ServiceA

    {
        int x = 0;

        public void DoTaskA()
        {
            Monitor.Enter(this);

            Thread t1 = Thread.CurrentThread;

            int id = t1.ManagedThreadId;

            System.Console.WriteLine("Inside DoTaskA");

            System.Console.WriteLine("\t Thread ID : " + id);

            try{


            for (int icount = 0; icount <= 5; icount++)
            {

                x += icount;

                System.Console.WriteLine("\tID = " + id + " : X = " + x + " icount = " + icount);

                Thread.Sleep(1000);

            }
            }
            finally{
                Monitor.Exit(this);

            }
        }

        public static void DemoA()

        {

            Thread t = Thread.CurrentThread;

            int id = t.ManagedThreadId;

            System.Console.WriteLine("MainTh ID " + id);

            Threads_ServiceA a1 = new Threads_ServiceA();

            a1.DoTaskA();

        }

        public static void DemoB()

        {

            //Local variables are thread safe by default on their own doesnt overwrite

            //Each thread will get the copy of its own variable

            Thread t = Thread.CurrentThread;


            int id = t.ManagedThreadId;

            System.Console.WriteLine("MainTh ID " + id);

            Threads_ServiceA a1 = new Threads_ServiceA();

            Thread t1 = new Thread(a1.DoTaskA);//delegate

            t1.Start();
            
            a1.DoTaskA();

            System.Console.WriteLine("--------------------End of DemoB----------------------------");

        }
        public static void DemoB2()

        {
            Thread t = Thread.CurrentThread;


            int id = t.ManagedThreadId;

            System.Console.WriteLine("MainTh ID " + id);

            Threads_ServiceA a1 = new Threads_ServiceA();

            Thread t1 = new Thread(a1.DoTaskA);//delegate
            System.Console.WriteLine("Thread state " + t1.ThreadState+"");

            t1.Start();
            System.Console.WriteLine("Thread state " + t1.ThreadState);
            Thread.Sleep(6000);
            System.Console.WriteLine("Thread state " + t1.ThreadState);


       

            System.Console.WriteLine("--------------------End of DemoB----------------------------");

        }
        public static void DemoC()

        {


            Thread t = Thread.CurrentThread;


            int id = t.ManagedThreadId;

            System.Console.WriteLine("MainTh ID " + id);

            Threads_ServiceA a1 = new Threads_ServiceA();

          ThreadStart ts = a1.DoTaskA;
          Thread t1 = new Thread(ts);//delegate
          Thread t2 = new Thread(ts);


            t1.Start();
            t2.Start();

            t1.Join(1000); // the join should happen with particular time
            if(t1.IsAlive)
            {
                t1.Abort();
            }
            t2.Join(7000);
                if(t2.IsAlive)
                {
                    t2.Abort();
                }

            System.Console.WriteLine("--------------------End of DemoB----------------------------");

        }



    }

}
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace LsonA.Day7
{
    /* A thread is an independent path of executable code writing for CPU time
    THreads are the basic unit to which an operating system allocates the process time
    More than one thread can exist within the same process
    OS use  processes to logically separate the resources used by different running programs

    that thread that contain 
    1.Exception Handler
    2.a Scedhuliing priority,and
    3.a set of structures the kernel uses to save the thread context until it is scheduled

    resource alloccate in a process can access the other process.
    single core processor can only run one thread at a time
    scope of thread is limited to the process created
    thread can be created by using two mechanism
    1.using thread class
    2.using thread pool

    jvm load the three thread minimum
    1.main thread
    2.garbage collector thread
    3.jit compiler thread

    each thread get the one copy of own local variable or own stack

    thread run concurrently , the local variable are tread safe by default

    threads share the common global variable
     gloabal variable are not thread safe
     if concurrently global varaibale is accesed the end up overwriting the value

     locking the method will not allow to access the method by other thread

     terminated thread cannot be restarted

     fork a point in the single thread to multiple thread

     start - > Task A -> task B-> end single thread

        start -> task A -> task B -> end
                ->fork -> task c-> end

    two threads thart are forked to divide the task in fork
    join is the point where the thread join the main thread

    threads created by os

    Thread ID is given by os
    prioirity managede by OS

    Thread pirority

    by default all thread has same priority

    Thread Priority is an Enum

    multiple thread run concurrently in same program is called multithreading

    program are faster and more efficient in multiprocesser environment.

    task is a unit of work that performed by thread - asynchronous operation


    */
     class Threadcode{

        public static void DemoA(){
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            System.Console.WriteLine("Thread id is {0}",id);
            ServiceA.DoTaskA();
        }


        public static void TestDemo(){
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            System.Console.WriteLine("Thread id is {0}",id);
            System.Console.WriteLine("Thread name is {0}",t.Name);
            System.Console.WriteLine("Thread priority is {0}",t.Priority);
            System.Console.WriteLine("Thread state is {0}",t.ThreadState);
            System.Console.WriteLine("Thread is background {0}",t.IsBackground);
            System.Console.WriteLine("Thread is Alive {0}",t.IsAlive);
            System.Console.WriteLine("Thread is pool {0}",t.IsThreadPoolThread);
            System.Console.WriteLine(DateTime.Now.ToLongDateString());
            t.CurrentCulture = new CultureInfo("fr-FR");
            System.Console.WriteLine("currentCulture="+t.CurrentCulture);
            System.Console.WriteLine(DateTime.Now.ToLongDateString());
            t.CurrentCulture= new CultureInfo("te-IN");
           System.Console.WriteLine("currentCulture="+t.CurrentCulture);
            System.Console.WriteLine(DateTime.Now.ToLongDateString());    }
    }
    class ServiceA{
        public static  void DoTaskA(){
            Thread t1 = Thread.CurrentThread;
            int id  = t1.ManagedThreadId;
            System.Console.WriteLine("Inside Tread");
            int x =0;
            for(int icount =0;icount<=5;icount++){
                x+=icount;
                System.Console.WriteLine("\tID={0},x={1},icount={2}",id,x,icount);
                Thread.Sleep(1000);
            }
        }
        public static  void DoTaskB(){
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            System.Console.WriteLine("Main Thread id is {0}",id);
            ServiceA serv = new ServiceA();
            Thread t1 = new Thread(DoTaskA); //delegate
            t1.Start();
            ServiceA.DoTaskA();
            System.Console.WriteLine("end of thread");
        }
    }
}
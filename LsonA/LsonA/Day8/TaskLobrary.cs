using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LsonA.Day8
{
    /*
    Thread with extra features
    Task is a unit of work that can be executed asynchronously or in parallel
    Wrapper for Threadpool
    System.Threading.Tasks
    Demon thread runs in background
    in startup thread create on threadpool
    thread pool are recycled and reused
    toggles betwwen running and waiting
    methods to create task
    1.t1 =TaskFactory();
    2.Tt=Task.Factory.StartNew(action)
    3. t1 = new Task(action); t3.Start(); action-- functional delegate
    */
    public class TaskLobrary
    {
        public static void TestOne(){
            System.Console.WriteLine("running task");
            System.Console.WriteLine("TaskId:{0} is completed",Task.CurrentId);
        }
       
        
    }
    public class Test
    {
         public static void TestTwo(){
           int id = Thread.CurrentThread.ManagedThreadId;
           System.Console.WriteLine($"Cuurent Thread Id:{id}");
           Task t3 = new Task(TaskLobrary.TestOne);
            t3.Start();
            Task t4 = new Task(TaskLobrary.TestOne);
            t4.Start();
        }
    }

    
}
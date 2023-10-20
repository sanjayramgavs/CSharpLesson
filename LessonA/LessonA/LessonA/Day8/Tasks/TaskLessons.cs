using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Task Hierachies
-- it is formed by Task continuation
-- create the parent-child hierachy
-- parents stops then child also stops

Life cycle of Task
1.Created
2.Waited for Activation
3.Wating for Run
4.Running
5.Waiting for ChildrenToComplete
6.Ran to Complete
7.Cancelled
8.Faulted


 */
namespace ProjectAConsoleApp.DayEight.Tasks
{
    class TaskLessons
    {
        public static void TestOne()
        {
            int id=Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"CurrentThreadID: {id}");

            Task t1 = new Task(ClassA.TaskMethodA);
            t1.Start();
            Task t2 = new Task(ClassA.TaskMethodA);
            t2.Start();
        }
        public static void ContinueTask()
        {
            Task t1 = new Task(ClassA.TaskMethodA);
            Task t2 = t1.ContinueWith(ClassA.TaskMethodB);
            Task t3 = t1.ContinueWith(ClassA.TaskMethodC);
            Task t4 = t2.ContinueWith(ClassA.TaskMethodB1);
            t1.Start();
            Console.WriteLine("Bye from ContinueTask");
        }
        public static void ParentAndChild()
        {
            var parent = new Task(ClassA.ParentTask);
            Console.WriteLine("ParentStatus1: " + parent.Status);
            parent.Start();
            Console.WriteLine("ParentStatus2: " + parent.Status);
            #region A
            Thread.Sleep(1000);
            Console.WriteLine("ParentStatus: " + parent.Status);
            Thread.Sleep(1000);
            Console.WriteLine("ParentStatus: " + parent.Status);
            #endregion
            Console.WriteLine("Test Completed");
        }
        public static void CancelDemo()
        {
            Console.WriteLine("Press 1 to cancel task");
            var cTokenSource = new CancellationTokenSource();
            var cToken = cTokenSource.Token;

        }
        public static void TestCancelToken()
        {
            Console.WriteLine("Press 1 to cancel task");
            var cTokenSource = new CancellationTokenSource();
            var cToken = cTokenSource.Token;
            var t1 = Task<int>.Factory.StartNew(
                () => ClassA.GenerateNumbers(cToken), cToken);
            // to register a delegate for a callback when a 
            // cancellation request is made
            cToken.Register(ClassA.CancelNotification);
            // If user presses 1, request cancellation.
            if (Console.ReadKey().KeyChar == '1')
            {
                cTokenSource.Cancel();
            }
        }
    }
}

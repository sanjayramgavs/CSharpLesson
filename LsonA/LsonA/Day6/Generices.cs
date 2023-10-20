using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LsonA.Day6
{
    public class Employee
    {
        public int EmpId { get; set; }
        public String EmpName { get; set; }
        public String EmpAddress { get; set; }
        public int EmpSalary { get; set; }
    }
    public class Generices
    {
        public class GenericList{
        public static void GenericListFunc(){
            List<int> list = new List<int>();
            for(int i=0;i<10;i++){
                list.Add(i);
            }
            foreach(int i in list){
                System.Console.Write(i);
            }
            for(int i=0;i<list.Count;i++){
                System.Console.Write(list[i]);
            }
            System.Console.WriteLine(list.Count);
            System.Console.WriteLine(list.Capacity);

            



        }
        public static void GenericString(){
            List<String> list = new List<String>();
            for(int i=0;i<10;i++){
                list.Add("A"+i);
            }
            foreach(String i in list){
                System.Console.Write(i);
            }
        }
        public static void GenericEmployee(){
            List<Employee> empDetails = new List<Employee>();
            Employee e1 =new Employee{
                EmpId =1,
                EmpName="A",
                EmpAddress="Pune",
                EmpSalary=10000

            };
            Employee e2 =new Employee{
                EmpId =2,
                EmpName="B",
                EmpAddress="Pune",
                EmpSalary=20000

            };
            empDetails.Add(e1);
            empDetails.Add(e2);
            foreach(Employee e in empDetails){
                System.Console.WriteLine(e.EmpId);
                System.Console.WriteLine(e.EmpName);
                System.Console.WriteLine(e.EmpAddress);
                System.Console.WriteLine(e.EmpSalary);
            }

        }
        }
        public class SortedSetclass{
            public static void SortedSetclassFunc(){
                SortedSet<int> sorint = new SortedSet<int>();
                Random rn = new Random();
                for(int i=0;i<10;i++){
                    sorint.Add(rn.Next(1,100));
                }
                for(int i =0;i<10;i++){
                    System.Console.WriteLine(sorint.ElementAt(i));
                }

            }
            public static void StringSortedSetclassFunc(){
                SortedSet<String> sorint = new SortedSet<String>();
                Random rn = new Random();
                for(int i=0;i<10;i++){
                    string s = (char)rn.Next(65,90)+""+(char)rn.Next(65,90)+""+(char)rn.Next(65,90)+"";
                    sorint.Add(s);
                }
                sorint.Add("123123");
                for(int i =0;i<10;i++){
                    System.Console.WriteLine(sorint.ElementAt(i));
                }


            }

        }
        public class QueiueAndStack{
            public static void FQueue(){
                Queue<int> q = new Queue<int>();
                for(int i=0;i<10;i++){
                    q.Enqueue(new Random().Next(1,100));
                }
                System.Console.WriteLine(q.Count);
                System.Console.WriteLine(q.Peek());
                for(int i = 0;i<10;i++){
                    System.Console.WriteLine(q.Dequeue());
                }
            }
            public static void FStack(){
                Stack<int> s = new Stack<int>();
                for(int i=0;i<10;i++){
                    s.Push(new Random().Next(1,100));
                }
                System.Console.WriteLine(s.Count);
                System.Console.WriteLine(s.Peek());
                for(int i = 0;i<10;i++){
                    System.Console.WriteLine(s.Pop());
                }
            }
        }
        public class C_Dictionaty{
            public static void F_Dictionary(){
                Hashtable ht = new Hashtable();
                for(int i=0;i<10;i++){
                    ht.Add(i,(char)new Random().Next(65,90));
                }
                System.Console.WriteLine(ht.Count);
                System.Console.WriteLine(ht.ContainsKey(1));
                System.Console.WriteLine(ht.ContainsValue('A'));
                System.Console.WriteLine(ht[1]);
                foreach(DictionaryEntry i in ht){
                    System.Console.WriteLine(i.Key+" "+i.Value);
                }

            }
            public static void F_Emp_Dictionary(){
                Dictionary<int,Employee> empDetails  = new Dictionary<int,Employee>();
                Employee e1 = new Employee{
                    EmpId=1,
                    EmpName="A",
                    EmpAddress="Pune",
                    EmpSalary=10000
                };
                Employee e2 = new Employee{
                    EmpId=2,
                    EmpName="B",
                    EmpAddress="Pune",
                    EmpSalary=20000
                };
                empDetails.Add(e1.EmpId,e1);
                empDetails.Add(e2.EmpId,e2);
                foreach(var i in empDetails){
                    System.Console.WriteLine(i.Key+" "+i.Value.EmpName);
                }

            }
            public static void F_Sorted_List(){
                SortedList<int,String> sl = new SortedList<int,String>();
                for(int i=0;i<10;i++){
                    sl.Add(i,(char)new Random().Next(65,90)+""+(char)new Random().Next(65,90)+""+(char)new Random().Next(65,90)+"");
                }
                System.Console.WriteLine(sl.Count);
                System.Console.WriteLine(sl.ContainsKey(1));
                System.Console.WriteLine(sl.ContainsValue("ABC"));
                System.Console.WriteLine(sl[1]);
                foreach(var i in sl){
                    System.Console.WriteLine(i.Key+" "+i.Value);
                }
            }
            public static void F_Emp_Sorted_List(){
                SortedList<int,Employee> empDetails  = new SortedList<int,Employee>();
                Employee e1 = new Employee{
                    EmpId=1,
                    EmpName="A",
                    EmpAddress="Pune",
                    EmpSalary=10000
                };
                Employee e2 = new Employee{
                    EmpId=2,
                    EmpName="B",
                    EmpAddress="Pune",
                    EmpSalary=20000
                };
                Employee e3 = new Employee{
                    EmpId=3,
                    EmpName="C",
                    EmpAddress="Pune",
                    EmpSalary=30000
                };
                empDetails.Add(e1.EmpId,e1);
                empDetails.Add(e2.EmpId,e2);
                empDetails.Add(e3.EmpId,e3);
                foreach(var i in empDetails){
                    System.Console.WriteLine(i.Key+" "+i.Value.EmpName);
                }

                var OrderedList = from emp in empDetails
                                  orderby emp.Value.EmpSalary descending
                                  select emp;

                var OrderedList2 = empDetails.OrderByDescending(x=>x.Value.EmpSalary);
                foreach(var i in OrderedList){
                    System.Console.WriteLine(i.Key+" "+i.Value.EmpName+" "+i.Value.EmpSalary);
                }

            }
        }
        class C_Generics{
            class CustomerDetails{
                public int CustId { get; set; }
                public String CustName { get; set; }
                public String CustAddress { get; set; }
                public int CustSalary { get; set; }
            }
            class OrderDetails{
                public int OrderId { get; set; }
                public String OrderName { get; set; }
                public String OrderAddress { get; set; }
                public int OrderSalary { get; set; }
            }
            public static void F_Generics(){
                List<CustomerDetails> custDetails = new List<CustomerDetails>();
                CustomerDetails c1 = new CustomerDetails{
                    CustId=1,
                    CustName="A",
                    CustAddress="Pune",
                    CustSalary=10000
                };
                CustomerDetails c2 = new CustomerDetails{
                    CustId=2,
                    CustName="B",
                    CustAddress="Pune",
                    CustSalary=20000
                };
                custDetails.Add(c1);
                custDetails.Add(c2);
                foreach(CustomerDetails c in custDetails){
                    System.Console.WriteLine(c.CustId);
                    System.Console.WriteLine(c.CustName);
                    System.Console.WriteLine(c.CustAddress);
                    System.Console.WriteLine(c.CustSalary);
                }
                List<OrderDetails> orderDetails = new List<OrderDetails>();
                OrderDetails o1 = new OrderDetails{
                    OrderId=1,
                    OrderName="A",
                    OrderAddress="Pune",
                    OrderSalary=10000
                };
                OrderDetails o2 = new OrderDetails{
                    OrderId=2,
                    OrderName="B",
                    OrderAddress="Pune",
                    OrderSalary=20000
                };
                orderDetails.Add(o1);
                orderDetails.Add(o2);
                foreach(OrderDetails o in orderDetails){
                    System.Console.WriteLine(o.OrderId);
                    System.Console.WriteLine(o.OrderName);
                    System.Console.WriteLine(o.OrderAddress);
                    System.Console.WriteLine(o.OrderSalary);
                }
            }
        }

    }
}
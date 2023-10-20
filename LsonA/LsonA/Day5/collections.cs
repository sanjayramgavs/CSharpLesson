using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LsonA.Day3;

namespace LsonA.Day5
{
    /*
    Generics are collection that are strongly typed
    collection are hetrogenius & homogenious and generics are homogenius
    Stacks,queue,list and hash table
    all collection classes IEmumerable interface
    extend of ICollection interface
    Idictionary,IList are also dereved from ICollection
    
    no items is small then list is better
    no of items is large then dictionary is better

    stack is list,heap is list

    linked list is used on dependent form before to another
    set is the collection of unique elements so no duplicate elements

    iEmuerable
    iEmuerator
    ICollection
    IList
    IDictionary
    IDictionaryEnumerator
    IComparer

List interface
    arraylist
    queue
    stack
Dictionary interface
    HashTable
    SortedList

Iterator -- naviagte throw the data structure.irrespective of the data structure,
             we can use iterator to navigate through the data structure

    */
    public class collections
    {
        class Emp
        {
            public int ID;
            public string Name;
            public double Salary;
        }
        public class Collectionsclass
        {
            public static void ArrayListMethod()
            {
                ArrayList arr = new ArrayList();
                Random r1 = new Random();
                while (true)
                {
                    int num = r1.Next(1, 100);
                    if (arr.Capacity <= 10000)
                    {
                        arr.Add(num);
                        if (arr.Capacity % 2 == 0)
                        {
                            System.Console.WriteLine(arr.Capacity);
                        }
                    }
                    else
                    {
                        break;
                    }
                    foreach (int i in arr)
                    {
                        if (i % 1000 == 0)
                        {
                            System.Console.Write(i);
                        }
                    }
                }

                /* Iterator Pattern*/
                if (arr is IEnumerable)
                {
                    IEnumerator er = arr.GetEnumerator();
                    while (er.MoveNext())
                    {
                        object obj = er.Current;
                        if (typeof(int) == obj.GetType())
                        {
                            int x = (int)obj;// unboxing
                            Console.WriteLine(x);
                        }
                        else
                            Console.WriteLine(obj.ToString());
                    }
                }
            }
            /*
            Generic collection or strongly typed collection
        
            */
            public static void TestGeneric()
            {
                List<int> list = new List<int>();
                list.Add(1);
                list.Add(2);
                //list.Add("hello"); // error
                foreach (int i in list)
                {
                    System.Console.WriteLine(i);
                }
            }
            public static void TestGeneric2()
            {
                List<String> list = new List<String>();
                list.Add("hello");
                list.Add("world");
                //list.Add(1); // error
                foreach (String i in list)
                {
                    System.Console.WriteLine(i);
                }
            }

            public static void GenericListDemoEmp()
            {

                List<Emp> empList = new List<Emp>();
                Console.Write("Length " + empList.Count);
                Console.WriteLine("\tCapacity " + empList.Capacity);
                Emp e1 = new Emp() { ID = 123, Name = "Venkat", Salary = 10000 };
                empList.Add(e1);
                empList.Add(new Emp() { ID = 456, Name = "Krishnan", Salary = 15000 });
                //empList.Add("Hello");
                Console.Write("Length " + empList.Count);
                Console.WriteLine("\tCapacity " + empList.Capacity);
                empList.Add(new Emp() { ID = 1000, Name = "Sam", Salary = 10000 });
                empList.Add(new Emp() { ID = 500, Name = "John", Salary = 10000 });
                empList.Add(new Emp() { ID = 200, Name = "Suresh", Salary = 10000 });
                empList.Add(e1);
                empList.Add(e1);



                Console.Write("Length " + empList.Count);
                Console.WriteLine("\tCapacity " + empList.Capacity);
                //IEnumerator data = empList.GetEnumerator();
                //while (data.MoveNext())
                //{
                //    Object obj = data.Current;
                //    if (obj.GetType() == typeof(Emp))
                //    {
                //        Emp e = (Emp)obj;
                //        Console.WriteLine("Id={0}, Name={1}, Salary={2} ", e.ID, e.Name, e.Salary);
                //    }
                //    else
                //        Console.WriteLine("=======> Object is not an Employee");
                //}
                foreach (Emp e2 in empList)
                {
                    Console.WriteLine("Id={0}, Name={1}, Salary={2} ", e2.ID, e2.Name, e2.Salary);
                }
            }
            public static void HashSetMeth(){
                HashSet<String> hs = new HashSet<String>();
                hs.Add("Chennai");
                hs.Add("Bangalore");
                hs.Add("Mumbai");
                hs.Add("Delhi");
                hs.Add("Chennagalpattu");
                foreach(String s in hs){
                    System.Console.WriteLine(s);
                }


            }
            public static void TestSortedSet(){
                SortedSet<String> hs = new SortedSet<String>();
                hs.Add("Chennai");
                hs.Add("Bangalore");
                hs.Add("Mumbai");
                hs.Add("Delhi");
                hs.Add("Chennagalpattu");
                foreach(String s in hs){
                    System.Console.WriteLine(s);
                }
            }
        }
    }
}
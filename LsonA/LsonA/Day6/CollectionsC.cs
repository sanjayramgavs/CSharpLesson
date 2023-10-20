using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LsonA.Day5;

namespace LsonA.Day6
{
    public class CollectionsC
    {
       public class Arraylist{
        /*
        Dynamic in nature of array is exbited in Arraylist
        unlike array the value is added or removed with index number
        dynamic  memory allocation is done here
        */
        public static void ArraylistCreation(){
            // create arraylist
             ArrayList arr = new ArrayList();
         
            int i =0;
            while(i<10){
                arr.Add(i); //add value to Arraylist
                i++;
            }
            //print arraylist
            foreach(int j in arr){
                Console.WriteLine(j);
            }
            // find capacity of arraylist
            System.Console.WriteLine(arr.Capacity);
            // find count of Arraylist -- number of elements in arraylist
            System.Console.WriteLine(arr.Count);
            //find value in the specifoed index
            System.Console.WriteLine(arr[5]);
            //check the index of the entered value
            System.Console.WriteLine(arr.IndexOf(5));
            //remove the value from the arraylist
            arr.Remove(5); // it removes the value
            // remove the vaue from the specified Index
            arr.RemoveAt(4);  //it remove the value at specified index
            arr.Insert(4,20); // it insert the value at specified index
            arr.AddRange(arr); // it add the arraylist to the existing arraylist
            arr.Clear(); // it clears the arraylist

            arr.GetRange(2,5);

            System.Console.WriteLine(arr.Contains(5)); // it checks the value is present or not




        }
       }
    public class HashtableT{

        public void HashtableTCrration(){

        }
    }
    public class List{
        public static void LisTCreation(){
            List<int> list = new List<int>();
            int i =0;
            while(i<10){
                list.Add(i*2); //add value to Arraylist
                i++;
            }
            // print the list
            PrintCollection(list);
            int[] arr = {1,2,3,4,5,6,7,8,9,10};
            // add an range of collection in the list
            list.AddRange(arr);
            //count the value in the list
            System.Console.WriteLine(list.Count());
            // insert value at the particular index
            list.Insert(4,45);
            PrintCollection(list);
            //remove the value
            list.Remove(45);
            PrintCollection(list);
        }
    }
    public static void PrintCollection(IEnumerable collection)
    {
        foreach (var item in collection)
        {
            Console.Write(item+" ");
        }
    }

}



}
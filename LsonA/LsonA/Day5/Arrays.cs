using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LsonA.Day5
{
    /*
    c# is strongly typed language, which means we need to declare the type of the variable before using it.
    arrays are efficient way of storing multiple values of same type.
    faster access to elements in array
    
    store multiple values of same type 
    drawbacks:
    not have its own behaviour as own , no fuction in collection is applicable here
    problem :they are fixed in size

    memoery is allocated as low than other data structure
    dynamic arrays is called collection
    more efficient than collection
    search in array is faster than collection
    much effient in large data so array is efficent
    if data is less than 100 then array is better
    if data is more than 100 then collection is better
    not sure no of elements then collection is better
    arrays are homogenius, collection are hetrogenius

    lower index is 0
    upper index is size-1
    index is the position of the element in the array
    storing and retrieving through loop
    single, multi dimensional, jagged array
    matrix is 2d array  ,no of rows and columns are same

    table in rdbms is 2d array
    it is not suitable for data analysis
    cubes are 3d array it consist of x,y,z

    jagged array is array of array, uneven array, every row is different no of columns.




    */
    public class Arrays
    {
        public static void FirstMethod(){
            int[] arr = new int[10];
            // int a[] = new int[10]; //error in java is allowed, but not in c#
            int[] arrRandom = new int[10];
            int [] arrPower = new int[10];
            int i;
            for(i=0;i<10;i++){
                arr[i]=i*5;
                arrRandom[i]= new Random().Next(1,100); //random number between 1 and 100
                arrPower[i]= (int)Math.Pow(i,2);// math.pow returns double, so we need to typecast it to int
            }
            for(i=0;i<10;i++){
                System.Console.WriteLine(arr[i]+" "+arrRandom[i]+" "+arrPower[i]);
            }
        }
        public static void SecondMethod(){
            int[] arr = new int[10];
            for(int i=0;i<10;i++){
                arr[i]= new Random().Next(1,100);
                System.Console.WriteLine($"Sample[{i}] = "+arr[i]);
            }
            System.Console.WriteLine("Sum of Array"+arr.Sum());
            System.Console.WriteLine("Max of Array"+arr.Max());
            System.Console.WriteLine("Min of Array"+arr.Min());
            System.Console.WriteLine("Average of Array"+arr.Average());
            System.Console.WriteLine("Count of Array"+arr.Count());
            System.Console.WriteLine("Length of Array"+arr.Length);
            System.Console.WriteLine("First of Array"+arr.First());
            System.Console.WriteLine("Last of Array"+arr.Last());
            System.Console.WriteLine("Contains of Array"+arr.Contains(50));
            System.Console.WriteLine("Index of Array"+Array.IndexOf(arr,50));
            System.Console.WriteLine("Reverse of Array"+arr.Reverse());
        }
        public static void IndexoutError(){
            int[] arr = new int[10];
            try{
                arr[11] = 10;

            }
            catch(IndexOutOfRangeException ex){
                System.Console.WriteLine(ex.Message);

            }

        }
        //2d array
        public static void TwoDArray(){
            int i,j;
            int[,] arr = new int[3,3]; //3 rows and 3 columns -- intialize array of 2d array
            for(i=0;i<3;i++){
                for(j=0;j<3;j++){
                    arr[i,j]=i+j;
                }
            }
            for(i=0;i<3;i++){
                for(j=0;j<3;j++){
                    System.Console.Write(arr[i,j]+" ");
                }
                System.Console.WriteLine();
            }

        }
        // 3d Array
        public static void ThreeDARray(){
            int[,,] arr = new int[3,3,3]; //3 rows and 3 columns -- intialize array of 2d array with 3d of 3
            int i,j,k=0;
            for(i=0;i<3;i++){
                for(j=0;j<3;j++){
                    for(k=0;k<3;k++){
                        arr[i,j,k]=i+j+k;
                    }
                }
            }
            //print array
            for(i=0;i<3;i++){
                for(j=0;j<3;j++){
                    for(k=0;k<3;k++){
                        System.Console.Write(arr[i,j,k]+" ");
                    }
                    System.Console.WriteLine();
                }
                System.Console.WriteLine();
            }
        }
        //Jagged array
        public static void JaggedArray(){
            int[][] jagged = new int[3][];
            jagged[0] = new int[3];
            jagged[1] = new int[2];
            jagged[2] = new int[4];
            // store first row
            for(int i=0;i<3;i++){
                jagged[0][i]=i;
            }
            // store second row
            for(int i=0;i<2;i++){
                jagged[1][i]=i;
            }
            // store third row
            for(int i=0;i<4;i++){
                jagged[2][i]=i;
            }
            // print jagged array
            for(int i=0;i<3;i++){
                for(int j=0;j<jagged[i].Length;j++){
                    System.Console.Write(jagged[i][j]+" ");
                }
                System.Console.WriteLine();
            }

        }
        public static void SortArray(){
            int[] arr = new int[10];
            int[] asc = new int[10];
            int[] desc = new int[10];
            for(int i =0;i<10;i++){
                arr[i]=new Random().Next(1,100);
            }
            for(int i =0;i<10;i++){
                for(int j=0;j<9;j++){
                    if(arr[j]>arr[j+1]){
                        int temp = arr[j];
                        arr[j]=arr[j+1];
                        arr[j+1]=temp;
                    }
                }
            }
            for(int i =0;i<10;i++){
                asc[i]=arr[i];
            }
            for(int i =0;i<10;i++){
                desc[i]=arr[9-i];
            }
            System.Console.WriteLine("Original Array");
            for(int i =0;i<10;i++){
                System.Console.Write(arr[i]+" ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Ascending Array");
            for(int i =0;i<10;i++){
                System.Console.Write(asc[i]+" ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Descending Array");
            for(int i =0;i<10;i++){
                System.Console.Write(desc[i]+" ");
            }
            System.Console.WriteLine();

        }
        public static void  BestSort(){
            int[] arr = new int[10];
            for(int i =0;i<10;i++){
                arr[i]=new Random().Next(1,100);
            }
            Array.Sort(arr);
            System.Console.WriteLine("Original Array");
            for(int i =0;i<10;i++){
                System.Console.Write(arr[i]+" ");
            }
            System.Console.WriteLine();
            Array.Reverse(arr);
            System.Console.WriteLine("Descending Array");
            for(int i =0;i<10;i++){
                System.Console.Write(arr[i]+" ");
            }
            System.Console.WriteLine();
        }
        /*
        object Array can store any type of data ,
        boxing and unboxing
        boxing is converting value type to reference type
        unboxing is converting reference type to value type
        */
        public static void ObjectArray(){
            object[] arr = new object[5];
            arr[0]=1;
            arr[1]="hello";
            arr[2]=true;
            arr[3]=new int[5];
            arr[4]=new List<int>();
            for(int i=0;i<5;i++){
                System.Console.WriteLine(arr[i]);
            }
        }
      
    }

    class Employee{
        class Emp
        {
      private readonly double Id;
      public string Name;
      public string FirstName { get; set; }
      public string MiddleName { get; set; }
      public string LastName { get; set; }
      public double Salary { get; set; }
      public Emp() { }
      public Emp(double v1)
      {
          Id = v1;
      }
      public double GetID()
      {
          return Id;
      }
  }
    public static void EmpArray(){
        Emp[] emp = new Emp[5];
        for(int i=0;i<5;i++){
            emp[i]=new Emp(i);
            emp[i].Name="Emp"+i;
            emp[i].FirstName="First"+i;
            emp[i].MiddleName="Middle"+i;
            emp[i].LastName="Last"+i;
            emp[i].Salary=1000+i;
        }
        for(int i=0;i<5;i++){
            System.Console.WriteLine(emp[i].GetID()+" "+emp[i].Name+" "+emp[i].FirstName+" "+emp[i].MiddleName+" "+emp[i].LastName+" "+emp[i].Salary);
        }
    }

    }
}
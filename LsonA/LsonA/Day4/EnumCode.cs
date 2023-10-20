using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
/*
Working with Enum
Enum is list of Constants
Readonly varibal can be assigned only once through constructor only 
typeof() is used to get the type of the class,capture the metadata of the class
*/
namespace LsonA.Day4
{
   public enum City { Chenai, Bangalore, Hyderabad,Pune}
   public enum Desiganation { Manager, Lead, Developer, Tester}
     class Worker
    {
        public Worker(int id){
            ID = id;
        }
        public readonly int ID ;
        public  string Name = string.Empty;
        public City Ecity ; // Enum
        public  Desiganation JobTitle ; // Enum
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, City: {Ecity}, JobTitle: {JobTitle}";
        }


    }
    public class Work
    {
        public static void DoWork(){
            Worker worker1 = new Worker(001); // only assigned at time of object creation
            // worker1.ID = 001; // Error
            worker1.Name = "Raj";
            worker1.Ecity = City.Chenai;
            // worker1.Ecity = 0; // Error
            worker1.JobTitle = Desiganation.Developer;
            // worker1.JobTitle = 0; // Error
            Console.WriteLine(worker1.ToString());


        }  
    
    public static void TestMovieRating(){
        //Print all enum values in MovieRating
        Type t1 = typeof(MovieRating); // capture the metadata of the class
        String[] enumnames = Enum.GetNames(t1);
        String name = string.Empty;
        int len = enumnames.Length;
        for(int i = 0; i < len; i++){
            name = enumnames[i];
            MovieRating rating = (MovieRating)Enum.Parse(t1, name);
            Console.WriteLine($"Name: {name}"+" Value: {0}", (int)rating);
        }


    }
    }
   
}
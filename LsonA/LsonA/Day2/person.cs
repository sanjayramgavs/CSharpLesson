using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LsonA.Day2
{
    public class Person
    {
        public int Id{ get; set; }
       // the = string.empty to instialtiate the string to empty so it cant throw null point exception
        public string FirstName{ get; set; } = string.Empty;
        public string LastName{ get; set; } = string.Empty;
        public string Title{ get; set; } = string.Empty;

        public string Address{ get; set; } = string.Empty;
        public string City{ get; set; } = string.Empty;
        public string Region{ get; set; } = string.Empty;
        public string PostalCode{ get; set;} = string.Empty;
        public string Country{ get; set; } = string.Empty;

        public long Phone { get; set; }

        public override string ToString()
        {
            return $"ID:{Id},Name:{Title}{FirstName}{LastName},\n"+
            $"Address:{Address},City{City},State:{Region},\n"+
            $"Phone:{Phone},Country:{Country},Zip:{PostalCode}";
        }

    }

    /*
    System.object--> base class to all class, like java.lang in java. all other inherite from this .Valuetypes
    objects. non private fields are aviable to child.
    important methods -> Equals(), Gettype(), Tostring(), GetHashCode()
    these are inhertitaed by other class.
    override keyword - only used in child class, that override the method that derivated
    from the parent class with its own logics

    */
    internal class Testperson{
        public static void TestOne(){
           Person firstperson = new Person();
           firstperson.Id = 189;
           firstperson.FirstName = "mani";
           firstperson.LastName = "kishore";
           firstperson.Address="ammapettai";
           firstperson.City="Chennai";
           firstperson.Country="India";
           firstperson.Phone=986521237;
           firstperson.PostalCode="600001";
           firstperson.Region="TN";
           firstperson.Title="Mr.";
           String value = firstperson.ToString();
           Console.WriteLine(value);

        }
    }
}
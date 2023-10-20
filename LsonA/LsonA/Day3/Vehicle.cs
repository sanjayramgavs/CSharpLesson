using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LsonA.Day3
{
    /// <summary>
    /// not an compulsory that abstract class can have abstract method
    /// Abstarct can be instansiated and must be in herited
    /// 
    /// </summary>
    internal abstract  class Vehicle
    {
        public Vehicle(){
            System.Console.WriteLine("Vechivcle Constructor");
        }
        public void Start(){
            System.Console.WriteLine("Vechile Started");
        }
    }
    internal class SubVehicle:Vehicle{
        public SubVehicle(){
            System.Console.WriteLine("Subvehicle Constructor");
        }


    }
    class VehicleTester{
        public static void TestOne(){
            SubVehicle subs = new SubVehicle();
            subs.Start();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LsonA.Day4
{
    public class DateDemo
    {
        public static void FirstMethod(){
            Console.WriteLine(DateTime.Now);
            DateTime d1 = new DateTime(2020, 10, 10); //yyyy, mm, dd 
            System.Console.WriteLine(d1.ToLongDateString()); //Month in words
            System.Console.WriteLine(d1.ToShortDateString()); //Month in numbers
            System.Console.WriteLine(d1.ToLongTimeString());  //Time with seconds  
            System.Console.WriteLine(d1.ToShortTimeString());//Time without seconds
        }
        public static void SecondMethod(){
       Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");
      String strdob = Console.ReadLine();
      DateTime d1 = DateTime.Parse(strdob);
      int year = d1.Year;
      Console.WriteLine("Year OF Dob " + year);
      int month = d1.Month;
      Console.WriteLine("Month OF Dob " + month);
      int day = d1.Day;
      Console.WriteLine("Day OF Dob " + day);
      DateTime d2 = d1.AddMonths(10);
      Console.WriteLine("AddMonths(10) " + d2.ToShortDateString());
      DateTime d3 = d1.AddDays(5);
      Console.WriteLine("AddDays(5) " + d3.ToShortDateString());
      DateTime d4 = d1.AddYears(58);
      Console.WriteLine("AddYears(58) " + d4.ToShortDateString());
      DateTime d5 = d1.AddYears(-5);
      Console.WriteLine("AddYears(-5) " + d5.ToShortDateString());
           
    }
    public static void FindAgeOfPerson(){
        
      Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");
      String strdob = Console.ReadLine();
      DateTime d1 = DateTime.Parse(strdob);
       DateTime d2 = DateTime.Now;
       TimeSpan ts = d2.Subtract(d1);
       DateTime age =new DateTime(ts.Ticks);
       Console.WriteLine("Your Age is " + (age.Year - 1) + " Years " + (age.Month - 1) + " Months " + (age.Day - 1) + " Days ");

    //dayoftheweek
    System.Console.WriteLine("Day of the week " + d1.DayOfWeek);
    //dayoftheyear
    System.Console.WriteLine("Day of the year " + d1.DayOfYear);
    //isleapyear
    System.Console.WriteLine("Is Leap Year " + DateTime.IsLeapYear(d1.Year));
    //daysinmonth
    System.Console.WriteLine("Days in month " + DateTime.DaysInMonth(d1.Year, d1.Month));
    

    }
    public static void ThirdMethod(){
     Console.WriteLine("Enter your date of birth (YYYY-MM-DD):");
string dobString = String.Empty;
try
{
     dobString = Console.ReadLine();
     if (dobString == null)
     {
         Console.WriteLine("Date Of Birth is NULL!!!");
         return;
     }
     // Parse the date of birth
     DateTime dob = DateTime.Parse(dobString);

    

     // Calculate the age
     DateTime now = DateTime.Now;
     int ageYears = now.Year - dob.Year;
     if (now < dob.AddYears(ageYears))
     {
         ageYears--;
     }
     int ageMonths = 0;
     if(now.Month >= dob.Month)
     {
         ageMonths = now.Month - dob.Month;
     }
     else
     {
        ageMonths = (12- dob.Month) +now.Month;
     }
     int ageDays = 0;
     if(now.Day >= dob.Day)
     {
         ageDays = now.Day - dob.Day;
     }
     else
     {
        ageDays = DateTime.DaysInMonth(dob.Year, dob.Month-1) - dob.Day + now.Day;
        ageMonths--;
     }
     Console.WriteLine(
         $"You are {ageYears} years, {ageMonths} months, and {ageDays} days old."
     );
}
catch (Exception ex)
{
     Console.WriteLine(ex.Message);
}
    }
    public static void FindRetirementDate(){
            string dobString = String.Empty;
        try{
            System.Console.WriteLine("Enter your date of birth (YYYY-MM-DD):");
            dobString = Console.ReadLine();
            if(dobString == null){
                Console.WriteLine("Date of birth is null");
                return;
            }
            DateTime dob = DateTime.Parse(dobString);
            DateTime now = dob.AddYears(60);    
            System.Console.WriteLine(now.ToString());
            int days =  DateTime.DaysInMonth(now.Year,dob.Month);
            days = days - now.Day;
            System.Console.WriteLine(days);
            now = now.AddDays(days);
            Console.WriteLine("Your retirement date is " + now.ToShortDateString());
   //subtract one day form the nextmonth that is retirement date from 

       
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);

    }
    }

    }
}

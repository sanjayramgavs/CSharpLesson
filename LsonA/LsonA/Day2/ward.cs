using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LsonA.Day2
{
    public class Ward
    {
    public int wardID { get; set; }
    public string wardName { get; set; } = string.Empty;
    public string wardType { get; set; } = string.Empty;
    public int wardCapacity { get; set; }
    public int currentPatients { get; set; }
    public int availableBeds { get; set; }
    public string wardLocation { get; set; } = string.Empty;
    public string wardHead { get; set; } = string.Empty;
    public DateTime admissionDate { get; set; }
    public DateTime lastUpdated { get; set; }
    public string wardDescription { get; set; } = string.Empty;
    public string wardPhoneNumber { get; set; } = string.Empty;
    public int nursesOnDuty { get; set; }
    public string wardStatus { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"Ward ID: {wardID}\n" +
               $"Ward Name: {wardName}\n" +
               $"Ward Type: {wardType}\n" +
               $"Ward Capacity: {wardCapacity}\n" +
               $"Current Patients: {currentPatients}\n" +
               $"Available Beds: {availableBeds}\n" +
               $"Ward Location: {wardLocation}\n" +
               $"Ward Head: {wardHead}\n" +
               $"Admission Date: {admissionDate}\n" +
               $"Last Updated: {lastUpdated}\n" +
               $"Ward Description: {wardDescription}\n" +
               $"Ward Phone Number: {wardPhoneNumber}\n" +
               $"Nurses on Duty: {nursesOnDuty}\n" +
               $"Ward Status: {wardStatus}";
    }
}

internal class WardsDetail
{
    public static void WardDetails(){
      Ward ward1 = new Ward();
      ward1.wardID=1;
      ward1.wardName="Cardiology";
      ward1.wardType= "General";
      ward1.wardCapacity=30;
      ward1.currentPatients=15;
      ward1.availableBeds=20;
      ward1.wardLocation="Main Building";
      ward1.wardHead="Dr.smith";
      ward1.admissionDate=DateTime.Now;
      ward1.lastUpdated=DateTime.Now;
      ward1.wardDescription="best ward for heart partient";
      ward1.wardPhoneNumber="12371233214";
      ward1.nursesOnDuty=10;
      ward1.wardStatus="Active";
      String value = ward1.ToString();
      System.Console.WriteLine(value);
      
    }
}
}


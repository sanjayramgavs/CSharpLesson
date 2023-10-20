using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace Practice.WeekTwoPractice
{
    public class Customer{
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }

        public Customer(int id, string name, string address){
            CustomerId = id;
            CustomerName = name;
            CustomerAddress = address;
        }
        public override string ToString(){
            return $"Customer Id: {CustomerId}, Customer Name: {CustomerName}, Customer Address: {CustomerAddress}";
        }
    }
    public class objserilization
    {
        
        public static void ObjSerlize(){
            Customer customer = new Customer(1, "John", "123 Main St");
            using(Stream stream = File.Open("data.dat",FileMode.Create)){
                BinaryFormatter bf = new BinaryFormatter();
                #pragma warning disable SYSLIB0011
                bf.Serialize(stream, customer);
            }
            using(Stream stream = File.Open("data.dat",FileMode.Open)){
                BinaryFormatter bf = new BinaryFormatter();
                Customer customer1 = (Customer)bf.Deserialize(stream);
                Console.WriteLine(customer1.ToString());
            }
        }
       
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace LsonA.Day8
{
    /*
    Serialization can be defined as the process of storing the state of an object to a storage medium.
    the public and private fields of an object can be converted to streams of bytes and these streams of bytes can be stored in a file for later retrieval or written to a data stream

    Decerialization is the reverse process where the byte stream is used to recreate the actual object in memory. This process is also called deserialization.
    an exact clone of the original serialized object is created.
    if it is marked appropraitely,check if the object implements the ISerializable interface.
    if it does, the GetObjectData method is called and the SerializationInfo and the StreamingContext are passed as parameters to the method.
    if ISerializable is not implemented, the default serialization process is used.searilizing allfields not marked with the NonSerializedAttribute attribute.
    a check is made to determine od the formatter has a surrogate selectr,if it does, check if selector handles objects of the given type.if the selctoe handles the object type, ISerializable.GetObjectData is called on the surrogate selector.
    if no surrogate selector is present, a check is made to determine if the object is serializable.if the object is not serializable, an exception is thrown.

    two class used for formatter
    1.BinaryFormatter -- serializes and deserializes an object,or an entire graph of connected objects,in binary format. very efficient and give compact byte stream
        all objects serialized with this formatter can also be sdeserilized with it
        it is imptant note that constructor are not called when on object is deserialzed

        2.SoapFormatter 



    */
    public class Serilizations
    {
        
    }
    [Serializable] //MARKED AS SERIALIZABLE ,ATTRIBUTES TELL CLR  THAT THE CLASS CAN BE SERIALIZED
    public class Customer //:ISerializable
    {
        public readonly int ID;
        public string Name{get;set;}
        public string Address{get;set;}
        public string Phone{get;set;}
        public string Email{get;set;}


        public double CreditLimit{get;set;} 
        public Customer(int id){
            this.ID=id;
          
        }
        public double GetID(){
            return this.ID;
        }
        public override string ToString()
        {
            return $"ID:{this.ID},Name:{this.Name},Address:{this.Address},Phone:{this.Phone},Email:{this.Email},CreditLimit:{this.CreditLimit}";
        }
    }

    public class TestBinaryFormatter{
        public static void TestBinaryFormatterMain(){
            Customer obj = new Customer(101);
            obj.Name="Raj";
            obj.Address="Pune";
            obj.Phone="1234567890";
            obj.Email="asdas@casc";
            obj.CreditLimit=100000;
            obj.ToString();
            System.Console.WriteLine($"Hashcode of obj is {obj.GetHashCode()}");
            using (FileStream fs = new FileStream("Customer.dat",FileMode.Create))
            {
                // print customer.dat file size
                System.Console.WriteLine($"Size of file is {fs.Length}");
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs,obj);
                System.Console.WriteLine($"Size of file is {fs.Length}");
                
            }
            System.Console.WriteLine("Object is serialized");

        
    }
    public static void DeserializeCustomer(){
        Customer obj = null;
        using (FileStream fs = new FileStream("Customer.dat",FileMode.Open))
        {
            BinaryFormatter bf = new BinaryFormatter();
            obj = (Customer)bf.Deserialize(fs);
            System.Console.WriteLine($"Size of file is {fs.Length}");
        }
        System.Console.WriteLine("Object is deserialized");
        System.Console.WriteLine($"Hashcode of obj is {obj.GetHashCode()}");
        System.Console.WriteLine(obj.ToString());
    }
    public static void  RunMethods(){
        TestBinaryFormatter.TestBinaryFormatterMain();
        TestBinaryFormatter.DeserializeCustomer();
    }
}
}
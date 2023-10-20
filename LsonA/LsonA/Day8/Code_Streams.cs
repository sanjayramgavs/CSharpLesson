using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace LsonA.Day8
{

    /*
    two types of stream
    1. input stream -- data read from the source
    2. output stream -- data written to the destination
    at a given point of time stream can read 1 byte of data
    if read method return -1 then end of the stream is reached
    not simuntaniously

    covert the array to objects
    
    stream is an abstraction ther produce or consume the data
    linked to the physical device by the i/o system
    behave in the same way as the orginal device they linked to it

    stream
    - byte stream
    - character stream
    - binaty stream

    byte stream
    most device can only read or write the data in the form of bytes
    at lowest level all i/o is byte stream
    in c# char is 16 bit unicode character,byte is 8 bit tyoe

    easy to convert char and byte; ignore higher order of the char value
    rest of the unicode no
    byte stream not suitable for the character data
    to solve this problem c# provide the character stream ,handling the translation of the character to byte,byte to character automatically

     Stream Classes
     Stream -<<abstract class>>  // inherited by buffered stream, filestream, memory stream, unmanaged memory stream
     BufferedStream
     FileStream
     MemeoryStream
     UnmanagedMemoryStream

     textReader is an abstract class it consist of methods overriden by the derived class

    */
    public class Code_Streams
    {
        public static void M1(){
            char c1;
            System.Console.WriteLine("Enter the number");
            int i = System.Console.Read();//read the character from the keyboard -- input stream
            c1 = (char)i;
            System.Console.WriteLine("The character of {0} is {1}",i,c1); //output stream

        
        }
        public static void M2(){
            char ch = ' ';
            System.Console.WriteLine("press key q to quit");
            while(ch != 'q'){
                ch = (char)System.Console.Read();
                System.Console.WriteLine(ch);

            }
    }
    public static void M3(){
       System.Console.WriteLine("Enter the string");
       string? str = System.Console.ReadLine();  //any operarion with null is Null. 
       //objects can be null , value types cannot be null. nullable means value? can be null
         System.Console.WriteLine(str);
    }
    public static void testNull(){
        int? i = null;
        System.Console.WriteLine(i);
        int? x= 10;
        x = null; //error
        if(x.HasValue){ //check if the value is null
            System.Console.WriteLine(x.Value);
        }
        else{
            System.Console.WriteLine(x.GetValueOrDefault()); //default value of the type
        }

    }

}
}

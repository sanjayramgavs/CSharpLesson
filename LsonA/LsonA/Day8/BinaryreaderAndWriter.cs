using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LsonA.Day8
{
    public class BinaryreaderAndWriter
    {
       static MemoryStream memoryStream = new MemoryStream();
       public static void WriteBytesToMemeoryStream(){
        System.Console.WriteLine("MemoryStream.Capacity: {0}", memoryStream.Capacity);
        System.Console.WriteLine("MemoryStream.Length: {0}", memoryStream.Length);
        int arrlen = 10;
        byte[] arr = new byte[arrlen];

        //ranomly generate bytes in array
        Random rand = new Random();
        rand.NextBytes(arr); 
        StringBuilder str = new StringBuilder();
        for(int i = 0; i < arrlen; i++){
            str.Append(arr[i] + " ");
        }
        System.Console.WriteLine("arr: {0}", str);

        BinaryWriter writer = new BinaryWriter(memoryStream);
        try{
            writer.Write(arr);
            writer.Flush();
            //use bitconverter to convert datatype to bitcovertor
            // bool flag = false;
            //byte[] arr2 = BitConverter.GetBytes(flag);

            System.Console.WriteLine("MemoryStream.Capacity: {0}", memoryStream.Capacity);
            System.Console.WriteLine("MemoryStream.Length: {0}", memoryStream.Length);
            System.Console.WriteLine("MemoryStream.Position: {0}", memoryStream.Position);
        }
        catch(Exception e){
            System.Console.WriteLine("Exception: {0}", e.Message);
        }
        

       } 
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace LsonA.Day8
{
    public class StreamReaderWriterClass
    {

        /*
        durablle data, -- permanent data
        persistent data, -- temp data
        */
        static byte[] data = new byte[256];
        static MemoryStream tempStream = new MemoryStream(data);

        public static void MemStreamWriter(){
            //
            StreamWriter writer = new StreamWriter(tempStream);
            String? str = string.Empty;
            try{
                System.Console.WriteLine("Enter a string: "); 
                str = Console.ReadLine();
                writer.WriteLine(str);
                writer.Flush();
                System.Console.WriteLine("tempStream: {0}", tempStream);
                System.Console.WriteLine("tempStream.Length: {0}", tempStream.Length);
                System.Console.WriteLine("tempStream.Position: {0}", tempStream.Position);
                System.Console.WriteLine("tempStream.Capacity: {0}", tempStream.Capacity);

            }
            catch(Exception e){
                System.Console.WriteLine("Exception: {0}", e.Message);
            }


        }
        public static void MemStreamReader(){
              Console.WriteLine("memstrm.Postion " + tempStream.Position);
     StreamReader memrdr = new StreamReader(tempStream);
     try
     {
         Console.WriteLine("\nReading through memrdr: ");
         // Read from tempmemorystream using the stream reader.
         tempStream.Seek(0, SeekOrigin.Begin); // reset file pointer
         Console.WriteLine("tempmemorystream.Postion After seek " + tempStream.Position);
         string str = memrdr.ReadLine();
         while (str != null)
         {
             Console.WriteLine(str);
             //if (str.CompareTo(".") == 0) break;
             str = memrdr.ReadLine();
         }
     }
     finally
     {
         memrdr.Close();
     }
        }
         public static void testmeth(){
            MemStreamWriter();
            System.Console.WriteLine("Done Writing");
            Thread.Sleep(1000);
            MemStreamReader();
        
       
    }
}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

using System.Threading.Tasks;
using LsonA.Day3;

namespace LsonA.Day8
{
    /*
    File.ReadAllBytes() -- read all bytes in a file
    File.WriteAllBytes() -- write all bytes in a file
    File.ReadAllLines() -- read all lines in a file
    File.WriteAllLines() -- write all lines in a file
    File.ReadAllText() -- read all text in a file
    File.WriteAllText() -- write all text in a file
    File.AppendAllLines() -- append all lines in a file
    File.AppendAllText() -- append all text in a file
    File.Copy() -- copy a file
    File.Delete() -- delete a file
    File.Exists() -- check if a file exists
    File.Move() -- move a file
    File.Open() -- open a file
    File.OpenRead() -- open a file to read
    File.OpenText() -- open a file to read text

    */
    public class FileHandlings
    {
        public static void FileWriteAllLines()
        {
            string fname = @"D:\temp\test.txt";
            string[] lines = { "This is line 1", "This is line 2", "This is line 3" };
            try
            {
                File.WriteAllLines(fname, lines);
                System.Console.WriteLine("File.WriteAllLines is done");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
        public static void ReadAllLiness()
        {
            string fname = @"D:\temp\test.txt";
            try
            {
                string[] lines = File.ReadAllLines(fname);
                foreach (string line in lines)
                {
                    System.Console.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
        public static void RenameFile()
        {
            string fname = @"D:\temp\test.txt";
            string newname = @"D:\temp\test2.txt";
            try
            {
                File.Move(fname, newname);
                // File.Copy(fname, newname);
                System.Console.WriteLine("File.Move is done");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
        public static void DeleteFile()
        {
            string fname = @"D:\temp\test2.txt";
            try
            {
                File.Delete(fname);
                System.Console.WriteLine("File.Delete is done");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
        public static void FileExists()
        {
            string fname = @"D:\temp\test2.txt";
            try
            {
                if (File.Exists(fname))
                {
                    System.Console.WriteLine("File.Exists is true");
                }
                else
                {
                    System.Console.WriteLine("File.Exists is false");
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
        public static void CreateDirectory()
        {
            string dname = @"D:\temp\test";
            try
            {
                Directory.CreateDirectory(dname);
                System.Console.WriteLine("Directory.CreateDirectory is done");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
        public static void DeleteDirectory()
        {
            string dname = @"D:\temp\test";
            try
            {

                if (Directory.Exists(dname))
                {
                    System.Console.WriteLine("Directory.Exists is true");
                    Directory.Delete(dname);
                    System.Console.WriteLine("Directory.Delete is done");
                }
                else
                {
                    System.Console.WriteLine("Directory.Exists is false");
                }

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
        public static void ListFiles()
        {
            string dname = @"D:\temp";
            try
            {
                string[] files = Directory.GetFiles(dname);
                foreach (string file in files)
                {
                    System.Console.WriteLine(file);
                }
                string[] dirs = Directory.GetDirectories(dname);
                foreach (string dir in dirs)
                {
                    System.Console.WriteLine(dir);
                }
                
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
        // create an file with stringbuilder
        public static void CreateFile()
        {
            // string fname = @"D:\temp\test4.txt";
            // try
            // {
            //     StringBuilder sb = new StringBuilder();
            //     sb.AppendLine("This is line 1");
            //     sb.AppendLine(Environment.NewLine);
            //     sb.AppendLine("This is line 2");
            //     sb.AppendLine(Environment.NewLine);
            //     sb.AppendLine("This is line 3");

            //     File.WriteAllText(fname, sb.ToString());
            //     System.Console.WriteLine("File.WriteAllText is done");
            // }
            // catch (Exception ex)
            // {
            //     System.Console.WriteLine(ex.Message);
            // }
        }
        // write file with streamwriter
        public static void WriteFile()
        {
            string fname = @"D:\temp\test5.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(fname)) // object is create with using block that scope is limited to the block.then writer object is closed 
                {
                    sw.WriteLine("This is line 1");
                    sw.WriteLine("This is line 2");
                    sw.WriteLine("This is line 3");
                }
                System.Console.WriteLine("File.WriteAllText is done");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
        // StreamWriter append to file

        /*
        StreamReader is much faster than File.ReadAllLines() and File.ReadAllText() because it uses a buffer to read the file.
        when file in gb use file.io to read the file ,32bit will crash,no problem in StreamReader it use less memory
        */
        public static void appendlines(){
            String fname = @"D:\temp\test4.txt";
            String[] lines = {"This is line 4", "This is line 5", "This is line 6"};
            try
            {
                using (StreamWriter sw = new StreamWriter(fname, true)) //it appends the data in which file exists or  else it creates a new file instead of overwriting or deleting it
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line);
                    }
                }
                System.Console.WriteLine("File.WriteAllText is done");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
        // file.Readallbytes to read in an image
        /*
        cache the image is efficient
        */
        public static byte[] Logo{
            get{
                string fname = @"D:\temp\test.png";
                byte[] logo = null;
                try
                {
                    logo = File.ReadAllBytes(fname);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                return logo;
            }
        }

    }
}
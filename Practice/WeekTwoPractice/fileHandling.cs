using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.WeekTwoPractice
{
    public class fileHandling
    {
        public static void Writingfile(){
            String path =@"D:\temp\test.txt";
            string[] line = {"First line", "Second line", "Third line"};
            File.WriteAllLines(path, line);
            String[] readText = File.ReadAllLines(path);
            foreach (string s in readText)
            {
                Console.WriteLine(s);
            }
            String newpath = @"D:\temp\test2.txt";
            File.Copy(path, newpath);
            File.Delete(path);
            // get directories
            string[] dirs = Directory.GetDirectories(@"D:\temp");
            foreach (string dir in dirs)
            {
                Console.WriteLine(dir);
            }
            // get files
            string[] files = Directory.GetFiles(@"D:\temp");
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            //GetCurrentDirectory
            string currentDir = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDir);
            //CreateDirectory
            string newDir = @"D:\temp\newDir";
            Directory.CreateDirectory(newDir);
            //DeleteDirectory
            Directory.Delete(newDir);

            //StreamWriter
            string path2 = @"D:\temp\test.txt";
            String[] lines = {"First line", "Second line", "Third line"};   
            using (StreamWriter sw = new StreamWriter(path2))  
            {  
                foreach (string linew in lines)  
                {  
                    sw.WriteLine(linew);  
                }  
            }
            //StreamReader
            string path3 = @"D:\temp\test.txt";
            StringBuilder sb = new StringBuilder(250);
            using(StreamReader sr = new StreamReader(path3)){
                sb.Append(sr.ReadLine());
                while(!sr.EndOfStream){
                    sb.Append(sr.ReadLine());
                    sb.Append(Environment.NewLine);
                }
            }


        }
    }
}
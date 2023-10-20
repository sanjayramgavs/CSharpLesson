namespace LsonA.Day1
{
    internal class statements
    { 
        public static void TestDrive()
        {
            Console.WriteLine("enter your age");
            int age = 0;
            try
            {
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e) {
                Console.WriteLine(e.ToString());
                Console.WriteLine("error re enter numeric");
                age = Convert.ToInt32(Console.ReadLine());
            }
            if (age < 18)
                {
                    Console.WriteLine("you are not eligible to drive");

                }
                else
                {
                    Console.WriteLine("you are eligible to drive");
                }
            }
        }
        
    }

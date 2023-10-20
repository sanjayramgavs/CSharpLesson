using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LsonA.Day1
{
    internal class UserAndPassword
    {
        public static void Dologin() {
            Console.WriteLine("enter the User Name");
            String name = Console.ReadLine();
            Console.WriteLine("enter the password");
            String password = Console.ReadLine();
            Checker(name, password);        
        }
        public static void Checker(string username, string password)
        {

            char[] chars = username.ToCharArray();
            if((username.Length>3 ||  password.Length<15) && ValidPassword(password) ){
                Console.WriteLine("perfect user name and Password");
            }
            else
            {
                Console.WriteLine(" wrong password retry");
                Dologin();
                
            }

        }
        internal static bool ValidPassword(String password)
        {
            if (!((password.Length >= 8)
           && (password.Length <= 15)))
            {
                return false;
            }
            if (password.Contains(" "))
            {
                return false;
            }
            if (true)
            {
                int count = 0;
                for (int i = 0; i <= 9; i++)
                {
                    String str1 = i.ToString();

                    if (password.Contains(str1))
                    {
                        count = 1;
                    }
                }
                if (count == 0)
                {
                    return false;
                }
            }
            if (!(password.Contains("@") || password.Contains("#")
                || password.Contains("!") || password.Contains("~")
                || password.Contains("$") || password.Contains("%")
                || password.Contains("^") || password.Contains("&")
                || password.Contains("*") || password.Contains("(")
                || password.Contains(")") || password.Contains("-")
                || password.Contains("+") || password.Contains("/")
                || password.Contains(":") || password.Contains(".")
                || password.Contains(", ") || password.Contains("<")
                || password.Contains(">") || password.Contains("?")
                || password.Contains("|")))
            {
                return false;
            }
            if (true)
            {
                int count = 0;
                for (int i = 65; i <= 90; i++)
                {
                    char c = (char)i;
                    String str1 = c.ToString();
                    if (password.Contains(str1))
                    {
                        count = 1;
                    }
                }
                if (count == 0)
                {
                    return false;
                }
            }
            if (true)
            {
                int count = 0;
                for (int i = 97; i <= 122; i++)
                {
                    char c = (char)i;
                    String str1 = c.ToString();

                    if (password.Contains(str1))
                    {
                        count = 1;
                    }
                }
                if (count == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

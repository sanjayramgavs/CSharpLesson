using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LsonA.Day5
{
    public class Assessment
    {
        
    }
public static class Question2{
    public static String strFriend ="Tom and Jerry are Good Friends";

    public static void CountWords(){
        int count =0;
        String[] strArray = strFriend.Split(" ");
        foreach(String str in strArray){
            count++;
        }
    }
    public static void ReverseString(){
        char[] charArray = strFriend.ToCharArray();
        for(int i=charArray.Length-1;i>=0;i--){
            Console.Write(charArray[i]);
        }
    }
    public static void CountCharacters(){
        char[] charArray = strFriend.ToCharArray();
        int count =0;
        foreach(char ch in charArray){
            count++;
        }
    }
    public static void ToUpperCase(){
       string strUpper = strFriend.ToUpper();
       System.Console.WriteLine(strUpper);
    }
    public static void tenthfifteenth(){
        string strTenth = strFriend.Substring(10);
        string strFifteenth = strFriend.Substring(15);
        System.Console.WriteLine(strTenth+" "+strFifteenth);
    }

}
static class Question7{
    public static void PrintValue(){
        int x =4,y=10;
        Swap(ref x,ref y);
        System.Console.WriteLine(x+" "+y);
    }
    public static void Swap(ref int x,ref int y){
        x= x+y;
        y= x-y;
        x= x-y;
    }
}
class Question8{
internal interface IServiceA{
    void Fly();
}
internal interface IServiceB{
    void Run();
    void Swim();
}
        class ChildClass : IServiceA, IServiceB
        {
            public  void Fly()
            {
                System.Console.WriteLine("Fly");
            }
            public void Run(){
                System.Console.WriteLine("Run");
            }
            public void Swim(){
                System.Console.WriteLine("Swim");
            }
        }
        public static void PrintValue(){
            ChildClass childClass = new ChildClass();
            childClass.Fly();
            childClass.Run();
            childClass.Swim();
        }
    }
    class Question9{
        public abstract class Box{
            public abstract void Show();
        }
        public class SmallBox : Box{
            public override void Show(){
                System.Console.WriteLine("Small Box");
            }
        }
        public void PrintValue(){
            SmallBox smallBox = new SmallBox();
            smallBox.Show();
        }
    }
    class Question10{
        public static void TestMultipleNestedTry(){
            try{
            try // try1
            {
                try // try2
                {
                    try //try3
                    {
                        try //try4
                        {
                            throw new Exception("bla bla");
                        }
                        catch (Exception ex0)
                        {
                            throw new ApplicationException("ex0"+ex0.Message);
                        }//end of try4
                        
                    }
                    catch (ApplicationException ex1)
                    {
                        throw new IndexOutOfRangeException("ex1"+ex1.Message);
                    }
                    catch (Exception ex2)
                    {
                        throw new Exception("ex2"+ex2.Message);
                    }//end of try3
                }
                catch (ApplicationException ex3)
                {
                    throw new DllNotFoundException("ex3"+ex3.Message);
                }
                catch (IndexOutOfRangeException ex4)
                {
                    throw new ArgumentNullException("ex4"+ex4.Message);
                }
                catch (Exception ex5)
                {
                throw new Exception("ex5"+ex5.Message);
                }// end of try2
            }
            catch (ApplicationException ex6)
            {
                throw new ArgumentNullException("ex6"+ex6.Message);
            }
catch (DllNotFoundException ex7)
{
throw new DllNotFoundException("ex7"+ex7.Message);
}
catch (ArgumentNullException ex8)
{
throw new ArgumentNullException("ex8"+ex8.Message);
}
catch (Exception ex9)
{
throw new ArgumentNullException("ex9"+ex9.Message);
            }// end of try1
        }
        
        catch(ArgumentNullException msg){
            System.Console.WriteLine(msg.Message);

        }
    }
}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LsonA.Day3
{
    /// <summary>
    /// Interface can start with I with naming
    /// cant have constructor, it is not an class so no object
    /// all methods are abstract methods
    /// by default as public methods
    /// inherivent in abstract class,
    /// implemts the interfaces
    /// every method must implemets all methods, if one is not then marked as abstract
    /// Implents is an contract, inheritance is an part of  family
    /// interface can be implented by multiple class
    /// class can implent multiple interface
    /// 2 or more abstract method child inable to inherit from multiple class
    /// inheritance is not for code reuse
    /// inheritate only on overriding the method the parent method
    /// 
    /// </summary>
    class interfaces{

    }
    internal interface IMessageService{
        void SendMessage(String message);
        void SendAudioMessage(String message);
        void SendVideoMessage(String message);
        void RecieveMessage();
        void DeleteMessage();
        void SendEmail(string v);
    }
    internal interface IEmailService{
        void SendEmail(String message);
        void RecieveEmail();
        void DeleteEmail();
    }
    //internal abstract class Whatsapp : IMessageService // if abstract then no need to implement all methods
    internal class Whatsapp : IMessageService,IEmailService
    {
        public void DeleteMessage()
        {
            System.Console.WriteLine("Delete message ");
        }
        public void RecieveMessage()
        {
            System.Console.WriteLine("Recieve message");
        }
        public void SendAudioMessage(string message)
        {
            System.Console.WriteLine("Send audio message");
        }
        public void SendMessage(string message)
        {
            System.Console.WriteLine("Send message");
        }
        // public void SendVideoMessage(string message) declare as abstract in interface so no need to implement here 
        public  void SendVideoMessage(string message){
            System.Console.WriteLine("Send video message");
        }
        public void SendEmail(string message)
        {
            System.Console.WriteLine("Send email");
        }
        public void RecieveEmail()
        {
            System.Console.WriteLine("Recieve email");
        }
        public void DeleteEmail()
        {
            System.Console.WriteLine("Delete email");
        }
      
    }
    internal abstract class Facebook :IMessageService{
        public  void DeleteMessage(){
            System.Console.WriteLine("Delete message not implemented");
        }
        public  void RecieveMessage(){
            System.Console.WriteLine("Recieve message not implemented");
        }
        public  void SendAudioMessage(string message){
            System.Console.WriteLine("Send audio message not implemented");
        }

        public void SendEmail(string v)
        {
            throw new NotImplementedException();
        }

        public  void SendMessage(string message){
            System.Console.WriteLine("Send message not implemented");
        }
        public  void SendVideoMessage(string message){
            System.Console.WriteLine("Send video message not implemented");
        }
    }
    class ChildFacebook:Facebook{

    }
    public class MessageTester{
        public static void MessageTesting1(){
            IMessageService message = new Whatsapp();
            message.SendMessage("Hello");
            message.SendAudioMessage("Hello");
            message.SendVideoMessage("Hello");
            message.RecieveMessage();
            message.DeleteMessage();  
            message.SendEmail("Hello");   
        }
        public static void MessageTesting2(){
            IMessageService message = new ChildFacebook();
            message.SendMessage("Hello");
            message.SendAudioMessage("Hello");
            message.SendVideoMessage("Hello");
            message.RecieveMessage();
            message.DeleteMessage();

        }
    }
}


using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace LsonA.Day7
{
    /*
    Design an events
    take out the nouns of the problem 
    and make them into classes
    take verbs out the action to events

    classes of three types
    1. Entity classes -- classs only have data,, persisent and durable, save in json or table, transfer different layer of the softeware from object by json or xml and covert to object
                         mapped to table , object of entity mapped to table, are normal seririzable,
    2. Boundary classes -- classes that interact with the external environment
    3. Control classes -- Control the flow of the application -- 
    || types
        request  handler controller -- handle the request from the client
        buissness controller -- buissness logic is writtern
        repository controller -- take care of connection to the database and modification of database
        error controllers -- handle the error and exception
        audit controller -- audit the log of the application

    three types of objects
    1. actors - extract service form other objects 
    2. agents - objects that provide services to other objects ,delegration is happen between objects
    3. server - provide only service from other objects
    
    events are the way to communicate between objects
    unknown objects come together and work together without knowing each other
    */
    public class Co_Events
    {
        public enum AccountType{
            Savings,
            Current,
            Fixed,
            Recurring
        }
        public  delegate void  MessageHandler(long phoneNo,String msg);
        public  delegate void  EmailHandler(string emailAddress,String msg);
        // event is a keyword-- force to multicast delegate

        public class Bank{
            public readonly int BankID;
            public string BankName{get;set;}

            public Bank(int bankID, string bankName, string bankAddress){
                BankID = bankID;
                BankName = bankName;
              
            }
            public class BankBranch{
                public readonly int BranchID;
                public readonly int BankID;
        public BankBranch(string branchName) 
        {
            this.BranchName = branchName;
   
        }
                        public string BranchName{get;set;}
                public string BranchAddress{get;set;}

                 public List<Customer> CustomersList = new List<Customer>();

                public BankBranch(int branchID, int bankID, string branchName, string branchAddress){
                    BranchID = branchID;
                    BankID = bankID;
                    BranchName = branchName;
                    BranchAddress = branchAddress;
                }
                public void AddCustomer(Customer customer){
                    CustomersList.Add(customer);
                }
                public void RemoveCustomer(Customer customer){
                    CustomersList.Remove(customer);
                }
                public Customer GetCustomer(int CustomerID){
                    
                    Customer customer = CustomersList.Find(c => c.CustomerID == CustomerID);
                    if (customer != null)
                    {
                        return customer;
                    }
                    else
                    {
                        return null;
                    }
                }


            }

            public class Customer{
                public  readonly int CustomerID;
                public readonly int AccountID;       
                public string CustomerName{get;set;} = String.Empty;
                public string CustomerAddress{get;set;} = String.Empty;
                public string CustomerPhone{get;set;} = String.Empty;
                public string CustomerEmail{get;set;} = String.Empty;

                HashSet<Account> AccountsList = new HashSet<Account>();

                public Customer(int customerID, int accountID, string customerName, string customerAddress, string customerPhone, string customerEmail){
                    CustomerID = customerID;
                    AccountID = accountID;
                    CustomerName = customerName;
                    CustomerAddress = customerAddress;
                    CustomerPhone = customerPhone;
                    CustomerEmail = customerEmail;
                }                

            }
            public class Account{
                public readonly long AccountID;
                public readonly int CustomerID;

                public AccountType AccountType;
                public double AccountBalance{get;set;} = 0.0;
                public const double MaximumAmount = 1000000000d;
                public const double MinimumAmount = 100d;

                public float CurrentBalance{
                    get{
                        return (float)AccountBalance;
                    }
                    set{
                        if ((CurrentBalance - value)<1)
                        {
                            AccountBalance = value;
                            throw new Exception("Insufficient Balance");
                        }
                        if ((value+CurrentBalance)>MaximumAmount)
                        {
                            throw new Exception("Maximum Amount Exceeded");
                        }
                        AccountBalance = value;
                    }

                }
                public void DoWithdraw(double amount, int accountNo){
                 if(accountNo != 0){
                        
                    if(amount == 0){
                        throw new Exception("Amount cannot be zero");
                    }

                    if ((AccountBalance - amount)<1)
                    {
                        throw new Exception("Insufficient Balance");
                    }
                    if ((amount+AccountBalance)>MaximumAmount)
                    {
                        throw new Exception("Maximum Amount Exceeded");
                    }
                 }
                 else{
                        throw new Exception("Account not found");
                 }
                    AccountBalance -= amount;
                    
                }
                public void DoDeposit(double amount, int accountNo){
                    if(accountNo != 0){
                        
                    if(amount == 0){
                        throw new Exception("Amount cannot be zero");
                    }

                    if ((AccountBalance - amount)<1)
                    {
                        throw new Exception("Insufficient Balance");
                    }
                    if ((amount+AccountBalance)>MaximumAmount)
                    {
                        throw new Exception("Maximum Amount Exceeded");
                    }
                 }
                 else{
                        throw new Exception("Account not found");
                 }
                    AccountBalance += amount;
                }


            

                public static void AddAccount(Account account){

                }
                public static void OpenAccount(Account account){

                }
                public static void CloseAccount(Account account){

                }
                public static void Deposit(Account account){

                }
                public static void Withdraw(Account account){

                }
                public static void Transfer(Account account){

                }
                public static void CheckBalance(Account account){

                }
                public static void SendMessage(Account account){

                }
                public static void SendEmail(Account account){

                }

            }
           public interface IMessage{
                void SendMessage(long phoneNo,String msg);
                void SendEmail(string emailAddress,String msg);
                void ReceiveMessage(String msg);
                void ReceiveEmail(String msg);
            }
            class MessageController : IMessage
            {
                private int ID;

                public int ID1 { get => ID; set => ID = value; }

                public void ReceiveEmail(string msg)
                {
                    try
                    {
                        System.Console.WriteLine("not implemented");
                    }
                    catch (Exception err)
                    {

                        System.Console.WriteLine(err.Message);
                    }
                }

                public void ReceiveMessage(string msg)
                {
                    throw new NotImplementedException();
                }

                public void SendEmail(string emailAddress, string msg)
                {
                    throw new NotImplementedException();
                }

                public void SendMessage(long phoneNo, string msg)
                {
                    throw new NotImplementedException();
                }
            }

            public enum MessagePriority{
               
                High =3,
                Medium =2,
                Low =1,
                 Normal =0,
            }
            public class Message{
                public String Header = String.Empty;
                public String Body = String.Empty;
                public String From = String.Empty;
                public String To = String.Empty;
                public String Subject = String.Empty;
                public MessagePriority Priority = MessagePriority.Normal;

                
            }

        }
    }
}
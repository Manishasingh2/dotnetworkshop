using System;
using BankLibrary;
using BankLibrary.Models;
using BankingFunctionality;
using System.IO;
using System.Collections.Generic;
namespace  Question2
{
    class libClient
    {
        public static void Main(){
        DatabaseTrainingContext db=new DatabaseTrainingContext();
        ManishaSbaccount sbaccount=new ManishaSbaccount();  
        BankRepository c=new BankRepository();
        Class1 class1=new Class1();
        Console.WriteLine("Menu");
        Console.WriteLine("1....Add New Account");
        Console.WriteLine("2....Get Account Details");
        Console.WriteLine("3....Deposit Amount");
        Console.WriteLine("4....WithDraw Amount");
        Console.WriteLine("5....Get All Accounts");
        Console.WriteLine("6....Get Transactions");
        Console.WriteLine("7....Fund Transfer");
        Console.WriteLine("8....Loan Eligibility");
        char p='Y';
        do
        {
        Console.WriteLine("Enter your Choice?");
        int ch=Convert.ToInt32(Console.ReadLine());
        switch(ch)
        {
         case 1:
                c.NewAccount(sbaccount);
                break;
         case 2:
                Console.WriteLine("Enter your Account number to get the details:");
                int acc=Convert.ToInt32(Console.ReadLine());
                try
                {
                class1.GetAccountDetails(acc);
                }
                catch(Exception e)
                {
                        Console.WriteLine(e.Message);
                }
                break;
                
        case 3: 
                Console.WriteLine("Enter your Account number and amount to deposit:");
                int ac=Convert.ToInt32(Console.ReadLine());
                decimal amt=decimal.Parse(Console.ReadLine());
                try{
                class1.Deposit(ac,amt);
                }
                catch(Exception e)
                {
                        Console.WriteLine(e.Message);
                }
                break;
        case 4:
                Console.WriteLine("Enter your Account number and amount to withdraw:");
                int ac3=Convert.ToInt32(Console.ReadLine());
                decimal amt1=decimal.Parse(Console.ReadLine());
                try{
                class1.Withdraw(ac3,amt1);
                }
                catch(Exception e)
                {
                        Console.WriteLine(e.Message);
                }
                break;
        case 5:
                Console.WriteLine("Data of All Accounts");
                class1.GetAllAccounts();
                break;
        case 6:
                Console.WriteLine("Enter your Account number:");
                int acn=Convert.ToInt32(Console.ReadLine());
                List< ManishaSbtransaction> l=c.GetTransactions(acn);
                FileStream fileStream=new FileStream("TransactionDataFile.txt",FileMode.Append,FileAccess.Write);
                StreamWriter s=new StreamWriter(fileStream);
                try{
                foreach(var item in l)
                {  var d=item.TransDate;
                   
                    s.WriteLine("Account Number:"+item.Accno+" Transaction Date:"+item.TransDate+" Amount:"+item.Amt+" Transaction Tpe:"+item.TransType+" TID:"+item.TransId);
                    Console.WriteLine("Account Number:"+item.Accno+" Transaction Date:"+item.TransDate+" Amount:"+item.Amt+" Transaction Tpe:"+item.TransType+" TID:"+item.TransId);
                }
                Console.WriteLine("Data Has been Written to File!");
                }catch (Exception e)
                {Console.WriteLine(e.Message);}
                finally{
                        s.Flush();
                        fileStream.Close();
                        }
                break;

        case 7:
                Console.WriteLine("Enter Your Account no. and the account no. to tranfer");
                int acc1=Convert.ToInt32(Console.ReadLine());
                int acc2=Convert.ToInt32(Console.ReadLine());
                try{
                class1.TransferAmount(acc1,acc2);
                }
                catch(Exception e)
                {
                      Console.WriteLine(e.Message);  
                }
                break;
        case 8:
                Console.WriteLine("Enter the Account No.:");
                int accno=Convert.ToInt32(Console.ReadLine());
                
                try
                {
                        class1.LoanEligibility(accno);
                }
                catch(Exception e)
                {
                        Console.WriteLine(e.Message);
                }
                break;
        default:
                Console.WriteLine("Please Enter Valid Choice");
                break;
        
        }
        Console.WriteLine("Wants to choose again press Y or y otherwise n or N");
        p=Convert.ToChar(Console.ReadLine());
        }while(p=='Y' || p=='y');
       
       
        }
      
    }
}
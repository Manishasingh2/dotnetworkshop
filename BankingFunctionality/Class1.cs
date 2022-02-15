using System;
using BankLibrary;
using AutoMapper;
using BankLibrary.Models;
using System.Collections.Generic;

namespace BankingFunctionality
{
    public class Class1
    { 
     
/*

IMapper mapper = config.CreateMapper();
var source=objEmployee;
var dest = mapper.Map<Employee, User>(source);*/


    class AccountNotFoundException:ApplicationException
    {
        public AccountNotFoundException(string s):base(s)
        {
          
        }

    }
    class MoneyNegativeException:ApplicationException
    {
        public MoneyNegativeException(string s):base(s)
        {
          
        }
    }
    class LoanNotEligibleException:ApplicationException
    {
        public LoanNotEligibleException(string s):base(s)
        {
          
        }

    }
   

        BankRepository br=new BankRepository();
        public void Deposit(int accno,decimal amt)
        {
            
            bool b=br.DepositAmount(accno,amt);
            if(b==true)
            Console.WriteLine("Amount Has been Deposited!!");
            br.UpdatedAmount(accno);
        }
        public void GetAccountDetails(int accno)
        {
               
            var sb1=br.GetAccountDetails(accno);
            Console.WriteLine("Your Details:");
            Console.WriteLine("Account no:"+sb1.Accno+" Name:"+sb1.Name+" Address:"+sb1.Address+" Current Bal:"+sb1.Bal);
        }
        public void Withdraw(int accno,decimal amt)
        {
            bool b=br.WithdrawAmount(accno,amt);
            if(b==true)
            Console.WriteLine("Amount Has Been Withdrwan!!");
            br.UpdatedAmount(accno);
        }
         
        public void GetAllAccounts()
        {
            /*var config=new MapperConfiguration(cfg=>
                                                     {
                                                       cfg.CreateMap<SBaccountMapper,ManishaSbaccount>();
                                                     });
            SBaccountMapper sBaccountMapper=new SBaccountMapper();
            IMapper mapper = config.CreateMapper();
            List<SBaccountMapper> S=new List<SBaccountMapper>();*/
            var S=br.GetAllAccounts();
            foreach(var item in S)
            {       //var source=sBaccountMapper;
                    //var dest = mapper.Map<SBaccountMapper,ManishaSbaccount>(item);
                    Console.WriteLine("Account Number:"+item.Accno+" Name:"+item.Name+" Address:"+item.Address+" Current Balance:"+item.Bal);
            }
        }
        public void TransferAmount(int acc1,int acc2)
        {   
           
            bool b=br.ValidateUser(acc1);
            bool b2=br.ValidateUser(acc2);
            if(b==false && b2==false)
            {
                throw new AccountNotFoundException("No Data Found For Both the Accounts.Please Enter Valid Account no.!!");
            }
            else if(b==false)
            {
               throw new AccountNotFoundException("No Data Found For Account no: "+acc1+" Please Enter Valid Account no.!!");
            }
            else if(b2==false)
            {
                throw new AccountNotFoundException("No Data Found For Account no: "+acc2+" Please Enter Valid Account no.!!");
            }
            else{
            Console.WriteLine("Fund Can be Transfered...");
            Console.WriteLine("Now Enter amount to Transfer:");
            decimal amt3=decimal.Parse(Console.ReadLine());
            if(amt3<0)
            {
                throw new MoneyNegativeException("Amount cannot be Negative!!");
            }
             

            var sb2=br.GetAccountDetails(acc1);
            
            br.Transfer(acc1,acc2,amt3);
            Console.Write("After Transferring...");
            br.UpdatedAmount(acc1);
            
           }
            
        }
        public void LoanEligibility(int accno)
        {   int deposit=0,withdraw=0,j=5;
            bool b=br.ValidateUser(accno);
            if(b!=true)
                throw new AccountNotFoundException("Account not found..Not Eligible for Loan!!");
            Console.WriteLine("Enter Loan Amount");
            decimal loanamt=decimal.Parse(Console.ReadLine());
            if(loanamt<0)
                throw new MoneyNegativeException("Amount cannot be Negative!!");
            var item=br.GetTransactions(accno);
            if(item.Count<5)
                throw new LoanNotEligibleException("Not Eligible For Loan...Less than 5 transactions!!");
            var sb2=br.GetAccountDetails(accno);
            decimal amtcond=loanamt/3;
            if(sb2.Bal<amtcond)
                throw new LoanNotEligibleException("Not Eligible For Loan...Loan Amount is Very High!!");
            item.Reverse();
            foreach(var i in item)
            {
                if(j==0)
                break;
                if(i.TransType.Equals("Deposit"))
                    deposit++;
                else if(i.TransType.Equals("Withdraw"))
                    withdraw++;
                j--;
            }
            if((deposit>withdraw) && (deposit>=3))
            Console.WriteLine("You Are Eligible For Loan");
            else
            Console.WriteLine("You Are Not ELigible For Loan...More of Withdraws!!");
        }

            

        
    }
}

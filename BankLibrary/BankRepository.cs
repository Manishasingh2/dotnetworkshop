using System;
using BankLibrary.Models;
using System.Collections.Generic;
using System.Linq;
namespace BankLibrary
{
    class MoneyCannotWithdrawException:ApplicationException
    {
        public MoneyCannotWithdrawException(string s):base(s)
        {
          
        }

    }
    class AccountNotFoundException:ApplicationException
    {
        public AccountNotFoundException(string s):base(s)
        {
          
        }

    }
  public class BankRepository:IBankRepository
    {   DatabaseTrainingContext db=new DatabaseTrainingContext();
          ManishaSbaccount sbaccount=new ManishaSbaccount();  
        // static int transcount=1;
        /*List<SBAccount> s=new List<SBAccount>();
        List<SBTransaction> st=new List<SBTransaction>();*/
        public void NewAccount(ManishaSbaccount sbaccount)
        {
             sbaccount=new ManishaSbaccount();  
            Console.WriteLine("Enter Account No.,Name,address,balance");
            sbaccount.Accno=Convert.ToInt32(Console.ReadLine());
            sbaccount.Name=Console.ReadLine();
            sbaccount.Address=Console.ReadLine();
            sbaccount.Bal=decimal.Parse(Console.ReadLine());
            db.ManishaSbaccounts.Add(sbaccount);
            db.SaveChanges();
            Console.WriteLine("Your Account has been added!!");
        }
       public ManishaSbaccount GetAccountDetails(int accno)
        { 
            var item = db.ManishaSbaccounts.FirstOrDefault(x => (x.Accno==accno));
            if(item==null)
            {
                throw new AccountNotFoundException("No Data Found For this Account Number");
            }
            return item;
           

        }
       public  bool DepositAmount(int accno,decimal amt)
        {   
            var item = db.ManishaSbaccounts.FirstOrDefault(x => (x.Accno==accno));
            if(item==null)
            {
                 throw new AccountNotFoundException("No Data Found For this Account Number");
            }
            item.Bal=amt+item.Bal;
            ManishaSbtransaction strans=new ManishaSbtransaction();
            strans.Accno=accno;strans.Amt=amt;strans.TransDate=DateTime.Now;strans.TransType="Deposit";
            var item2 = db.ManishaSbtransactions.OrderByDescending(o=>o.TransId).FirstOrDefault();
            int p=item2.TransId;
            p=p+1;
            strans.TransId=p;
            db.ManishaSbtransactions.Add(strans);
            int value=db.SaveChanges();
            if(value!=0)
                return true;
            else
                return false;
           
        }
        
       public  bool WithdrawAmount(int accno,decimal amt)
        {   
            var item = db.ManishaSbaccounts.FirstOrDefault(x => (x.Accno==accno));
            if(item==null)
            {
                 throw new AccountNotFoundException("No Data Found For this Account Number");
            }
            else
            {
                if((amt>=item.Bal) || (item.Bal-amt)<500)
                    throw new MoneyCannotWithdrawException("No Sufficient Balance Available to make the transaction!!");
                item.Bal=item.Bal-amt;
                ManishaSbtransaction strans2=new ManishaSbtransaction();
                

                strans2.Accno=accno;strans2.Amt=amt;strans2.TransDate=DateTime.Now;strans2.TransType="Withdraw";
                var item2 = db.ManishaSbtransactions.OrderByDescending(o=>o.TransId).FirstOrDefault();
                int p2=item2.TransId;
                p2=p2+1;
                strans2.TransId=p2;
                db.ManishaSbtransactions.Add(strans2);
                int value=db.SaveChanges();
                if(value!=0)
                return true;
                else
                return false;
            }   
            
        }
        
        public List<ManishaSbaccount> GetAllAccounts()
        {  List<ManishaSbaccount> l2=new List<ManishaSbaccount>();
            foreach(var item in db.ManishaSbaccounts)
                {
                    
                    l2.Add(item);
                }
                return l2;
        }
        
        public List<ManishaSbtransaction> GetTransactions(int accno)
        {   List<ManishaSbtransaction> l2=new List<ManishaSbtransaction>();
            foreach(var item in db.ManishaSbtransactions)
            {
                if(item.Accno==accno)
                {
                    l2.Add(item);
                }
            }
            return l2;
        }

        public bool ValidateUser(int accno)
        {
            var item = db.ManishaSbaccounts.FirstOrDefault(x => (x.Accno==accno));
            if(item==null)
            {
                return false;
            }
            return true;
        }
        public void UpdatedAmount(int accno)
        {
            var item = db.ManishaSbaccounts.FirstOrDefault(x => (x.Accno==accno));  
            Console.WriteLine("Your Updated Banlance: "+item.Bal);
        }
        public void Transfer(int acc1,int acc2,decimal Amt)
        {
            
            bool k=WithdrawAmount(acc1,Amt);
            bool k2=DepositAmount(acc2,Amt);
            db.SaveChanges();
            if(k==true && k2==true)
                Console.WriteLine("Amount Has Been Transferred!!");
            else
                Console.WriteLine("Amount Cannot be Transferred!!Please Try again Later");  

        }
    }
    
}
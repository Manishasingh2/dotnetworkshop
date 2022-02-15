using System;
using System.Collections.Generic;
using BankLibrary.Models;
namespace BankLibrary
{
    public interface IBankRepository
    {
       
        void NewAccount( ManishaSbaccount sbaccount);
        ManishaSbaccount GetAccountDetails(int accno);
        bool DepositAmount(int accno,decimal amt);
        
        bool WithdrawAmount(int accno,decimal amt);
        List<ManishaSbaccount> GetAllAccounts();
        List< ManishaSbtransaction> GetTransactions(int accno);
        bool ValidateUser(int accno);
        public void UpdatedAmount(int accno);
        void Transfer(int acc1,int acc2,decimal Amt);

    }
}
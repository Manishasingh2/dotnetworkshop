using System;
namespace Question2
{
    class BankingException:ApplicationException
    {
        public BankingException(string s):base(s)
        {
          
        }

    }
    class BankSystem
    {
        int amt;
        public void CheckAmt()
        {
            Console.WriteLine("Enter Amount to Withdraw");
            int.TryParse(Console.ReadLine(),out amt);
            if(amt<500)
            {
                throw new AgenotvalidException("Money Cannot be Withdrwan");
            }
            else{
                Console.WriteLine("Can be Withdrwan");
            }
        }
    }
}
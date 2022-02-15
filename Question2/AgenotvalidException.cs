using System;
namespace Question2
{
    class AgenotvalidException:ApplicationException
    {
        public AgenotvalidException(string s):base(s)
        {
          
        }

    }
    class VotingSystem
    {
        int age;
        public void CheckAge()
        {
            Console.WriteLine("ENter Age");
            int.TryParse(Console.ReadLine(),out age);
            if(age<18)
            {
                throw new AgenotvalidException("Sorry not eligible");
            }
            else{
                Console.WriteLine("Eligible");
            }
        }
    }
}
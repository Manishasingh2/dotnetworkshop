using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements");
            int n=Convert.ToInt32(Console.ReadLine());
            int []ar=new int[n];
            Console.WriteLine("Enter elements");
            for(int i=0;i<n;i++)
            {
                ar[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<n;i++)
            { int c=ar[i];
            int sum=0;
            while(ar[i]!=0)
            {
                int k=ar[i]%10;
                sum+=k;
                ar[i]=ar[i]/10;
            }
            Console.WriteLine("Sum of Digits of "+c+"="+sum);}
        }
    }
}

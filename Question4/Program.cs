using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string and char");
            string s=Console.ReadLine();
            char ch=Convert.ToChar(Console.ReadLine());
            int c=0,i=0;
            for(i=0;i<s.Length;i++)
            {   string p=ch.ToString();
                 string k=s.Substring(i,1);
                if(k.Equals(p))
                c++;
            }
            Console.WriteLine(c);
        }
    }
}

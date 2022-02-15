using System;

namespace ThirdPrj
{
    class Casio : ICalculator
    {
       public int x {get;set;}
      public void add(int a,int b)
       {
         Console.WriteLine(a+b);
       }
       public void sub(int a,int b)
       {
           Console.WriteLine(a-b);
       }
       
       public void mul(int a,int b)
       {
         Console.WriteLine(a*b);
       }
       public void div(int a,int b)
       {
           Console.WriteLine(a/b);
       }
    }

}
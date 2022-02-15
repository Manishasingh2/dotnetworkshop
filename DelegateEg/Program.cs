using System;

namespace DelegateEg
{
    class Program
    {
        //delegate declaration
        public delegate int deladd(int x,int y);
        public delegate void delmsg(string a);
        public static int add(int a,int b)
        {
            return a+b;
        }
        public int mul(int a,int b)
        {
            return a*b;
        }
        public void message(string msg)
        {
            Console.WriteLine("Message is"+msg);
        }
        static void main(string[] args)
        {   Program p=new Program();
            deladd d1=new deladd(add);
            deladd d2=new deladd(p.mul);
            delmsg d3=new delmsg(p.message);
            int result=d1(10,20);
            int res2=d2(1,5);
            Console.WriteLine(result);
            Console.WriteLine(res2);
            d3("Hello Manisha");
        }
    }
}

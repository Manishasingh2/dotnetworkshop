using System;

namespace Question10
{
    class Program
    {

        void swap(ref int a,ref int b)
        {
            int tmp=a;
            a=b;
            b=tmp;  

        }
        void swap(ref string s,ref string s2)
        {
            string tmp=s;
            s=s2;
            s2=tmp;
        }
        static void Main(string[] args)
        {
           Program p=new Program();
           int a=10,b=20;
           string s="manisha",s2="singh";
           p.swap(ref a,ref b);
           Console.WriteLine(a+" "+b);
           p.swap(ref s,ref s2);
           Console.WriteLine(s+""+s2);
        }
    }
}

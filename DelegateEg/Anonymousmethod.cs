using System;
namespace  DelegteEg
{
    public delegate void favcolor(string color);
    class Anonymousmethod
    {
       public static void Main()
       {
           favcolor p=delegate(string color)
           {
               Console.WriteLine(color);
           };
           p("Green");
       }
    }
}
using System;

namespace ThirdPrj
{

sealed class Demo
{
    public void display()
    {
        Console.WriteLine("Hello");
    }
}
static class staticclass
{
  
   public static int x{get;set;}
   public static void display()
   {
       Console.WriteLine("Method");
   }
}

class staticclient
{
    /*public static void Main()
    {
        staticclass.display();
        staticclass.x=10;
    Console.WriteLine(staticclass.x);
    Demo demo=new Demo();
    demo.display();
    }*/
}
}
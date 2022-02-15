using System;

namespace Question11
{
    class Test
    {
       public static void Main()
       {
           Box ob=new Box(10,20);
           Box ob2=new Box(5,5);
           Box b3=new Box();
           b3=ob+ob2;
           b3.display();
       }
    }
}

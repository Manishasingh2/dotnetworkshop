using System;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
           Doctor d=new Doctor();
           d.Name="Manisha";
           d.FeesCharged=100;
           d.RGNO=45;
           Console.WriteLine(d.Name+" "+d.RGNO+" "+d.FeesCharged);
        }
    }
}

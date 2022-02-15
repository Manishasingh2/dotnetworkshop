using System;

namespace ThirdPrj
{
    class Client
    {
    public static void Main()
    {
        ICalculator casio=new Casio();
        casio.add(10,20);
        casio.sub(20,10);
        casio.x=6;
        Console.WriteLine(casio.x);

    }
    }
}
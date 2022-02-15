using System;
using System.Threading;
namespace  LINQEg
{
    class ThreadEg
    {
        static void Main()
        {
            Thread t=new Thread(WriteY);
            t.Start();
            //Thread.Sleep(10000);
            //t.Join();
            Console.WriteLine("Thread ENded");
            for(int i=0;i<10;i++)
            {
                Console.Write("x");
            }
        }
            static void WriteY()
            {
            for(int i=0;i<10;i++)
            {
                Console.Write("y");
            }
            Console.WriteLine("Hello");
            }
        
    }
}
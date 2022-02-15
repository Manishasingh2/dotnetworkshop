using System;
using System.IO;
namespace  DelegateEg
{
    public delegate void printmsg(string msg);
    class MulticastDel
    {
        public static void printtoconsole(string msg)
        {
            Console.WriteLine("Hello "+msg);
        }
        public static void printtofile(string msg)
        {
            FileStream fs=new FileStream("msglog.txt",FileMode.Append,FileAccess.Write);
            StreamWriter s=new StreamWriter(fs);
            s.WriteLine(msg+DateTime.Now);
            s.Flush();
            fs.Close();

        }
        public static void main()
        {
            printmsg p1=new printmsg(printtoconsole);
            printmsg p2=new printmsg(printtofile);
            printmsg p3=p1+p2;
            Console.WriteLine("ENter data");
            string data=Console.ReadLine();
            p3(data);
        }
    }
}
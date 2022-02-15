using System;

namespace SecondPrj
{
    class Program
    {
        string FirstName,LastName;
        Program(string FirstName,string LastName)
        {
            this.FirstName=FirstName;
            this.LastName=LastName;
        }
        static void display(Program p)
        {      
               Console.WriteLine("FirstName="+p.FirstName.ToUpper());
               Console.WriteLine("LastName="+p.LastName.ToUpper());
        }
        /*static void Main(string[] args)
        {  
            Program program=new Program("Manisha","Singh");
            Program.display(program);
        }*/
    }
}

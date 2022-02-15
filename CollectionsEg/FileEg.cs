using System;
using System.IO;
namespace CollectionsEg
{
    class FileEg
    {
        public static void Main()
        {
        FileStream fileStream=new FileStream("message.txt",FileMode.Append,FileAccess.Write);
        StreamWriter s=new StreamWriter(fileStream);
        try
        {
             Console.WriteLine("Enter your name");
             string name=Console.ReadLine();
             s.WriteLine(name+" "+DateTime.Now);
             Console.WriteLine("Data Written");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            
        }
        finally{
            s.Flush();
            fileStream.Close();
        }
        }
        
    }
}
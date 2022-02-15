using System;
namespace SecondPrj
{
    class Scholarship
    { 
       int marks,fee;
        float merit()
        {   Console.WriteLine("Enter marks and fee");
            marks=Convert.ToInt32(Console.ReadLine());
            fee=Convert.ToInt32(Console.ReadLine());
            float sum=0.0f;
             if(marks>=70 && marks<=80)
             sum=(0.2f)*fee;
             else if(marks>80 && marks<=90)
             sum=(0.3f)*fee;
             else
             sum=(0.5f)*fee;
            return sum;
        }
        static void Main(string[] args)
        {
            
            Scholarship scholarship=new Scholarship();
            float amount=scholarship.merit();
            Console.WriteLine("Scholarship amount="+amount);
        }
    }
}

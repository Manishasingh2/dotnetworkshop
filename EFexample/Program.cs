using System;
using EFexample.Models;
namespace EFexample
{
    class Program
    {
        static void Main(string[] args)
        {
           DatabaseTrainingContext db=new DatabaseTrainingContext();
            Manisha employee=new Manisha();
            employee.Eid=100;
            employee.Ename="Vandhana";
            employee.Salary=56800;
            
            db.Manishas.Add(employee);
            db.SaveChanges();
            foreach(var item in db.Manishas)
            {
                Console.WriteLine(item.Eid+" "+item.Ename+" "+item.Salary);
            }
        }
    }
}

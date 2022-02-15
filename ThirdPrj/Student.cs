using System;

namespace ThirdPrj
{

    abstract class Student
    {
        protected string name;
        protected int StudentId,Grade;
         public virtual void enterdetails()
        {
            Console.WriteLine("Enter name and student id");
            name=Console.ReadLine();
            StudentId=Convert.ToInt32(Console.ReadLine());
        }
        public abstract bool Ispassed(int Grade);

    }

    class UnderGraduate:Student
    {
      
      public override void enterdetails()
      {
       base.enterdetails();   
      }
       public override bool Ispassed(int Grade)
        {
           if(Grade>70)
           return true;
           else return false;
        }
    }
    class Graduate:Student
    {
    public override void enterdetails()
      {
       base.enterdetails();   
      }
        public override bool Ispassed(int Grade)
        {
            if(Grade>80)
            return true;
            else
             return false;
        }
    }
}
